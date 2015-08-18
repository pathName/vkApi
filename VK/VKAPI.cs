/*
 * Пример к статье: Разработка desktop-приложения для «ВКонтакте» на C#
 * Автор: Алексей Немиро
 * http://aleksey.nemiro.ru
 * http://foxtools.ru
 * http://kbyte.ru
 * 24.07.2011
 * 
 * По всем вопросам обращайтесь на форум:
 * http://kbyte.ru/ru/Forums?id=0
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Specialized;
using System.Xml;
using System.Threading;
using System.Collections;

namespace VK
{
  class VKAPI
  {

    public int UserId = 0;
    public string AccessToken = "";

    public VKAPI(int userId, string accessToken)
    {
      this.UserId = userId;
      this.AccessToken = accessToken;
    }

    /// <summary>
    /// Возвращает профиль текущего пользователя
    /// </summary>
    public XmlDocument GetProfile()
    {
      return GetProfile(this.UserId);
    }
    /// <summary>
    /// Возвращает профиль указанного пользователя
    /// </summary>
    /// <param name="uid">Идентификатор пользователя</param>
    /// <remarks>
    /// Вообще, при желании все это можно сделать на более высоком уровне - 
    /// создать класс User, заполнять его из XML, и возвращать вместо XmlDocument.
    /// Можно даже использовать XML-сериализацию
    /// http://kbyte.ru/ru/Programming/Articles.aspx?id=40&mode=art
    /// </remarks>
    public XmlDocument GetProfile(int uid)
    {
      NameValueCollection qs = new NameValueCollection();
      qs["uid"] = uid.ToString();
      qs["fields"] = "uid,first_name,last_name,nickname,domain,sex,bdate,city,country,timezone,photo,has_mobile,rate,contacts,education,online";
      return ExecuteCommand("getProfiles", qs);
    }

    /// <summary>
    /// Возвращает список друзей текущего пользователя
    /// </summary>
    public XmlDocument GetFriends()
    {
      return GetFriends(this.UserId);
    }
    /// <summary>
    /// Возвращает список друзей указанного пользователя
    /// </summary>
    /// <param name="uid">Идентификатор пользователя</param>
    public XmlDocument GetFriends(int uid)
    {
      NameValueCollection qs = new NameValueCollection();
      qs["uid"] = uid.ToString();
      qs["fields"] = "uid,first_name,last_name,nickname,domain,sex,bdate,city,country,timezone,photo,has_mobile,rate,contacts,education,online";
      return ExecuteCommand("friends.get", qs);
    }

    /// <summary>
    /// Публикует текстовое сообщение на стене текущего пользователя
    /// </summary>
    /// <param name="message">Текст сообщения</param>
    public bool WallPost(string message)
    {
      return WallPost(this.UserId, message);
    }
    /// <summary>
    /// Публикует текстовое сообщение на стене указанного пользователя
    /// </summary>
    /// <param name="uid">Идентификатор пользователя</param>
    /// <param name="message">Текст сообщения</param>
    public bool WallPost(int uid, string message)
    {
      NameValueCollection qs = new NameValueCollection();
      qs["owner_id"] = uid.ToString();
      qs["message"] = message;
      ExecuteCommand("wall.post", qs);
      return true;
    }

    /// <summary>
    /// Возвращает 100 последних записей со стены текущего пользователя
    /// </summary>
    public XmlDocument GetWall()
    {
      return GetWall(this.UserId);
    }
    /// <summary>
    /// Возвращает 100 последних записей со стены указанного пользователя
    /// </summary>
    /// <param name="uid">Идентификатор пользователя</param>
    public XmlDocument GetWall(int uid)
    {
      NameValueCollection qs = new NameValueCollection();
      qs["owner_id"] = uid.ToString();
      qs["count"] = "100";
      return ExecuteCommand("wall.get", qs);
    }

    /// <summary>
    /// Возвращает название города по коду
    /// </summary>
    /// <param name="id">Код города</param>
    public string GetCity(int id)
    {
      if (id <= 0) { return "нет данных"; }
      NameValueCollection qs = new NameValueCollection();
      qs["api_id"] = Program.appId.ToString();
      //qs["sig"] = this.AccessToken;
      qs["cids"] = id.ToString();
      XmlDocument city = ExecuteCommand("getCities", qs);
      return Helper.GetDataFromXmlNode(city.SelectSingleNode("response/city/name"));
    }

    /// <summary>
    /// Возвращает название страны по коду
    /// </summary>
    /// <param name="id">Код страны</param>
    /// <returns></returns>
    public string GetCountry(int id)
    {
      if (id <= 0) { return "нет данных"; }
      NameValueCollection qs = new NameValueCollection();
      qs["api_id"] = Program.appId.ToString();
      //qs["sig"] = this.AccessToken;
      qs["cids"] = id.ToString();
      XmlDocument country = ExecuteCommand("getCountries", qs);
      return Helper.GetDataFromXmlNode(country.SelectSingleNode("response/country/name"));
    }

    /// <summary>
    /// Выполняет запрос к API 
    /// </summary>
    /// <param name="name">Имя api-метода</param>
    /// <param name="qs">Дополнительные параметры</param>
    private XmlDocument ExecuteCommand(string name, NameValueCollection qs)
    {
      // создаем прогресс
      frmProgress frm = new frmProgress();
      frm.Owner = Program.applicationContext.MainForm;
      // передаем параметры в Tag формы прогресса
      Hashtable pars = new Hashtable();
      pars.Add("name", name);
      pars.Add("qs", qs);
      frm.Tag = pars;

      // запускаем процесс выполнения запроса в отдельном потоке
      Thread t = new Thread(ExecuteCommandThread);
      t.IsBackground = true;
      t.Start(frm);

      // показываем прогесс
      frm.ShowDialog();

      // возвращаем результат из Tag формы прогресса
      return (XmlDocument)frm.Tag;
    }
    private void ExecuteCommandThread(object args)
    {
      frmProgress frm = (frmProgress)args;
      string name = ((Hashtable)frm.Tag)["name"].ToString();
      NameValueCollection qs = (NameValueCollection)((Hashtable)frm.Tag)["qs"];

      frm.SetDescription(String.Format("Выполняю команду {0}", name));
      XmlDocument result = new XmlDocument();
      result.Load(String.Format("https://api.vkontakte.ru/method/{0}.xml?access_token={1}&{2}", name, this.AccessToken, String.Join("&", from item in qs.AllKeys select item + "=" + qs[item])));
      if (result.SelectSingleNode("error") != null)
      {
        throw new Exception("Error. " + result.SelectSingleNode("error/error_msg"));
      }
      frm.SetDescription("Команда успешно выполнена.");

      // передаем результат в Tag формы прогресса
      frm.SetTag(result);
      // закрываем форму прогресса
      frm.CloseMe();
    }
  }

}

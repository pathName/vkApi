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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Specialized;
using System.Web;
using System.Threading;
using System.Collections;

namespace VK
{
  public partial class frmSignin4RealGuys : Form
  {
    public frmSignin4RealGuys()
    {
      InitializeComponent();
    }

    private void btnSignin_Click(object sender, EventArgs e)
    {
      if (String.IsNullOrEmpty(tbLogin.Text))
      {
        MessageBox.Show("Требуется указать логин.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }
      if (String.IsNullOrEmpty(tbPassword.Text))
      {
        MessageBox.Show("Требуется указать пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      // создаем прогресс
      frmProgress frm = new frmProgress();
      frm.FormDead += new EventHandler(frmProgress_FormDead);
      frm.Owner = this;

      // запускаем процесс авторизации вконтакте в отдельном потоке
      Thread t = new Thread(Signin);
      t.IsBackground = true;
      t.Start(frm);

      // показываем прогесс
      frm.ShowDialog();
    }

    private void frmProgress_FormDead(object sender, EventArgs e)
    {
      // смотрим, есть ключ доступа в Tag-е формы, или нет
      if (((frmProgress)sender).Tag == null) 
      { 
        // ключа нет, значит какая-то ошибка
        // выходим
        return;
      }
      // ключ найден, 
      Hashtable t = (Hashtable)((frmProgress)sender).Tag;
      // инициализируем api вконтакте
      Program.API = new VKAPI(Convert.ToInt32(t["userId"]), t["accessToken"].ToString());
      // запускаем главную форму
      Program.applicationContext.MainForm = new frmVkontakteContainer();
      // создаем форму с профилем текущего пользователя
      new frmVkontakte(Convert.ToInt32(t["userId"])) { MdiParent = Program.applicationContext.MainForm }.Show();
      // показываем главную форму
      Program.applicationContext.MainForm.Show();
      // закрываем текущую форму
      this.Close();
    }

    private void Signin(object args)
    {
      try
      {
        frmProgress frm = (frmProgress)args;
        // 1. Заходим на страницу авторизации
        frm.SetDescription("Захожу на страницу авторизации.");

        HttpWebRequest myReq = (HttpWebRequest)HttpWebRequest.Create(String.Format("http://api.vkontakte.ru/oauth/authorize?client_id={0}&scope={1}&display=wap&response_type=token", Program.appId, Program.scope));
        HttpWebResponse myResp = (HttpWebResponse)myReq.GetResponse();
        StreamReader myStream = new StreamReader(myResp.GetResponseStream(), Encoding.UTF8);
        string html = myStream.ReadToEnd();

        // дергаем форму авторизации
        Regex myReg = new Regex("<form(.*?)>(?<form_body>.*?)</form>", RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.Singleline);
        if (!myReg.IsMatch(html) || (html = myReg.Match(html).Groups["form_body"].Value) == "")
        {
          MessageBox.Show("Не удалось получить форму авторизации. Проверьте шаблон регулярного выражения.");
          frm.CloseMe();
          return;
        }

        // затем элементы формы
        myReg = new Regex("<input(.*?)name=\"(?<name>[^\x22]+)\"(.*?)((value=\"(?<value>[^\x22]*)\"(.*?))|(.?))>", RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.Singleline);
        NameValueCollection qs = new NameValueCollection();
        foreach (Match m in myReg.Matches(html))
        {
          string val = m.Groups["value"].Value; // по умолчанию отдаем, то что приняли
          // если нашли поля для ввода логина и пароля, то указываем их
          if (m.Groups["name"].Value == "email")
          {
            val = tbLogin.Text;
          }
          else if (m.Groups["name"].Value == "pass")
          {
            val = tbPassword.Text;
          }
          // добавляем значение в коллекцию
          // в последующем из этой коллекции будут сформированы параметры для запроса авторизации
          qs.Add(m.Groups["name"].Value, HttpUtility.UrlEncode(val));
        }

        // *********************************************************************************************************************
        // 2. Авторизируемся
        frm.SetDescription("Пробую пройти процедуру авторизации.");

        byte[] b = System.Text.Encoding.UTF8.GetBytes(String.Join("&", from item in qs.AllKeys select item + "=" + qs[item]));

        myReq = (HttpWebRequest)HttpWebRequest.Create("https://login.vk.com/?act=login&soft=1&utf8=1");
        myReq.CookieContainer = new CookieContainer();
        myReq.Method = "POST";
        myReq.ContentType = "application/x-www-form-urlencoded";
        myReq.ContentLength = b.Length;
        myReq.GetRequestStream().Write(b, 0, b.Length);
        myReq.AllowAutoRedirect = false;

        myResp = (HttpWebResponse)myReq.GetResponse();

        // запоминаем куки
        CookieContainer cc = new CookieContainer();
        foreach (Cookie c in myResp.Cookies)
        {
          cc.Add(c);
        }
        // --

        // *********************************************************************************************************************
        // 3. В случае успеха получаем редирект

        if (!String.IsNullOrEmpty(myResp.Headers["Location"]))
        {
          // делаем редирект
          myReq = (HttpWebRequest)HttpWebRequest.Create(myResp.Headers["Location"]);
          myReq.CookieContainer = cc;// передаем куки
          myReq.Method = "GET";
          myReq.ContentType = "text/html";

          myResp = (HttpWebResponse)myReq.GetResponse();
          myStream = new StreamReader(myResp.GetResponseStream(), Encoding.UTF8);
          html = myStream.ReadToEnd();
        }
        else
        {
          // что-то пошло не так
          MessageBox.Show("Ошибка. Ожидался редирект.");
          frm.CloseMe();
          return;
        }

        // смотрим, прошла авторизация или нет
        myReg = new Regex("Вы авторизованы как <b><a href=\"(?<url>[^\\x22]+)\">(?<user>[^\\x3c]+)</a></b>", RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.Singleline);
        if (!myReg.IsMatch(html))
        {
          MessageBox.Show("Ошибка: Авторизация не прошла.");
          frm.CloseMe();
          return;
        }
        frm.SetDescription("Авторизация прошла успешно.\r\nПробую получить права.");

        // вообще в данный момент нужен только url формы, на который будут отправляться параметры
        // но если в форме появятся другие элементы, то их можно распарсить из form_body, как в предыдущей форме
        myReg = new Regex("<form(.*?)action=\"(?<post_url>[^\\x22]+)\"(.*?)>(?<form_body>.*?)</form>", RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.Singleline);
        if (!myReg.IsMatch(html))
        {
          MessageBox.Show("Не удалось получить форму. Проверьте шаблон регулярного выражения.");
          frm.CloseMe();
          return;
        }

        string url = myReg.Match(html).Groups["post_url"].Value;
        if (!url.ToLower().StartsWith("http://")) { url = String.Format("http://api.vkontakte.ru{0}", url); }

        // *********************************************************************************************************************
        // 4. Отправляем запрос на получение прав для приложения
        myReq = (HttpWebRequest)HttpWebRequest.Create(url);
        myReq.CookieContainer = cc; // не забываем передавать куки
        myReq.Method = "POST";
        myReq.ContentType = "application/x-www-form-urlencoded";
        myReq.AllowAutoRedirect = false;

        myResp = (HttpWebResponse)myReq.GetResponse();

        string accessToken = "";
        int userId = 0;
        if (!String.IsNullOrEmpty(myResp.Headers["Location"]))
        {
          // редирект делать не обязательно
          // парсим полученный url
          myReg = new Regex(@"(?<name>[\w\d\x5f]+)=(?<value>[^\x26\s]+)", RegexOptions.IgnoreCase | RegexOptions.Singleline);
          foreach (Match m in myReg.Matches(myResp.Headers["Location"]))
          {
            if (m.Groups["name"].Value == "access_token")
            {
              accessToken = m.Groups["value"].Value;
            }
            else if (m.Groups["name"].Value == "user_id")
            {
              userId = Convert.ToInt32(m.Groups["value"].Value);
            }
            // еще можно запомнить строк жизни access_token - expires_in,
            // если нужно
          }
        }

        if (String.IsNullOrEmpty(accessToken))
        {
          MessageBox.Show("Ошибка. Ключ доступа не найден. По всем вопросам обращайтесь на форум: http://kbyte.ru/ru/Forums?id=0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
          frm.CloseMe();
          return;
        }

        frm.SetDescription("Права успешно получены.");

        // передаем данные в форму прогресса
        Hashtable t = new Hashtable();
        t.Add("userId", userId);
        t.Add("accessToken", accessToken);
        frm.SetTag(t);
        // закрываем форму прогресса
        frm.CloseMe();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error. " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      Program.applicationContext.MainForm = new frmMain();
      Program.applicationContext.MainForm.Show();
      this.Close();
    }
  }
}

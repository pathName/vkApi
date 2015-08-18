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
using System.Windows.Forms;

namespace VK
{
  static class Program
  {

    #region Глобальные перечисления
    public enum VkontakteScopeList
    {
      /// <summary>
      /// Пользователь разрешил отправлять ему уведомления. 
      /// </summary>
      notify = 1,
      /// <summary>
      /// Доступ к друзьям.
      /// </summary>
      friends = 2,
      /// <summary>
      /// Доступ к фотографиям. 
      /// </summary>
      photos = 4,
      /// <summary>
      /// Доступ к аудиозаписям. 
      /// </summary>
      audio = 8,
      /// <summary>
      /// Доступ к видеозаписям. 
      /// </summary>
      video = 16,
      /// <summary>
      /// Доступ к предложениям (устаревшие методы). 
      /// </summary>
      offers = 32,
      /// <summary>
      /// Доступ к вопросам (устаревшие методы). 
      /// </summary>
      questions = 64,
      /// <summary>
      /// Доступ к wiki-страницам. 
      /// </summary>
      pages = 128,
      /// <summary>
      /// Добавление ссылки на приложение в меню слева.
      /// </summary>
      link = 256,
      /// <summary>
      /// Доступ заметкам пользователя. 
      /// </summary>
      notes = 2048,
      /// <summary>
      /// (для Standalone-приложений) Доступ к расширенным методам работы с сообщениями. 
      /// </summary>
      messages = 4096,
      /// <summary>
      /// Доступ к обычным и расширенным методам работы со стеной. 
      /// </summary>
      wall = 8192,
      /// <summary>
      /// Доступ к документам пользователя.
      /// </summary>
      docs = 131072
    }
    #endregion

    public static ApplicationContext applicationContext;

    /// <summary>
    /// Идентификатор приложения.
    /// Cм. в параметрах приложения на сайте вконтакте
    /// </summary>
    public static int appId = 2419779;
    /// <summary>
    /// Права, необходимые приложению - запрашиваются у пользователя
    /// </summary>
     public static int scope = (int)(VkontakteScopeList.audio | VkontakteScopeList.docs | VkontakteScopeList.friends | VkontakteScopeList.link | VkontakteScopeList.messages | VkontakteScopeList.notes | VkontakteScopeList.notify | VkontakteScopeList.offers | VkontakteScopeList.pages | VkontakteScopeList.photos | VkontakteScopeList.questions | VkontakteScopeList.video | VkontakteScopeList.wall);

    /// <summary>
    /// Глобальная переменная для доступа к API ВКонтакте
    /// </summary>
    public static VKAPI API = null;

    /// <summary>
    /// Главная точка входа для приложения.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      applicationContext = new ApplicationContext(new frmMain());
      Application.Run(applicationContext);
    }
  }
}

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
using System.Text.RegularExpressions;

namespace VK
{
  public partial class frmSigninSafe : Form
  {
    public frmSigninSafe()
    {
      InitializeComponent();
    }

    private void frmSigninSafe_Load(object sender, EventArgs e)
    {
      webBrowser1.Navigate(String.Format("http://api.vkontakte.ru/oauth/authorize?client_id={0}&scope={1}&display=popup&response_type=token", Program.appId, Program.scope));
    }

    private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
    {
      if (e.Url.ToString().IndexOf("access_token") != -1)
      {
        string accessToken = "";
        int userId = 0;
        Regex myReg = new Regex(@"(?<name>[\w\d\x5f]+)=(?<value>[^\x26\s]+)", RegexOptions.IgnoreCase | RegexOptions.Singleline);
        foreach (Match m in myReg.Matches(e.Url.ToString()))
        {
          if (m.Groups["name"].Value == "access_token")
          {
            accessToken = m.Groups["value"].Value;
          }
          else if (m.Groups["name"].Value == "user_id")
          {
            userId = Convert.ToInt32(m.Groups["value"].Value);
          }
        }
        if (String.IsNullOrEmpty(accessToken))
        {
          MessageBox.Show("Ошибка. Ключ доступа не найден. По всем вопросам обращайтесь на форум: http://kbyte.ru/ru/Forums?id=0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }
        // ключ найден, 
        // инициализируем api вконтакте
        Program.API = new VKAPI(userId, accessToken);
        // запускаем главную форму
        Program.applicationContext.MainForm = new frmVkontakteContainer();
        // создаем форму с профилем текущего пользователя
        new frmVkontakte(userId) { MdiParent = Program.applicationContext.MainForm }.Show();
        // показываем главную форму
        Program.applicationContext.MainForm.Show();
        // закрываем текущую форму
        this.Close();
      }
      else if (e.Url.ToString().IndexOf("user_denied") != -1)
      {
        // пользователь отказался входить
        Program.applicationContext.MainForm = new frmMain();
        Program.applicationContext.MainForm.Show();
        this.Close();
      }
    }
  }
}

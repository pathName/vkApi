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
using System.Xml;
using System.Collections.Specialized;
using System.IO;
using System.Net;

namespace VK
{
  public partial class frmVkontakte : Form
  {
    public int UserId = 0;

    public frmVkontakte(int userId)
    {
      InitializeComponent();
      this.UserId = userId;
    }

    private void frmVkontakte_Load(object sender, EventArgs e)
    {
      profileViewer1.UserId = this.UserId;
    }

    private void btnUpdateFriendList_Click(object sender, EventArgs e)
    {
      try
      {
        pcFriends.BindProfiles(Program.API.GetFriends(this.UserId));
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error. " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void btnSendMessage_Click(object sender, EventArgs e)
    {
      if (String.IsNullOrEmpty(tbNewMessage.Text))
      {
        MessageBox.Show("Требуется указать текст сообщения для публикации на стене.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      try
      {
        Program.API.WallPost(this.UserId, tbNewMessage.Text);
        MessageBox.Show("Запись успешно опубликована на стене пользователя!\r\n\r\nНажмите на кнопку 'Обновить', чтобы посмотреть все записи стены пользователя.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
        tbNewMessage.Text = "";
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error. " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void btnUpdateWall_Click(object sender, EventArgs e)
    {
      try
      {
        tbWall.Text = "";
        XmlDocument wall = Program.API.GetWall(this.UserId);
        foreach (XmlNode n in wall.SelectNodes("/response/post"))
        {
          if (!string.IsNullOrEmpty(tbWall.Text)) { tbWall.Text += "\r\n\r\n"; }
          tbWall.Text += String.Format("Сообщение #{0}\r\n{1}", n.SelectSingleNode("id").InnerText, n.SelectSingleNode("text").InnerText);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error. " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void profileViewer1_ProfileLoaded(ProfileViewer sender, string name)
    {
      this.Text = name;
    }

  }
}

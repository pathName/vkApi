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
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace VK
{
  public partial class ProfileContainer : UserControl
  {
    public ProfileContainer()
    {
      InitializeComponent();
    }

    public void Clear()
    {
      this.Controls.Clear();
    }

    public void BindProfiles(XmlDocument doc)
    {
      this.Clear();
      foreach (XmlNode n in doc.SelectNodes("/response/user"))
      {
        this.AddItem(n);
      }
    }

    public void AddItem(XmlNode n)
    {
      this.Controls.Add(
      new ProfileViewer(n)
      {
        Visible = true,
        Left = 0,
        Top = (this.Controls.Count <= 0 ? 0 : this.Controls[this.Controls.Count - 1].Top + this.Controls[this.Controls.Count - 1].Height + 2),
        Width = this.Width - 18,
        Mode = ProfileViewer.ViewMode.collapse,
        BackColor = (this.Controls.Count % 2 == 0 ? SystemColors.Control : SystemColors.ControlDark)
      });
      ((ProfileViewer)this.Controls[this.Controls.Count - 1]).ModeChange += new EventHandler(ProfileViewer_ModeChange);
      Application.DoEvents();
    }

    private void ProfileViewer_ModeChange(object sender, EventArgs e)
    {
      int vs = this.VerticalScroll.Value;
      this.VerticalScroll.Value = 0;
      for (int i = 0; i <= this.Controls.Count - 1; i++)
      {
        this.Controls[i].Top = (i == 0 ? 0 : this.Controls[i - 1].Top + this.Controls[i - 1].Height + 2);
        Application.DoEvents();
      }
      this.VerticalScroll.Value = vs;
    }
  }
}

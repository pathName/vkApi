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
using System.Collections;

namespace VK
{
  public partial class frmProgress : Form
  {
    public event EventHandler FormDead;

    public frmProgress()
    {
      InitializeComponent();
    }

    private void frmProgress_Load(object sender, EventArgs e)
    {

    }

    private delegate void DelegateSetDescription(string str);
    public void SetDescription(string str)
    {
      if (this.InvokeRequired)
      {
        this.Invoke(new DelegateSetDescription(SetDescription), str);
        return;
      }
      lblDescription.Text = str;
      Application.DoEvents();
    }

    private delegate void DelegateSetTag(object t);
    public void SetTag(object t)
    {
      if (this.InvokeRequired)
      {
        this.Invoke(new DelegateSetTag(SetTag), t);
        return;
      }
      this.Tag = t;
      Application.DoEvents();
    }

    private delegate void DelegateCloseMe();
    public void CloseMe()
    {
      if (this.InvokeRequired)
      {
        this.Invoke(new DelegateCloseMe(CloseMe));
        return;
      }
      EventHandler handler = FormDead;
      if (handler != null) { handler(this, null); }
      this.Close();
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }
  }
}

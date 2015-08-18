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

namespace VK
{
  public partial class frmMain : Form
  {
    public frmMain()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Program.applicationContext.MainForm = new frmSigninSafe();
      Program.applicationContext.MainForm.Show();
      this.Close();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Program.applicationContext.MainForm = new frmSignin4RealGuys();
      Program.applicationContext.MainForm.Show();
      this.Close();
    }

    private void frmMain_Load(object sender, EventArgs e)
    {

    }
  }
}

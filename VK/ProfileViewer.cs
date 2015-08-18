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
using System.Collections.Specialized;
using System.IO;
using System.Xml;
using System.Net;

namespace VK
{
  public partial class ProfileViewer : UserControl
  {
    #region Перечисления
    public enum ViewMode
    {
      /// <summary>
      /// больше
      /// </summary>
      expand,
      /// <summary>
      /// меньше
      /// </summary>
      collapse
    }
    #endregion
    #region Пользовательские события
    
    public event EventHandler ModeChange;
    public delegate void ProfileLoadedHandler(ProfileViewer sender, string name);
    public event ProfileLoadedHandler ProfileLoaded;

    #endregion
    #region Свойства
    private string accessToken = "";
    private int _UserId = -1;
    
    public int UserId
    {
      get { return _UserId; }
      set 
      { 
        _UserId = value;
        LoadProfile();
      }      
    }

    public ViewMode Mode
    {
      get { return btnMore.Text == "больше" ? ViewMode.expand : ViewMode.collapse; }
      set 
      {
        if (value == ViewMode.collapse)
        {
          this.Height = 87;
          btnMore.Text = "больше";
        }
        else
        {
          this.Height = 180;
          btnMore.Text = "меньше";
        }
        EventHandler handler = ModeChange;
        if (handler != null) { handler(this, null); }
      }
    }

    public bool AllowMoreButton
    {
      get { return btnMore.Visible; }
      set
      {
        btnMore.Visible = value;
      }
    }
    #endregion
    #region Конструктор
    public ProfileViewer()
    {
      InitializeComponent();
    }
    public ProfileViewer(int userId)
    {
      InitializeComponent();
      this.UserId = userId;
    }
    public ProfileViewer(XmlNode n)
    {
      InitializeComponent();
      BindProfile(n);
    }
    #endregion

    private void ProfileViewer_Load(object sender, EventArgs e)
    {
    }

    private void LoadProfile()
    {
      if (this.UserId == -1) { return; }
      VKAPI myVK = new VKAPI(this.UserId, accessToken);
      XmlDocument profile = myVK.GetProfile();
      if (profile == null) { return; }
      BindProfile(profile.SelectSingleNode("response/user"));
    }

    private void BindProfile(XmlNode n)
    {
      if (n == null) { return; }
      try
      {
        if (n.SelectSingleNode("photo") != null && !String.IsNullOrEmpty(n.SelectSingleNode("photo").InnerText))
        {
          picPhoto.Image = Image.FromStream(new MemoryStream(new WebClient().DownloadData(n.SelectSingleNode("photo").InnerText)));
        }
        _UserId = Helper.GetDataFromXmlNodeAsInt(n.SelectSingleNode("uid"));
        lblUserID.Text = Helper.GetDataFromXmlNode(n.SelectSingleNode("uid"));
        lblFirstName.Text = Helper.GetDataFromXmlNode(n.SelectSingleNode("first_name"));
        lblLastName.Text = Helper.GetDataFromXmlNode(n.SelectSingleNode("last_name"));
        lblNickname.Text = Helper.GetDataFromXmlNode(n.SelectSingleNode("nickname"));
        switch (Helper.GetDataFromXmlNode(n.SelectSingleNode("sex")))
        {
          case "1":
            lblSex.Text = "женский";
            break;
          case "2":
            lblSex.Text = "мужской";
            break;
          default:
            lblSex.Text = "паркетный";
            break;
        }
        lblBirthday.Text = Helper.GetDataFromXmlNode(n.SelectSingleNode("bdate"));

        VKAPI myVK = new VKAPI(this.UserId, accessToken);
        // лучше сделать локальную базу стран и городов
        lblCity.Text = Helper.GetDataFromXmlNode(n.SelectSingleNode("city")); // myVK.GetCity(Helper.GetDataFromXmlNodeAsInt(n.SelectSingleNode("city")));
        lblCountry.Text = Helper.GetDataFromXmlNode(n.SelectSingleNode("country")); //myVK.GetCountry(Helper.GetDataFromXmlNodeAsInt(n.SelectSingleNode("country")));

        // инициируем событие ProfileLoaded
        if (ProfileLoaded != null) { ProfileLoaded(this, String.Format("{0} {1} (ID: {2})", lblFirstName.Text, lblLastName.Text, _UserId)); }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error. " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void btnMore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      if (btnMore.Text == "меньше")
      {
        this.Mode = ViewMode.collapse;
      }
      else
      {
        this.Mode = ViewMode.expand;
      }
    }

    private void btnShowProfile_Click(object sender, EventArgs e)
    {
      frmVkontakte frm = new frmVkontakte(this.UserId);
      frm.Owner = this.FindForm();
      frm.MdiParent = this.FindForm().MdiParent;
      frm.Show();
    }
  }
}

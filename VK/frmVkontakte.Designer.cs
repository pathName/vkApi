namespace VK
{
  partial class frmVkontakte
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.btnUpdateFriendList = new System.Windows.Forms.Button();
      this.tabPage4 = new System.Windows.Forms.TabPage();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.btnUpdateWall = new System.Windows.Forms.Button();
      this.tbWall = new System.Windows.Forms.TextBox();
      this.tbNewMessage = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnSendMessage = new System.Windows.Forms.Button();
      this.profileViewer1 = new VK.ProfileViewer();
      this.pcFriends = new VK.ProfileContainer();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.tabPage4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Controls.Add(this.tabPage4);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 0);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(518, 322);
      this.tabControl1.TabIndex = 0;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.profileViewer1);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(510, 296);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Профиль";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.pcFriends);
      this.tabPage2.Controls.Add(this.btnUpdateFriendList);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(510, 296);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Друзья";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // btnUpdateFriendList
      // 
      this.btnUpdateFriendList.Dock = System.Windows.Forms.DockStyle.Top;
      this.btnUpdateFriendList.Location = new System.Drawing.Point(3, 3);
      this.btnUpdateFriendList.Name = "btnUpdateFriendList";
      this.btnUpdateFriendList.Size = new System.Drawing.Size(504, 22);
      this.btnUpdateFriendList.TabIndex = 0;
      this.btnUpdateFriendList.Text = "Обновить";
      this.btnUpdateFriendList.UseVisualStyleBackColor = true;
      this.btnUpdateFriendList.Click += new System.EventHandler(this.btnUpdateFriendList_Click);
      // 
      // tabPage4
      // 
      this.tabPage4.Controls.Add(this.splitContainer1);
      this.tabPage4.Location = new System.Drawing.Point(4, 22);
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.Size = new System.Drawing.Size(510, 296);
      this.tabPage4.TabIndex = 3;
      this.tabPage4.Text = "Стена";
      this.tabPage4.UseVisualStyleBackColor = true;
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.btnUpdateWall);
      this.splitContainer1.Panel1.Controls.Add(this.tbWall);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.tbNewMessage);
      this.splitContainer1.Panel2.Controls.Add(this.label1);
      this.splitContainer1.Panel2.Controls.Add(this.btnSendMessage);
      this.splitContainer1.Size = new System.Drawing.Size(510, 296);
      this.splitContainer1.SplitterDistance = 178;
      this.splitContainer1.TabIndex = 0;
      // 
      // btnUpdateWall
      // 
      this.btnUpdateWall.Location = new System.Drawing.Point(8, 3);
      this.btnUpdateWall.Name = "btnUpdateWall";
      this.btnUpdateWall.Size = new System.Drawing.Size(82, 23);
      this.btnUpdateWall.TabIndex = 2;
      this.btnUpdateWall.Text = "Обновить";
      this.btnUpdateWall.UseVisualStyleBackColor = true;
      this.btnUpdateWall.Click += new System.EventHandler(this.btnUpdateWall_Click);
      // 
      // tbWall
      // 
      this.tbWall.Location = new System.Drawing.Point(8, 32);
      this.tbWall.Multiline = true;
      this.tbWall.Name = "tbWall";
      this.tbWall.ReadOnly = true;
      this.tbWall.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.tbWall.Size = new System.Drawing.Size(494, 139);
      this.tbWall.TabIndex = 0;
      // 
      // tbNewMessage
      // 
      this.tbNewMessage.Location = new System.Drawing.Point(8, 27);
      this.tbNewMessage.Multiline = true;
      this.tbNewMessage.Name = "tbNewMessage";
      this.tbNewMessage.Size = new System.Drawing.Size(494, 49);
      this.tbNewMessage.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(5, 11);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(118, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Разместить на стене:";
      // 
      // btnSendMessage
      // 
      this.btnSendMessage.Location = new System.Drawing.Point(8, 82);
      this.btnSendMessage.Name = "btnSendMessage";
      this.btnSendMessage.Size = new System.Drawing.Size(82, 23);
      this.btnSendMessage.TabIndex = 2;
      this.btnSendMessage.Text = "Отправить";
      this.btnSendMessage.UseVisualStyleBackColor = true;
      this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
      // 
      // profileViewer1
      // 
      this.profileViewer1.AllowMoreButton = false;
      this.profileViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.profileViewer1.Location = new System.Drawing.Point(3, 3);
      this.profileViewer1.Mode = VK.ProfileViewer.ViewMode.expand;
      this.profileViewer1.Name = "profileViewer1";
      this.profileViewer1.Size = new System.Drawing.Size(504, 290);
      this.profileViewer1.TabIndex = 0;
      this.profileViewer1.UserId = -1;
      this.profileViewer1.ProfileLoaded += new VK.ProfileViewer.ProfileLoadedHandler(this.profileViewer1_ProfileLoaded);
      // 
      // pcFriends
      // 
      this.pcFriends.AutoScroll = true;
      this.pcFriends.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pcFriends.Location = new System.Drawing.Point(3, 25);
      this.pcFriends.Name = "pcFriends";
      this.pcFriends.Size = new System.Drawing.Size(504, 268);
      this.pcFriends.TabIndex = 1;
      // 
      // frmVkontakte
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(518, 322);
      this.Controls.Add(this.tabControl1);
      this.Name = "frmVkontakte";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "ВКонтакте";
      this.Load += new System.EventHandler(this.frmVkontakte_Load);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      this.tabPage4.ResumeLayout(false);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TabPage tabPage4;
    private ProfileViewer profileViewer1;
    private System.Windows.Forms.Button btnUpdateFriendList;
    private ProfileContainer pcFriends;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.Button btnSendMessage;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox tbNewMessage;
    private System.Windows.Forms.Button btnUpdateWall;
    private System.Windows.Forms.TextBox tbWall;
  }
}
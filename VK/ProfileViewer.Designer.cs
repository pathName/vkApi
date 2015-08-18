namespace VK
{
  partial class ProfileViewer
  {
    /// <summary> 
    /// Требуется переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором компонентов

    /// <summary> 
    /// Обязательный метод для поддержки конструктора - не изменяйте 
    /// содержимое данного метода при помощи редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.label1 = new System.Windows.Forms.Label();
      this.lblFirstName = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.lblUserID = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.lblLastName = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.lblNickname = new System.Windows.Forms.Label();
      this.lblSex = new System.Windows.Forms.Label();
      this.lblBirthday = new System.Windows.Forms.Label();
      this.lblCountry = new System.Windows.Forms.Label();
      this.lblCity = new System.Windows.Forms.Label();
      this.picPhoto = new System.Windows.Forms.PictureBox();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.btnMore = new System.Windows.Forms.LinkLabel();
      this.btnShowProfile = new System.Windows.Forms.Button();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
      this.tableLayoutPanel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.lblFirstName, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.lblUserID, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.lblLastName, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.label2, 0, 5);
      this.tableLayoutPanel1.Controls.Add(this.label5, 0, 6);
      this.tableLayoutPanel1.Controls.Add(this.label6, 0, 8);
      this.tableLayoutPanel1.Controls.Add(this.label7, 0, 9);
      this.tableLayoutPanel1.Controls.Add(this.label8, 0, 3);
      this.tableLayoutPanel1.Controls.Add(this.lblNickname, 1, 3);
      this.tableLayoutPanel1.Controls.Add(this.lblSex, 1, 5);
      this.tableLayoutPanel1.Controls.Add(this.lblBirthday, 1, 6);
      this.tableLayoutPanel1.Controls.Add(this.lblCountry, 1, 8);
      this.tableLayoutPanel1.Controls.Add(this.lblCity, 1, 9);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(73, 3);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 11;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(269, 144);
      this.tableLayoutPanel1.TabIndex = 4;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(21, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "ID:";
      // 
      // lblFirstName
      // 
      this.lblFirstName.AutoSize = true;
      this.lblFirstName.Location = new System.Drawing.Point(98, 13);
      this.lblFirstName.Name = "lblFirstName";
      this.lblFirstName.Size = new System.Drawing.Size(16, 13);
      this.lblFirstName.TabIndex = 1;
      this.lblFirstName.Text = "---";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(3, 13);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(32, 13);
      this.label3.TabIndex = 1;
      this.label3.Text = "Имя:";
      // 
      // lblUserID
      // 
      this.lblUserID.AutoSize = true;
      this.lblUserID.Location = new System.Drawing.Point(98, 0);
      this.lblUserID.Name = "lblUserID";
      this.lblUserID.Size = new System.Drawing.Size(13, 13);
      this.lblUserID.TabIndex = 1;
      this.lblUserID.Text = "0";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(3, 26);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(59, 13);
      this.label4.TabIndex = 1;
      this.label4.Text = "Фамилия:";
      // 
      // lblLastName
      // 
      this.lblLastName.AutoSize = true;
      this.lblLastName.Location = new System.Drawing.Point(98, 26);
      this.lblLastName.Name = "lblLastName";
      this.lblLastName.Size = new System.Drawing.Size(16, 13);
      this.lblLastName.TabIndex = 1;
      this.lblLastName.Text = "---";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(3, 72);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(30, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Пол:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(3, 85);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(89, 13);
      this.label5.TabIndex = 1;
      this.label5.Text = "Дата рождения:";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(3, 118);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(46, 13);
      this.label6.TabIndex = 1;
      this.label6.Text = "Страна:";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(3, 131);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(40, 13);
      this.label7.TabIndex = 1;
      this.label7.Text = "Город:";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(3, 39);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(68, 13);
      this.label8.TabIndex = 1;
      this.label8.Text = "Псевдоним:";
      // 
      // lblNickname
      // 
      this.lblNickname.AutoSize = true;
      this.lblNickname.Location = new System.Drawing.Point(98, 39);
      this.lblNickname.Name = "lblNickname";
      this.lblNickname.Size = new System.Drawing.Size(16, 13);
      this.lblNickname.TabIndex = 1;
      this.lblNickname.Text = "---";
      // 
      // lblSex
      // 
      this.lblSex.AutoSize = true;
      this.lblSex.Location = new System.Drawing.Point(98, 72);
      this.lblSex.Name = "lblSex";
      this.lblSex.Size = new System.Drawing.Size(16, 13);
      this.lblSex.TabIndex = 1;
      this.lblSex.Text = "---";
      // 
      // lblBirthday
      // 
      this.lblBirthday.AutoSize = true;
      this.lblBirthday.Location = new System.Drawing.Point(98, 85);
      this.lblBirthday.Name = "lblBirthday";
      this.lblBirthday.Size = new System.Drawing.Size(16, 13);
      this.lblBirthday.TabIndex = 1;
      this.lblBirthday.Text = "---";
      // 
      // lblCountry
      // 
      this.lblCountry.AutoSize = true;
      this.lblCountry.Location = new System.Drawing.Point(98, 118);
      this.lblCountry.Name = "lblCountry";
      this.lblCountry.Size = new System.Drawing.Size(16, 13);
      this.lblCountry.TabIndex = 1;
      this.lblCountry.Text = "---";
      // 
      // lblCity
      // 
      this.lblCity.AutoSize = true;
      this.lblCity.Location = new System.Drawing.Point(98, 131);
      this.lblCity.Name = "lblCity";
      this.lblCity.Size = new System.Drawing.Size(16, 13);
      this.lblCity.TabIndex = 1;
      this.lblCity.Text = "---";
      // 
      // picPhoto
      // 
      this.picPhoto.Dock = System.Windows.Forms.DockStyle.Top;
      this.picPhoto.Location = new System.Drawing.Point(3, 3);
      this.picPhoto.Name = "picPhoto";
      this.picPhoto.Size = new System.Drawing.Size(64, 100);
      this.picPhoto.TabIndex = 3;
      this.picPhoto.TabStop = false;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 2;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Controls.Add(this.picPhoto, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 1, 0);
      this.tableLayoutPanel2.Controls.Add(this.btnMore, 1, 1);
      this.tableLayoutPanel2.Controls.Add(this.btnShowProfile, 0, 1);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 2;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(345, 180);
      this.tableLayoutPanel2.TabIndex = 5;
      // 
      // btnMore
      // 
      this.btnMore.AutoSize = true;
      this.btnMore.Location = new System.Drawing.Point(73, 150);
      this.btnMore.Name = "btnMore";
      this.btnMore.Size = new System.Drawing.Size(47, 13);
      this.btnMore.TabIndex = 5;
      this.btnMore.TabStop = true;
      this.btnMore.Text = "меньше";
      this.btnMore.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnMore_LinkClicked);
      // 
      // btnShowProfile
      // 
      this.btnShowProfile.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnShowProfile.Location = new System.Drawing.Point(3, 153);
      this.btnShowProfile.Name = "btnShowProfile";
      this.btnShowProfile.Size = new System.Drawing.Size(64, 24);
      this.btnShowProfile.TabIndex = 6;
      this.btnShowProfile.Text = "детали";
      this.btnShowProfile.UseVisualStyleBackColor = true;
      this.btnShowProfile.Click += new System.EventHandler(this.btnShowProfile_Click);
      // 
      // ProfileViewer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tableLayoutPanel2);
      this.Name = "ProfileViewer";
      this.Size = new System.Drawing.Size(345, 180);
      this.Load += new System.EventHandler(this.ProfileViewer_Load);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lblFirstName;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label lblUserID;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label lblLastName;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label lblNickname;
    private System.Windows.Forms.Label lblSex;
    private System.Windows.Forms.Label lblBirthday;
    private System.Windows.Forms.Label lblCountry;
    private System.Windows.Forms.Label lblCity;
    private System.Windows.Forms.PictureBox picPhoto;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.LinkLabel btnMore;
    private System.Windows.Forms.Button btnShowProfile;
  }
}

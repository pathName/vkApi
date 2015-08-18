namespace VK
{
  partial class frmSignin4RealGuys
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

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Обязательный метод для поддержки конструктора - не изменяйте
    /// содержимое данного метода при помощи редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.tbLogin = new System.Windows.Forms.TextBox();
      this.tbPassword = new System.Windows.Forms.TextBox();
      this.btnSignin = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 18);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(39, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "E-Mail:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 43);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(48, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Пароль:";
      // 
      // tbLogin
      // 
      this.tbLogin.Location = new System.Drawing.Point(69, 15);
      this.tbLogin.Name = "tbLogin";
      this.tbLogin.Size = new System.Drawing.Size(143, 20);
      this.tbLogin.TabIndex = 0;
      // 
      // tbPassword
      // 
      this.tbPassword.Location = new System.Drawing.Point(69, 41);
      this.tbPassword.Name = "tbPassword";
      this.tbPassword.PasswordChar = '*';
      this.tbPassword.Size = new System.Drawing.Size(143, 20);
      this.tbPassword.TabIndex = 1;
      // 
      // btnSignin
      // 
      this.btnSignin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnSignin.Location = new System.Drawing.Point(137, 67);
      this.btnSignin.Name = "btnSignin";
      this.btnSignin.Size = new System.Drawing.Size(75, 23);
      this.btnSignin.TabIndex = 2;
      this.btnSignin.Text = "Вход";
      this.btnSignin.UseVisualStyleBackColor = true;
      this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(15, 67);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 3;
      this.btnCancel.Text = "Отмена";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // frmSignin4RealGuys
      // 
      this.AcceptButton = this.btnSignin;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(225, 100);
      this.ControlBox = false;
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnSignin);
      this.Controls.Add(this.tbPassword);
      this.Controls.Add(this.tbLogin);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmSignin4RealGuys";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Вход ВКонтакте";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox tbLogin;
    private System.Windows.Forms.TextBox tbPassword;
    private System.Windows.Forms.Button btnSignin;
    private System.Windows.Forms.Button btnCancel;
  }
}


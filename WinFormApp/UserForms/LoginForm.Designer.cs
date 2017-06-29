namespace WinFormApp.UserForms
{
    partial class LoginForm : DevExpress.XtraEditors.XtraForm
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
            this.components = new System.ComponentModel.Container();
            this.TxtUserName = new CCWin.SkinControl.SkinWaterTextBox();
            this.TxtPassword = new CCWin.SkinControl.SkinWaterTextBox();
            this.BtnLogin = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // TxtUserName
            // 
            this.TxtUserName.Font = new System.Drawing.Font("Tahoma", 14F);
            this.TxtUserName.Location = new System.Drawing.Point(179, 80);
            this.TxtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(206, 30);
            this.TxtUserName.TabIndex = 0;
            this.TxtUserName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.TxtUserName.WaterText = "请输入用户名";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Tahoma", 14F);
            this.TxtPassword.Location = new System.Drawing.Point(179, 152);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(206, 30);
            this.TxtPassword.TabIndex = 1;
            this.TxtPassword.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.TxtPassword.WaterText = "请输入密码";
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogin.BaseColor = System.Drawing.Color.Silver;
            this.BtnLogin.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BtnLogin.DownBack = null;
            this.BtnLogin.Location = new System.Drawing.Point(224, 231);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnLogin.MouseBack = null;
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.NormlBack = null;
            this.BtnLogin.Radius = 16;
            this.BtnLogin.Size = new System.Drawing.Size(117, 30);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "登 录";
            this.BtnLogin.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 337);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUserName);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.ShowMdiChildCaptionInParentTitle = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinWaterTextBox TxtUserName;
        private CCWin.SkinControl.SkinWaterTextBox TxtPassword;
        private CCWin.SkinControl.SkinButton BtnLogin;
    }
}

namespace PreLab1
{
    partial class LoginScreen
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
            this.BtnLogin = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lbl_error = new System.Windows.Forms.Label();
            this.lbl_error2 = new System.Windows.Forms.Label();
            this.btnSıgnIn = new System.Windows.Forms.Button();
            this.chk_Password = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.Enabled = false;
            this.BtnLogin.Location = new System.Drawing.Point(199, 242);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(157, 39);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Log In";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.AcceptsTab = true;
            this.txtUserName.Location = new System.Drawing.Point(199, 135);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(157, 22);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(199, 185);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(157, 22);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(56, 140);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(126, 17);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "User/Admin Name:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(109, 190);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 17);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password:";
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Location = new System.Drawing.Point(234, 366);
            this.lbl_error.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 17);
            this.lbl_error.TabIndex = 5;
            // 
            // lbl_error2
            // 
            this.lbl_error2.AutoSize = true;
            this.lbl_error2.Location = new System.Drawing.Point(149, 385);
            this.lbl_error2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_error2.Name = "lbl_error2";
            this.lbl_error2.Size = new System.Drawing.Size(0, 17);
            this.lbl_error2.TabIndex = 6;
            // 
            // btnSıgnIn
            // 
            this.btnSıgnIn.Enabled = false;
            this.btnSıgnIn.Location = new System.Drawing.Point(199, 300);
            this.btnSıgnIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSıgnIn.Name = "btnSıgnIn";
            this.btnSıgnIn.Size = new System.Drawing.Size(157, 39);
            this.btnSıgnIn.TabIndex = 7;
            this.btnSıgnIn.Text = "Sıgn In";
            this.btnSıgnIn.UseVisualStyleBackColor = true;
            // 
            // chk_Password
            // 
            this.chk_Password.AutoSize = true;
            this.chk_Password.Location = new System.Drawing.Point(381, 189);
            this.chk_Password.Name = "chk_Password";
            this.chk_Password.Size = new System.Drawing.Size(129, 21);
            this.chk_Password.TabIndex = 8;
            this.chk_Password.Text = "Show Password";
            this.chk_Password.UseVisualStyleBackColor = true;
            this.chk_Password.CheckedChanged += new System.EventHandler(this.chk_Password_CheckedChanged);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.chk_Password);
            this.Controls.Add(this.btnSıgnIn);
            this.Controls.Add(this.lbl_error2);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.BtnLogin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log-in Screen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginScreen_FormClosed);
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Label lbl_error2;
        private System.Windows.Forms.Button btnSıgnIn;
        private System.Windows.Forms.CheckBox chk_Password;
    }
}


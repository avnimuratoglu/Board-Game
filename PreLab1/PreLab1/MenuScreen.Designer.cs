
namespace PreLab1
{
    partial class MenuScreen
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
            this.Btn_Logout = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.Btn_Play = new System.Windows.Forms.Button();
            this.lbl_Menu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Logout
            // 
            this.Btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Logout.Location = new System.Drawing.Point(211, 330);
            this.Btn_Logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Logout.Name = "Btn_Logout";
            this.Btn_Logout.Size = new System.Drawing.Size(189, 50);
            this.Btn_Logout.TabIndex = 3;
            this.Btn_Logout.Text = "LOG OUT";
            this.Btn_Logout.UseVisualStyleBackColor = true;
            this.Btn_Logout.Click += new System.EventHandler(this.Btn_Logout_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Exit.Location = new System.Drawing.Point(211, 416);
            this.Btn_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(189, 50);
            this.Btn_Exit.TabIndex = 4;
            this.Btn_Exit.Text = "EXIT";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSettings.Location = new System.Drawing.Point(211, 244);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(189, 50);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "SETTINGS";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // Btn_Play
            // 
            this.Btn_Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Play.Location = new System.Drawing.Point(211, 158);
            this.Btn_Play.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Play.Name = "Btn_Play";
            this.Btn_Play.Size = new System.Drawing.Size(189, 50);
            this.Btn_Play.TabIndex = 1;
            this.Btn_Play.Text = "PLAY";
            this.Btn_Play.UseVisualStyleBackColor = true;
            this.Btn_Play.Click += new System.EventHandler(this.Btn_Play_Click);
            // 
            // lbl_Menu
            // 
            this.lbl_Menu.AutoSize = true;
            this.lbl_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Menu.Location = new System.Drawing.Point(191, 84);
            this.lbl_Menu.Name = "lbl_Menu";
            this.lbl_Menu.Size = new System.Drawing.Size(229, 38);
            this.lbl_Menu.TabIndex = 6;
            this.lbl_Menu.Text = "GAME MENU";
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 529);
            this.Controls.Add(this.lbl_Menu);
            this.Controls.Add(this.Btn_Play);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_Logout);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Screen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuScreen_FormClosed);
            this.Load += new System.EventHandler(this.MenuScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Logout;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button Btn_Play;
        private System.Windows.Forms.Label lbl_Menu;
    }
}
﻿
namespace PreLab1
{
    partial class HelpScreen
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
            this.lbl_info = new System.Windows.Forms.Label();
            this.btn_About = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_info.Location = new System.Drawing.Point(61, 169);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(688, 124);
            this.lbl_info.TabIndex = 0;
            this.lbl_info.Text = "- Oyunda kolay, orta, zor ve custom olmak üzere 3 zorluk derecesi bulunmaktadır.\r" +
    "\n- Oyunda 3 renk ve 3 sekil secenegi bulunmaktadır.\r\n- Aynı sekil ve rengi yan y" +
    "ana getirerek puan toplanmaktadır.\r\n\r\n";
            // 
            // btn_About
            // 
            this.btn_About.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_About.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_About.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_About.Location = new System.Drawing.Point(655, 379);
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(133, 47);
            this.btn_About.TabIndex = 1;
            this.btn_About.Text = "About Us";
            this.btn_About.UseVisualStyleBackColor = false;
            this.btn_About.Click += new System.EventHandler(this.btn_About_Click);
            // 
            // HelpScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_About);
            this.Controls.Add(this.lbl_info);
            this.Name = "HelpScreen";
            this.Text = "HelpScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Button btn_About;
    }
}
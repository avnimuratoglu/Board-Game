﻿
namespace PreLab1
{
    partial class GameScreen
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
            this.lblScoreTag = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.lbl_maxScoreInfo = new System.Windows.Forms.Label();
            this.lbl_maxScore = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblScoreTag
            // 
            this.lblScoreTag.AutoSize = true;
            this.lblScoreTag.Font = new System.Drawing.Font("Papyrus", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreTag.Location = new System.Drawing.Point(38, 175);
            this.lblScoreTag.Name = "lblScoreTag";
            this.lblScoreTag.Size = new System.Drawing.Size(88, 24);
            this.lblScoreTag.TabIndex = 0;
            this.lblScoreTag.Text = "SCORE";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel.Controls.Add(this.lbl_maxScoreInfo);
            this.panel.Controls.Add(this.lbl_maxScore);
            this.panel.Controls.Add(this.lblScore);
            this.panel.Controls.Add(this.lblScoreTag);
            this.panel.Font = new System.Drawing.Font("Papyrus", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.panel.Location = new System.Drawing.Point(473, 33);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(163, 358);
            this.panel.TabIndex = 2;
            // 
            // lbl_maxScoreInfo
            // 
            this.lbl_maxScoreInfo.AutoSize = true;
            this.lbl_maxScoreInfo.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_maxScoreInfo.Location = new System.Drawing.Point(79, 77);
            this.lbl_maxScoreInfo.Name = "lbl_maxScoreInfo";
            this.lbl_maxScoreInfo.Size = new System.Drawing.Size(0, 24);
            this.lbl_maxScoreInfo.TabIndex = 3;
            // 
            // lbl_maxScore
            // 
            this.lbl_maxScore.AutoSize = true;
            this.lbl_maxScore.Font = new System.Drawing.Font("Papyrus", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maxScore.Location = new System.Drawing.Point(14, 39);
            this.lbl_maxScore.Name = "lbl_maxScore";
            this.lbl_maxScore.Size = new System.Drawing.Size(137, 24);
            this.lbl_maxScore.TabIndex = 2;
            this.lbl_maxScore.Text = "MAX SCORE";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblScore.Location = new System.Drawing.Point(69, 225);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 24);
            this.lblScore.TabIndex = 1;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(659, 553);
            this.Controls.Add(this.panel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Screen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameScreen_FormClosed);
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblScoreTag;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lbl_maxScore;
        private System.Windows.Forms.Label lbl_maxScoreInfo;
    }
}
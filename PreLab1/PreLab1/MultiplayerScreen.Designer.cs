
namespace PreLab1
{
    partial class MultiplayerScreen
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
            this.panel = new System.Windows.Forms.Panel();
            this.lbl_Info = new System.Windows.Forms.Label();
            this.lbl_maxScoreInfo = new System.Windows.Forms.Label();
            this.lbl_maxScore = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScoreTag = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lbl_Info);
            this.panel.Controls.Add(this.lbl_maxScoreInfo);
            this.panel.Controls.Add(this.lbl_maxScore);
            this.panel.Controls.Add(this.lblScore);
            this.panel.Controls.Add(this.lblScoreTag);
            this.panel.Font = new System.Drawing.Font("Bell MT", 8.25F);
            this.panel.Location = new System.Drawing.Point(620, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(216, 521);
            this.panel.TabIndex = 3;
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoSize = true;
            this.lbl_Info.Font = new System.Drawing.Font("Papyrus", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Info.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Info.Location = new System.Drawing.Point(66, 62);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(0, 22);
            this.lbl_Info.TabIndex = 4;
            // 
            // lbl_maxScoreInfo
            // 
            this.lbl_maxScoreInfo.AutoSize = true;
            this.lbl_maxScoreInfo.Font = new System.Drawing.Font("Papyrus", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maxScoreInfo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_maxScoreInfo.Location = new System.Drawing.Point(98, 204);
            this.lbl_maxScoreInfo.Name = "lbl_maxScoreInfo";
            this.lbl_maxScoreInfo.Size = new System.Drawing.Size(0, 24);
            this.lbl_maxScoreInfo.TabIndex = 3;
            // 
            // lbl_maxScore
            // 
            this.lbl_maxScore.AutoSize = true;
            this.lbl_maxScore.Font = new System.Drawing.Font("Papyrus", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maxScore.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_maxScore.Location = new System.Drawing.Point(47, 141);
            this.lbl_maxScore.Name = "lbl_maxScore";
            this.lbl_maxScore.Size = new System.Drawing.Size(137, 24);
            this.lbl_maxScore.TabIndex = 2;
            this.lbl_maxScore.Text = "MAX SCORE";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Papyrus", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblScore.Location = new System.Drawing.Point(98, 352);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 24);
            this.lblScore.TabIndex = 1;
            // 
            // lblScoreTag
            // 
            this.lblScoreTag.AutoSize = true;
            this.lblScoreTag.Font = new System.Drawing.Font("Papyrus", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreTag.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblScoreTag.Location = new System.Drawing.Point(74, 303);
            this.lblScoreTag.Name = "lblScoreTag";
            this.lblScoreTag.Size = new System.Drawing.Size(88, 24);
            this.lblScoreTag.TabIndex = 0;
            this.lblScoreTag.Text = "SCORE";
            // 
            // MultiplayerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(848, 545);
            this.Controls.Add(this.panel);
            this.Name = "MultiplayerScreen";
            this.Text = "MultiplayerScreen";
            this.Load += new System.EventHandler(this.MultiplayerScreen_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lbl_maxScoreInfo;
        private System.Windows.Forms.Label lbl_maxScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScoreTag;
        private System.Windows.Forms.Label lbl_Info;
    }
}
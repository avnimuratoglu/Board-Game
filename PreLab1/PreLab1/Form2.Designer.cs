﻿
namespace PreLab1
{
    partial class SettingScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.rBtn_Easy = new System.Windows.Forms.RadioButton();
            this.rBtn_Normal = new System.Windows.Forms.RadioButton();
            this.rBtn_Hard = new System.Windows.Forms.RadioButton();
            this.rBtn_Custom = new System.Windows.Forms.RadioButton();
            this.gBx_Difficulty = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBx_Round = new System.Windows.Forms.CheckBox();
            this.cBx_Square = new System.Windows.Forms.CheckBox();
            this.cBx_Triangle = new System.Windows.Forms.CheckBox();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.gBx_Difficulty.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(172, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "SETTINGS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rBtn_Easy
            // 
            this.rBtn_Easy.AutoSize = true;
            this.rBtn_Easy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rBtn_Easy.Location = new System.Drawing.Point(56, 36);
            this.rBtn_Easy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rBtn_Easy.Name = "rBtn_Easy";
            this.rBtn_Easy.Size = new System.Drawing.Size(61, 21);
            this.rBtn_Easy.TabIndex = 1;
            this.rBtn_Easy.Text = "Easy";
            this.rBtn_Easy.UseVisualStyleBackColor = true;
            // 
            // rBtn_Normal
            // 
            this.rBtn_Normal.AutoSize = true;
            this.rBtn_Normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rBtn_Normal.Location = new System.Drawing.Point(152, 36);
            this.rBtn_Normal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rBtn_Normal.Name = "rBtn_Normal";
            this.rBtn_Normal.Size = new System.Drawing.Size(77, 21);
            this.rBtn_Normal.TabIndex = 2;
            this.rBtn_Normal.Text = "Normal";
            this.rBtn_Normal.UseVisualStyleBackColor = true;
            this.rBtn_Normal.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rBtn_Hard
            // 
            this.rBtn_Hard.AutoSize = true;
            this.rBtn_Hard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rBtn_Hard.Location = new System.Drawing.Point(250, 36);
            this.rBtn_Hard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rBtn_Hard.Name = "rBtn_Hard";
            this.rBtn_Hard.Size = new System.Drawing.Size(61, 21);
            this.rBtn_Hard.TabIndex = 3;
            this.rBtn_Hard.Text = "Hard";
            this.rBtn_Hard.UseVisualStyleBackColor = true;
            // 
            // rBtn_Custom
            // 
            this.rBtn_Custom.AutoSize = true;
            this.rBtn_Custom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rBtn_Custom.Location = new System.Drawing.Point(341, 36);
            this.rBtn_Custom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rBtn_Custom.Name = "rBtn_Custom";
            this.rBtn_Custom.Size = new System.Drawing.Size(79, 21);
            this.rBtn_Custom.TabIndex = 4;
            this.rBtn_Custom.Text = "Custom";
            this.rBtn_Custom.UseVisualStyleBackColor = true;
            this.rBtn_Custom.CheckedChanged += new System.EventHandler(this.rBtn_Custom_CheckedChanged);
            // 
            // gBx_Difficulty
            // 
            this.gBx_Difficulty.Controls.Add(this.rBtn_Normal);
            this.gBx_Difficulty.Controls.Add(this.rBtn_Custom);
            this.gBx_Difficulty.Controls.Add(this.rBtn_Easy);
            this.gBx_Difficulty.Controls.Add(this.rBtn_Hard);
            this.gBx_Difficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gBx_Difficulty.Location = new System.Drawing.Point(9, 72);
            this.gBx_Difficulty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gBx_Difficulty.Name = "gBx_Difficulty";
            this.gBx_Difficulty.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gBx_Difficulty.Size = new System.Drawing.Size(460, 72);
            this.gBx_Difficulty.TabIndex = 1;
            this.gBx_Difficulty.TabStop = false;
            this.gBx_Difficulty.Text = "Difficulty";
            this.gBx_Difficulty.Enter += new System.EventHandler(this.gBx_Difficulty_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBx_Round);
            this.groupBox1.Controls.Add(this.cBx_Square);
            this.groupBox1.Controls.Add(this.cBx_Triangle);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(9, 235);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(460, 72);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shape";
            // 
            // cBx_Round
            // 
            this.cBx_Round.AutoSize = true;
            this.cBx_Round.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBx_Round.Location = new System.Drawing.Point(249, 36);
            this.cBx_Round.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBx_Round.Name = "cBx_Round";
            this.cBx_Round.Size = new System.Drawing.Size(74, 21);
            this.cBx_Round.TabIndex = 7;
            this.cBx_Round.Text = "Round";
            this.cBx_Round.UseVisualStyleBackColor = true;
            // 
            // cBx_Square
            // 
            this.cBx_Square.AutoSize = true;
            this.cBx_Square.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBx_Square.Location = new System.Drawing.Point(56, 36);
            this.cBx_Square.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBx_Square.Name = "cBx_Square";
            this.cBx_Square.Size = new System.Drawing.Size(79, 21);
            this.cBx_Square.TabIndex = 5;
            this.cBx_Square.Text = "Square";
            this.cBx_Square.UseVisualStyleBackColor = true;
            // 
            // cBx_Triangle
            // 
            this.cBx_Triangle.AutoSize = true;
            this.cBx_Triangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBx_Triangle.Location = new System.Drawing.Point(151, 36);
            this.cBx_Triangle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBx_Triangle.Name = "cBx_Triangle";
            this.cBx_Triangle.Size = new System.Drawing.Size(87, 21);
            this.cBx_Triangle.TabIndex = 6;
            this.cBx_Triangle.Text = "Triangle";
            this.cBx_Triangle.UseVisualStyleBackColor = true;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Save.Location = new System.Drawing.Point(326, 362);
            this.Btn_Save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(142, 44);
            this.Btn_Save.TabIndex = 8;
            this.Btn_Save.Text = "SAVE";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(430, 149);
            this.txtNum1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(30, 20);
            this.txtNum1.TabIndex = 9;
            this.txtNum1.Visible = false;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(430, 171);
            this.txtNum2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(30, 20);
            this.txtNum2.TabIndex = 10;
            this.txtNum2.Visible = false;
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(341, 151);
            this.lblNum1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(84, 13);
            this.lblNum1.TabIndex = 12;
            this.lblNum1.Text = "Enter Number 1:";
            this.lblNum1.Visible = false;
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(341, 174);
            this.lblNum2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(84, 13);
            this.lblNum2.TabIndex = 13;
            this.lblNum2.Text = "Enter Number 2:";
            this.lblNum2.Visible = false;
            // 
            // SettingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 430);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gBx_Difficulty);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SettingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting Screen";
            this.gBx_Difficulty.ResumeLayout(false);
            this.gBx_Difficulty.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rBtn_Easy;
        private System.Windows.Forms.RadioButton rBtn_Normal;
        private System.Windows.Forms.RadioButton rBtn_Hard;
        private System.Windows.Forms.RadioButton rBtn_Custom;
        private System.Windows.Forms.GroupBox gBx_Difficulty;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cBx_Round;
        private System.Windows.Forms.CheckBox cBx_Square;
        private System.Windows.Forms.CheckBox cBx_Triangle;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
    }
}
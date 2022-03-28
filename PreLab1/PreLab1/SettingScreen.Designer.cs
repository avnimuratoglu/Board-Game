
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
            this.lbl_CustomErrorNum1 = new System.Windows.Forms.Label();
            this.lbl_CustomErrorNum2 = new System.Windows.Forms.Label();
            this.checkBoxY = new System.Windows.Forms.CheckBox();
            this.checkBoxB = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gBx_Difficulty.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(229, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "SETTINGS";
            // 
            // rBtn_Easy
            // 
            this.rBtn_Easy.AutoSize = true;
            this.rBtn_Easy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rBtn_Easy.Location = new System.Drawing.Point(75, 44);
            this.rBtn_Easy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBtn_Easy.Name = "rBtn_Easy";
            this.rBtn_Easy.Size = new System.Drawing.Size(71, 24);
            this.rBtn_Easy.TabIndex = 1;
            this.rBtn_Easy.Text = "Easy";
            this.rBtn_Easy.UseVisualStyleBackColor = true;
            // 
            // rBtn_Normal
            // 
            this.rBtn_Normal.AutoSize = true;
            this.rBtn_Normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rBtn_Normal.Location = new System.Drawing.Point(203, 44);
            this.rBtn_Normal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBtn_Normal.Name = "rBtn_Normal";
            this.rBtn_Normal.Size = new System.Drawing.Size(90, 24);
            this.rBtn_Normal.TabIndex = 2;
            this.rBtn_Normal.Text = "Normal";
            this.rBtn_Normal.UseVisualStyleBackColor = true;
            // 
            // rBtn_Hard
            // 
            this.rBtn_Hard.AutoSize = true;
            this.rBtn_Hard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rBtn_Hard.Location = new System.Drawing.Point(333, 44);
            this.rBtn_Hard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBtn_Hard.Name = "rBtn_Hard";
            this.rBtn_Hard.Size = new System.Drawing.Size(71, 24);
            this.rBtn_Hard.TabIndex = 3;
            this.rBtn_Hard.Text = "Hard";
            this.rBtn_Hard.UseVisualStyleBackColor = true;
            // 
            // rBtn_Custom
            // 
            this.rBtn_Custom.AutoSize = true;
            this.rBtn_Custom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rBtn_Custom.Location = new System.Drawing.Point(455, 44);
            this.rBtn_Custom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBtn_Custom.Name = "rBtn_Custom";
            this.rBtn_Custom.Size = new System.Drawing.Size(94, 24);
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
            this.gBx_Difficulty.Location = new System.Drawing.Point(12, 89);
            this.gBx_Difficulty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBx_Difficulty.Name = "gBx_Difficulty";
            this.gBx_Difficulty.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBx_Difficulty.Size = new System.Drawing.Size(613, 89);
            this.gBx_Difficulty.TabIndex = 1;
            this.gBx_Difficulty.TabStop = false;
            this.gBx_Difficulty.Text = "Difficulty";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBx_Round);
            this.groupBox1.Controls.Add(this.cBx_Square);
            this.groupBox1.Controls.Add(this.cBx_Triangle);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(11, 238);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(613, 81);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shape";
            // 
            // cBx_Round
            // 
            this.cBx_Round.AutoSize = true;
            this.cBx_Round.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBx_Round.Location = new System.Drawing.Point(332, 44);
            this.cBx_Round.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBx_Round.Name = "cBx_Round";
            this.cBx_Round.Size = new System.Drawing.Size(84, 24);
            this.cBx_Round.TabIndex = 9;
            this.cBx_Round.Text = "Round";
            this.cBx_Round.UseVisualStyleBackColor = true;
            // 
            // cBx_Square
            // 
            this.cBx_Square.AutoSize = true;
            this.cBx_Square.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBx_Square.Location = new System.Drawing.Point(75, 44);
            this.cBx_Square.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBx_Square.Name = "cBx_Square";
            this.cBx_Square.Size = new System.Drawing.Size(90, 24);
            this.cBx_Square.TabIndex = 7;
            this.cBx_Square.Text = "Square";
            this.cBx_Square.UseVisualStyleBackColor = true;
            // 
            // cBx_Triangle
            // 
            this.cBx_Triangle.AutoSize = true;
            this.cBx_Triangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBx_Triangle.Location = new System.Drawing.Point(201, 44);
            this.cBx_Triangle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBx_Triangle.Name = "cBx_Triangle";
            this.cBx_Triangle.Size = new System.Drawing.Size(99, 24);
            this.cBx_Triangle.TabIndex = 8;
            this.cBx_Triangle.Text = "Triangle";
            this.cBx_Triangle.UseVisualStyleBackColor = true;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Save.Location = new System.Drawing.Point(435, 446);
            this.Btn_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(189, 54);
            this.Btn_Save.TabIndex = 10;
            this.Btn_Save.Text = "SAVE";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(573, 183);
            this.txtNum1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(39, 22);
            this.txtNum1.TabIndex = 5;
            this.txtNum1.Visible = false;
            this.txtNum1.TextChanged += new System.EventHandler(this.txtNum1_TextChanged);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(573, 212);
            this.txtNum2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(39, 22);
            this.txtNum2.TabIndex = 6;
            this.txtNum2.Visible = false;
            this.txtNum2.TextChanged += new System.EventHandler(this.txtNum2_TextChanged);
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(455, 188);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(112, 17);
            this.lblNum1.TabIndex = 12;
            this.lblNum1.Text = "Enter Number 1:";
            this.lblNum1.Visible = false;
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(455, 216);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(112, 17);
            this.lblNum2.TabIndex = 13;
            this.lblNum2.Text = "Enter Number 2:";
            this.lblNum2.Visible = false;
            // 
            // lbl_CustomErrorNum1
            // 
            this.lbl_CustomErrorNum1.AutoSize = true;
            this.lbl_CustomErrorNum1.Location = new System.Drawing.Point(176, 188);
            this.lbl_CustomErrorNum1.Name = "lbl_CustomErrorNum1";
            this.lbl_CustomErrorNum1.Size = new System.Drawing.Size(0, 17);
            this.lbl_CustomErrorNum1.TabIndex = 14;
            // 
            // lbl_CustomErrorNum2
            // 
            this.lbl_CustomErrorNum2.AutoSize = true;
            this.lbl_CustomErrorNum2.Location = new System.Drawing.Point(176, 216);
            this.lbl_CustomErrorNum2.Name = "lbl_CustomErrorNum2";
            this.lbl_CustomErrorNum2.Size = new System.Drawing.Size(0, 17);
            this.lbl_CustomErrorNum2.TabIndex = 15;
            // 
            // checkBoxY
            // 
            this.checkBoxY.AutoSize = true;
            this.checkBoxY.BackColor = System.Drawing.SystemColors.Info;
            this.checkBoxY.Location = new System.Drawing.Point(74, 35);
            this.checkBoxY.Name = "checkBoxY";
            this.checkBoxY.Size = new System.Drawing.Size(70, 21);
            this.checkBoxY.TabIndex = 10;
            this.checkBoxY.Text = "Yellow";
            this.checkBoxY.UseVisualStyleBackColor = false;
            this.checkBoxY.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxB
            // 
            this.checkBoxB.AutoSize = true;
            this.checkBoxB.BackColor = System.Drawing.SystemColors.Highlight;
            this.checkBoxB.Location = new System.Drawing.Point(200, 35);
            this.checkBoxB.Name = "checkBoxB";
            this.checkBoxB.Size = new System.Drawing.Size(58, 21);
            this.checkBoxB.TabIndex = 16;
            this.checkBoxB.Text = "Blue";
            this.checkBoxB.UseVisualStyleBackColor = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.BackColor = System.Drawing.Color.Red;
            this.checkBox3.Location = new System.Drawing.Point(331, 35);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(56, 21);
            this.checkBox3.TabIndex = 17;
            this.checkBox3.Text = "Red";
            this.checkBox3.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxY);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBoxB);
            this.groupBox2.Location = new System.Drawing.Point(12, 324);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(612, 78);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // SettingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 529);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl_CustomErrorNum2);
            this.Controls.Add(this.lbl_CustomErrorNum1);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gBx_Difficulty);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SettingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting Screen";
            this.Load += new System.EventHandler(this.SettingScreen_Load);
            this.gBx_Difficulty.ResumeLayout(false);
            this.gBx_Difficulty.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Label lbl_CustomErrorNum1;
        private System.Windows.Forms.Label lbl_CustomErrorNum2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBoxB;
        private System.Windows.Forms.CheckBox checkBoxY;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
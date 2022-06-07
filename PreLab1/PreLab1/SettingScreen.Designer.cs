
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
            this.gBx_Shape = new System.Windows.Forms.GroupBox();
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
            this.cBx_Yellow = new System.Windows.Forms.CheckBox();
            this.cBx_Blue = new System.Windows.Forms.CheckBox();
            this.cBx_Red = new System.Windows.Forms.CheckBox();
            this.gBx_Color = new System.Windows.Forms.GroupBox();
            this.gBx_Difficulty.SuspendLayout();
            this.gBx_Shape.SuspendLayout();
            this.gBx_Color.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(280, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "SETTINGS";
            // 
            // rBtn_Easy
            // 
            this.rBtn_Easy.AutoSize = true;
            this.rBtn_Easy.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtn_Easy.Location = new System.Drawing.Point(76, 46);
            this.rBtn_Easy.Name = "rBtn_Easy";
            this.rBtn_Easy.Size = new System.Drawing.Size(79, 31);
            this.rBtn_Easy.TabIndex = 1;
            this.rBtn_Easy.Text = "Easy";
            this.rBtn_Easy.UseVisualStyleBackColor = true;
            // 
            // rBtn_Normal
            // 
            this.rBtn_Normal.AutoSize = true;
            this.rBtn_Normal.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtn_Normal.Location = new System.Drawing.Point(250, 46);
            this.rBtn_Normal.Name = "rBtn_Normal";
            this.rBtn_Normal.Size = new System.Drawing.Size(93, 31);
            this.rBtn_Normal.TabIndex = 2;
            this.rBtn_Normal.Text = "Normal";
            this.rBtn_Normal.UseVisualStyleBackColor = true;
            // 
            // rBtn_Hard
            // 
            this.rBtn_Hard.AutoSize = true;
            this.rBtn_Hard.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtn_Hard.Location = new System.Drawing.Point(435, 46);
            this.rBtn_Hard.Name = "rBtn_Hard";
            this.rBtn_Hard.Size = new System.Drawing.Size(77, 31);
            this.rBtn_Hard.TabIndex = 3;
            this.rBtn_Hard.Text = "Hard";
            this.rBtn_Hard.UseVisualStyleBackColor = true;
            // 
            // rBtn_Custom
            // 
            this.rBtn_Custom.AutoSize = true;
            this.rBtn_Custom.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtn_Custom.Location = new System.Drawing.Point(597, 46);
            this.rBtn_Custom.Name = "rBtn_Custom";
            this.rBtn_Custom.Size = new System.Drawing.Size(99, 31);
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
            this.gBx_Difficulty.Font = new System.Drawing.Font("Papyrus", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBx_Difficulty.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gBx_Difficulty.Location = new System.Drawing.Point(12, 95);
            this.gBx_Difficulty.Name = "gBx_Difficulty";
            this.gBx_Difficulty.Size = new System.Drawing.Size(749, 96);
            this.gBx_Difficulty.TabIndex = 1;
            this.gBx_Difficulty.TabStop = false;
            this.gBx_Difficulty.Text = "Difficulty";
            // 
            // gBx_Shape
            // 
            this.gBx_Shape.Controls.Add(this.cBx_Round);
            this.gBx_Shape.Controls.Add(this.cBx_Square);
            this.gBx_Shape.Controls.Add(this.cBx_Triangle);
            this.gBx_Shape.Font = new System.Drawing.Font("Papyrus", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBx_Shape.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gBx_Shape.Location = new System.Drawing.Point(14, 274);
            this.gBx_Shape.Name = "gBx_Shape";
            this.gBx_Shape.Size = new System.Drawing.Size(746, 106);
            this.gBx_Shape.TabIndex = 6;
            this.gBx_Shape.TabStop = false;
            this.gBx_Shape.Text = "Shape";
            // 
            // cBx_Round
            // 
            this.cBx_Round.AutoSize = true;
            this.cBx_Round.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBx_Round.Location = new System.Drawing.Point(433, 46);
            this.cBx_Round.Name = "cBx_Round";
            this.cBx_Round.Size = new System.Drawing.Size(87, 31);
            this.cBx_Round.TabIndex = 9;
            this.cBx_Round.Text = "Round";
            this.cBx_Round.UseVisualStyleBackColor = true;
            // 
            // cBx_Square
            // 
            this.cBx_Square.AutoSize = true;
            this.cBx_Square.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBx_Square.Location = new System.Drawing.Point(83, 46);
            this.cBx_Square.Name = "cBx_Square";
            this.cBx_Square.Size = new System.Drawing.Size(96, 31);
            this.cBx_Square.TabIndex = 7;
            this.cBx_Square.Text = "Square";
            this.cBx_Square.UseVisualStyleBackColor = true;
            // 
            // cBx_Triangle
            // 
            this.cBx_Triangle.AutoSize = true;
            this.cBx_Triangle.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBx_Triangle.Location = new System.Drawing.Point(248, 46);
            this.cBx_Triangle.Name = "cBx_Triangle";
            this.cBx_Triangle.Size = new System.Drawing.Size(104, 31);
            this.cBx_Triangle.TabIndex = 8;
            this.cBx_Triangle.Text = "Triangle";
            this.cBx_Triangle.UseVisualStyleBackColor = true;
            // 
            // Btn_Save
            // 
            this.Btn_Save.BackColor = System.Drawing.Color.AliceBlue;
            this.Btn_Save.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Btn_Save.Location = new System.Drawing.Point(547, 534);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(213, 55);
            this.Btn_Save.TabIndex = 10;
            this.Btn_Save.Text = "SAVE";
            this.Btn_Save.UseVisualStyleBackColor = false;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtNum1.Location = new System.Drawing.Point(692, 197);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(43, 28);
            this.txtNum1.TabIndex = 5;
            this.txtNum1.Visible = false;
            this.txtNum1.TextChanged += new System.EventHandler(this.txtNum1_TextChanged);
            // 
            // txtNum2
            // 
            this.txtNum2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtNum2.Location = new System.Drawing.Point(692, 240);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(43, 28);
            this.txtNum2.TabIndex = 6;
            this.txtNum2.Visible = false;
            this.txtNum2.TextChanged += new System.EventHandler(this.txtNum2_TextChanged);
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNum1.Location = new System.Drawing.Point(559, 201);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(116, 22);
            this.lblNum1.TabIndex = 12;
            this.lblNum1.Text = "Enter Number 1:";
            this.lblNum1.Visible = false;
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNum2.Location = new System.Drawing.Point(559, 244);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(116, 22);
            this.lblNum2.TabIndex = 13;
            this.lblNum2.Text = "Enter Number 2:";
            this.lblNum2.Visible = false;
            // 
            // lbl_CustomErrorNum1
            // 
            this.lbl_CustomErrorNum1.AutoSize = true;
            this.lbl_CustomErrorNum1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_CustomErrorNum1.Location = new System.Drawing.Point(238, 247);
            this.lbl_CustomErrorNum1.Name = "lbl_CustomErrorNum1";
            this.lbl_CustomErrorNum1.Size = new System.Drawing.Size(0, 22);
            this.lbl_CustomErrorNum1.TabIndex = 14;
            // 
            // lbl_CustomErrorNum2
            // 
            this.lbl_CustomErrorNum2.AutoSize = true;
            this.lbl_CustomErrorNum2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_CustomErrorNum2.Location = new System.Drawing.Point(238, 290);
            this.lbl_CustomErrorNum2.Name = "lbl_CustomErrorNum2";
            this.lbl_CustomErrorNum2.Size = new System.Drawing.Size(0, 22);
            this.lbl_CustomErrorNum2.TabIndex = 15;
            // 
            // cBx_Yellow
            // 
            this.cBx_Yellow.AutoSize = true;
            this.cBx_Yellow.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cBx_Yellow.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBx_Yellow.Location = new System.Drawing.Point(82, 49);
            this.cBx_Yellow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBx_Yellow.Name = "cBx_Yellow";
            this.cBx_Yellow.Size = new System.Drawing.Size(89, 31);
            this.cBx_Yellow.TabIndex = 10;
            this.cBx_Yellow.Text = "Yellow";
            this.cBx_Yellow.UseVisualStyleBackColor = false;
            // 
            // cBx_Blue
            // 
            this.cBx_Blue.AutoSize = true;
            this.cBx_Blue.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cBx_Blue.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBx_Blue.Location = new System.Drawing.Point(247, 49);
            this.cBx_Blue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBx_Blue.Name = "cBx_Blue";
            this.cBx_Blue.Size = new System.Drawing.Size(74, 31);
            this.cBx_Blue.TabIndex = 16;
            this.cBx_Blue.Text = "Blue";
            this.cBx_Blue.UseVisualStyleBackColor = false;
            // 
            // cBx_Red
            // 
            this.cBx_Red.AutoSize = true;
            this.cBx_Red.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cBx_Red.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBx_Red.Location = new System.Drawing.Point(432, 49);
            this.cBx_Red.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBx_Red.Name = "cBx_Red";
            this.cBx_Red.Size = new System.Drawing.Size(68, 31);
            this.cBx_Red.TabIndex = 17;
            this.cBx_Red.Text = "Red";
            this.cBx_Red.UseVisualStyleBackColor = false;
            // 
            // gBx_Color
            // 
            this.gBx_Color.Controls.Add(this.cBx_Yellow);
            this.gBx_Color.Controls.Add(this.cBx_Red);
            this.gBx_Color.Controls.Add(this.cBx_Blue);
            this.gBx_Color.Font = new System.Drawing.Font("Papyrus", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBx_Color.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gBx_Color.Location = new System.Drawing.Point(15, 404);
            this.gBx_Color.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gBx_Color.Name = "gBx_Color";
            this.gBx_Color.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gBx_Color.Size = new System.Drawing.Size(746, 106);
            this.gBx_Color.TabIndex = 18;
            this.gBx_Color.TabStop = false;
            this.gBx_Color.Text = "Color";
            // 
            // SettingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(773, 610);
            this.Controls.Add(this.gBx_Color);
            this.Controls.Add(this.lbl_CustomErrorNum2);
            this.Controls.Add(this.lbl_CustomErrorNum1);
            this.Controls.Add(this.gBx_Difficulty);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.gBx_Shape);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Papyrus", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SettingScreen";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting Screen";
            this.Load += new System.EventHandler(this.SettingScreen_Load);
            this.gBx_Difficulty.ResumeLayout(false);
            this.gBx_Difficulty.PerformLayout();
            this.gBx_Shape.ResumeLayout(false);
            this.gBx_Shape.PerformLayout();
            this.gBx_Color.ResumeLayout(false);
            this.gBx_Color.PerformLayout();
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
        private System.Windows.Forms.GroupBox gBx_Shape;
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
        private System.Windows.Forms.CheckBox cBx_Red;
        private System.Windows.Forms.CheckBox cBx_Blue;
        private System.Windows.Forms.CheckBox cBx_Yellow;
        private System.Windows.Forms.GroupBox gBx_Color;
    }
}
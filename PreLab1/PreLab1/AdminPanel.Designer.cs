﻿
namespace PreLab1
{
    partial class AdminPanel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_AddUser = new System.Windows.Forms.Button();
            this.btn_UpdateUser = new System.Windows.Forms.Button();
            this.btn_DeleteUser = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_country = new System.Windows.Forms.TextBox();
            this.txt_nameSurname = new System.Windows.Forms.TextBox();
            this.txt_phoneNumber = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_city = new System.Windows.Forms.Label();
            this.lbl_country = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_phoneNumber = new System.Windows.Forms.Label();
            this.lbl_nameSurname = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_minToMax = new System.Windows.Forms.RadioButton();
            this.rb_maxToMin = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(842, 265);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_AddUser.Font = new System.Drawing.Font("Castellar", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddUser.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_AddUser.Location = new System.Drawing.Point(585, 303);
            this.btn_AddUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(189, 50);
            this.btn_AddUser.TabIndex = 12;
            this.btn_AddUser.Text = "ADD USER";
            this.btn_AddUser.UseVisualStyleBackColor = false;
            this.btn_AddUser.Click += new System.EventHandler(this.btn_AddUser_Click_1);
            // 
            // btn_UpdateUser
            // 
            this.btn_UpdateUser.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_UpdateUser.Font = new System.Drawing.Font("Castellar", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateUser.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_UpdateUser.Location = new System.Drawing.Point(585, 377);
            this.btn_UpdateUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_UpdateUser.Name = "btn_UpdateUser";
            this.btn_UpdateUser.Size = new System.Drawing.Size(189, 50);
            this.btn_UpdateUser.TabIndex = 14;
            this.btn_UpdateUser.Text = "UPDATE USER";
            this.btn_UpdateUser.UseVisualStyleBackColor = false;
            this.btn_UpdateUser.Click += new System.EventHandler(this.btn_UpdateUser_Click);
            // 
            // btn_DeleteUser
            // 
            this.btn_DeleteUser.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_DeleteUser.Font = new System.Drawing.Font("Castellar", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteUser.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_DeleteUser.Location = new System.Drawing.Point(585, 451);
            this.btn_DeleteUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DeleteUser.Name = "btn_DeleteUser";
            this.btn_DeleteUser.Size = new System.Drawing.Size(189, 50);
            this.btn_DeleteUser.TabIndex = 15;
            this.btn_DeleteUser.Text = "DELETE USER";
            this.btn_DeleteUser.UseVisualStyleBackColor = false;
            this.btn_DeleteUser.Click += new System.EventHandler(this.btn_DeleteUser_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_UserName);
            this.groupBox1.Controls.Add(this.lbl_UserName);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.txt_country);
            this.groupBox1.Controls.Add(this.txt_nameSurname);
            this.groupBox1.Controls.Add(this.txt_phoneNumber);
            this.groupBox1.Controls.Add(this.txt_address);
            this.groupBox1.Controls.Add(this.txt_city);
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.Controls.Add(this.lbl_email);
            this.groupBox1.Controls.Add(this.lbl_city);
            this.groupBox1.Controls.Add(this.lbl_country);
            this.groupBox1.Controls.Add(this.lbl_address);
            this.groupBox1.Controls.Add(this.lbl_phoneNumber);
            this.groupBox1.Controls.Add(this.lbl_nameSurname);
            this.groupBox1.Controls.Add(this.lbl_password);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.groupBox1.Location = new System.Drawing.Point(47, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 327);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Font = new System.Drawing.Font("Papyrus", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txt_UserName.Location = new System.Drawing.Point(239, 48);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(198, 28);
            this.txt_UserName.TabIndex = 26;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_UserName.Location = new System.Drawing.Point(23, 49);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(123, 21);
            this.lbl_UserName.TabIndex = 25;
            this.lbl_UserName.Text = "User Name:";
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Papyrus", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txt_email.Location = new System.Drawing.Point(239, 259);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(198, 28);
            this.txt_email.TabIndex = 24;
            // 
            // txt_country
            // 
            this.txt_country.Font = new System.Drawing.Font("Papyrus", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_country.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txt_country.Location = new System.Drawing.Point(239, 229);
            this.txt_country.Name = "txt_country";
            this.txt_country.Size = new System.Drawing.Size(198, 28);
            this.txt_country.TabIndex = 22;
            // 
            // txt_nameSurname
            // 
            this.txt_nameSurname.Font = new System.Drawing.Font("Papyrus", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nameSurname.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txt_nameSurname.Location = new System.Drawing.Point(239, 109);
            this.txt_nameSurname.Name = "txt_nameSurname";
            this.txt_nameSurname.Size = new System.Drawing.Size(198, 28);
            this.txt_nameSurname.TabIndex = 14;
            // 
            // txt_phoneNumber
            // 
            this.txt_phoneNumber.Font = new System.Drawing.Font("Papyrus", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phoneNumber.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txt_phoneNumber.Location = new System.Drawing.Point(239, 139);
            this.txt_phoneNumber.Name = "txt_phoneNumber";
            this.txt_phoneNumber.Size = new System.Drawing.Size(198, 28);
            this.txt_phoneNumber.TabIndex = 16;
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Papyrus", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txt_address.Location = new System.Drawing.Point(239, 169);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(198, 28);
            this.txt_address.TabIndex = 18;
            // 
            // txt_city
            // 
            this.txt_city.Font = new System.Drawing.Font("Papyrus", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_city.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txt_city.Location = new System.Drawing.Point(239, 199);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(198, 28);
            this.txt_city.TabIndex = 20;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Papyrus", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txt_password.Location = new System.Drawing.Point(239, 79);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(198, 28);
            this.txt_password.TabIndex = 12;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_email.Location = new System.Drawing.Point(23, 259);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(102, 21);
            this.lbl_email.TabIndex = 23;
            this.lbl_email.Text = "E - Mail :";
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Font = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_city.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_city.Location = new System.Drawing.Point(23, 199);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(66, 21);
            this.lbl_city.TabIndex = 21;
            this.lbl_city.Text = "City :";
            // 
            // lbl_country
            // 
            this.lbl_country.AutoSize = true;
            this.lbl_country.Font = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_country.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_country.Location = new System.Drawing.Point(23, 229);
            this.lbl_country.Name = "lbl_country";
            this.lbl_country.Size = new System.Drawing.Size(117, 21);
            this.lbl_country.TabIndex = 19;
            this.lbl_country.Text = "Country :";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_address.Location = new System.Drawing.Point(23, 169);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(103, 21);
            this.lbl_address.TabIndex = 17;
            this.lbl_address.Text = "Address :";
            // 
            // lbl_phoneNumber
            // 
            this.lbl_phoneNumber.AutoSize = true;
            this.lbl_phoneNumber.Font = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phoneNumber.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_phoneNumber.Location = new System.Drawing.Point(23, 139);
            this.lbl_phoneNumber.Name = "lbl_phoneNumber";
            this.lbl_phoneNumber.Size = new System.Drawing.Size(174, 21);
            this.lbl_phoneNumber.TabIndex = 15;
            this.lbl_phoneNumber.Text = "Phone Number :";
            // 
            // lbl_nameSurname
            // 
            this.lbl_nameSurname.AutoSize = true;
            this.lbl_nameSurname.Font = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nameSurname.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_nameSurname.Location = new System.Drawing.Point(23, 109);
            this.lbl_nameSurname.Name = "lbl_nameSurname";
            this.lbl_nameSurname.Size = new System.Drawing.Size(192, 21);
            this.lbl_nameSurname.TabIndex = 13;
            this.lbl_nameSurname.Text = "Name - Surname :";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_password.Location = new System.Drawing.Point(23, 79);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(123, 21);
            this.lbl_password.TabIndex = 11;
            this.lbl_password.Text = "Password :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_minToMax);
            this.groupBox2.Controls.Add(this.rb_maxToMin);
            this.groupBox2.Font = new System.Drawing.Font("Castellar", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Location = new System.Drawing.Point(524, 528);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 82);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Type";
            // 
            // rb_minToMax
            // 
            this.rb_minToMax.AutoSize = true;
            this.rb_minToMax.Location = new System.Drawing.Point(21, 32);
            this.rb_minToMax.Name = "rb_minToMax";
            this.rb_minToMax.Size = new System.Drawing.Size(133, 21);
            this.rb_minToMax.TabIndex = 33;
            this.rb_minToMax.TabStop = true;
            this.rb_minToMax.Text = "Min To Max";
            this.rb_minToMax.UseVisualStyleBackColor = true;
            this.rb_minToMax.CheckedChanged += new System.EventHandler(this.rb_minToMax_CheckedChanged);
            // 
            // rb_maxToMin
            // 
            this.rb_maxToMin.AutoSize = true;
            this.rb_maxToMin.Location = new System.Drawing.Point(182, 32);
            this.rb_maxToMin.Name = "rb_maxToMin";
            this.rb_maxToMin.Size = new System.Drawing.Size(133, 21);
            this.rb_maxToMin.TabIndex = 32;
            this.rb_maxToMin.TabStop = true;
            this.rb_maxToMin.Text = "Max To Min";
            this.rb_maxToMin.UseVisualStyleBackColor = true;
            this.rb_maxToMin.CheckedChanged += new System.EventHandler(this.rb_maxToMin_CheckedChanged);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(866, 621);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_DeleteUser);
            this.Controls.Add(this.btn_UpdateUser);
            this.Controls.Add(this.btn_AddUser);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminPanel_FormClosing);
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_AddUser;
        private System.Windows.Forms.Button btn_UpdateUser;
        private System.Windows.Forms.Button btn_DeleteUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_country;
        private System.Windows.Forms.TextBox txt_nameSurname;
        private System.Windows.Forms.TextBox txt_phoneNumber;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.Label lbl_country;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_phoneNumber;
        private System.Windows.Forms.Label lbl_nameSurname;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_maxToMin;
        private System.Windows.Forms.RadioButton rb_minToMax;
    }
}
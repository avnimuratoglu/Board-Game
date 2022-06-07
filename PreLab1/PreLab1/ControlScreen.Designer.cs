
namespace PreLab1
{
    partial class ControlScreen
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbConnectToGame = new System.Windows.Forms.GroupBox();
            this.btnHost = new System.Windows.Forms.Button();
            this.gbConnectToGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP:";
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.AliceBlue;
            this.btnConnect.Location = new System.Drawing.Point(69, 97);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(204, 32);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 28);
            this.textBox1.TabIndex = 2;
            // 
            // gbConnectToGame
            // 
            this.gbConnectToGame.Controls.Add(this.btnHost);
            this.gbConnectToGame.Controls.Add(this.btnConnect);
            this.gbConnectToGame.Controls.Add(this.label1);
            this.gbConnectToGame.Controls.Add(this.textBox1);
            this.gbConnectToGame.Font = new System.Drawing.Font("Papyrus", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConnectToGame.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gbConnectToGame.Location = new System.Drawing.Point(12, 12);
            this.gbConnectToGame.Name = "gbConnectToGame";
            this.gbConnectToGame.Size = new System.Drawing.Size(339, 179);
            this.gbConnectToGame.TabIndex = 3;
            this.gbConnectToGame.TabStop = false;
            this.gbConnectToGame.Text = "Connect to Game";
            // 
            // btnHost
            // 
            this.btnHost.BackColor = System.Drawing.Color.AliceBlue;
            this.btnHost.Font = new System.Drawing.Font("Papyrus", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHost.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnHost.Location = new System.Drawing.Point(69, 135);
            this.btnHost.Name = "btnHost";
            this.btnHost.Size = new System.Drawing.Size(204, 32);
            this.btnHost.TabIndex = 4;
            this.btnHost.Text = "Host Game";
            this.btnHost.UseVisualStyleBackColor = false;
            this.btnHost.Click += new System.EventHandler(this.btnHost_Click);
            // 
            // ControlScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(363, 203);
            this.Controls.Add(this.gbConnectToGame);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Name = "ControlScreen";
            this.Text = "ControlScreen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControlScreen_FormClosing);
            this.gbConnectToGame.ResumeLayout(false);
            this.gbConnectToGame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gbConnectToGame;
        private System.Windows.Forms.Button btnHost;
    }
}
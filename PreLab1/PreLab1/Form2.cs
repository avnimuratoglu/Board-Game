using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreLab1
{
    public partial class SettingScreen : Form
    {
        public SettingScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            MenuScreen menuScreen = new MenuScreen();
            menuScreen.ShowDialog();
            this.Close();
        }

        private void gBx_Difficulty_Enter(object sender, EventArgs e)
        {

        }

        private void rBtn_Custom_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtn_Custom.Checked) {
                txtNum1.Visible = true;
                txtNum2.Visible = true;
                lblNum1.Visible = true;
                lblNum2.Visible= true;
            }
            else
            {
                txtNum1.Visible = false;
                txtNum2.Visible = false;
                lblNum1.Visible = false;
                lblNum2.Visible = false;
            }

        }

    }
}

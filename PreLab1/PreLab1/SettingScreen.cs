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

        MenuScreen menuScreen = new MenuScreen();
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rBtn_Custom_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtn_Custom.Checked) {
                txtNum1.Visible = true;
                txtNum2.Visible = true;
                lblNum1.Visible = true;
                lblNum2.Visible = true;
            }
            else
            {
                txtNum1.Visible = false;
                txtNum2.Visible = false;
                lblNum1.Visible = false;
                lblNum2.Visible = false;
            }

        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            int num1;

            try
            {
                num1 = int.Parse(txtNum1.Text);
            }
            catch (Exception ex)
            {
                if (txtNum1.Text.Length == 0)
                    lbl_CustomErrorNum1.Visible = false;
                else
                {
                    lbl_CustomErrorNum1.Visible = true;
                    lbl_CustomErrorNum1.Text = "You entered an invalid value for Number 1!";
                }
            }
           
            
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {

            int num2;
            try
            {
                num2 = int.Parse(txtNum2.Text);

            }
            catch (Exception ex)
            {
                if (txtNum2.Text.Length == 0)
                    lbl_CustomErrorNum2.Visible = false;
                else
                {
                    lbl_CustomErrorNum2.Visible = true;
                    lbl_CustomErrorNum2.Text = "You entered an invalid value for Number 2!";
                }
                   

            }
        }
    }
}

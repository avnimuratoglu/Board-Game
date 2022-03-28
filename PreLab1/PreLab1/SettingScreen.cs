using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //dosya islemleri icin kullanacagimiz nesneler bu sinifta yer alir.

namespace PreLab1
{
    public partial class SettingScreen : Form
    {
        public SettingScreen()
        {
            InitializeComponent();
        }

        MenuScreen menuScreen = new MenuScreen();
        LoginScreen loginScreen = new LoginScreen();

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if(LoginScreen.flag == false )
            {

                if (cBx_Square.Checked)
                    SettingsUser.Default.User_CheckSquare = cBx_Square.Checked;
                else
                    SettingsUser.Default.User_CheckSquare = cBx_Square.Checked;
                if (cBx_Triangle.Checked)
                    SettingsUser.Default.User_CheckTriangle = cBx_Triangle.Checked;
                else
                    SettingsUser.Default.User_CheckTriangle = cBx_Triangle.Checked;
                if (cBx_Round.Checked)
                    SettingsUser.Default.User_CheckRound = cBx_Round.Checked;
                else
                    SettingsUser.Default.User_CheckRound = cBx_Round.Checked;



                if (rBtn_Easy.Checked)
                    SettingsUser.Default.User_rBtnEasy = rBtn_Easy.Checked;
                else
                    SettingsUser.Default.User_rBtnEasy = rBtn_Easy.Checked;
                if (rBtn_Normal.Checked)
                    SettingsUser.Default.User_rBtnNormal = rBtn_Normal.Checked;
                else
                    SettingsUser.Default.User_rBtnNormal = rBtn_Normal.Checked;
                if (rBtn_Hard.Checked)
                    SettingsUser.Default.User_rBtnHard = rBtn_Hard.Checked;
                else
                    SettingsUser.Default.User_rBtnHard = rBtn_Hard.Checked;


                if (rBtn_Custom.Checked)
                {
                    SettingsUser.Default.User_rBtnCustom = rBtn_Custom.Checked;
                    SettingsUser.Default.User_diffCustomNum1 = Convert.ToInt32(txtNum1.Text);
                    SettingsUser.Default.User_diffCustomNum2 = Convert.ToInt32(txtNum2.Text);
                }
                else
                    SettingsUser.Default.User_rBtnCustom = rBtn_Custom.Checked;

                SettingsUser.Default.Save();
            }
            else
            {

                if (cBx_Square.Checked)
                    SettingsAdmin.Default.Admin_CheckSquare = cBx_Square.Checked;
                else
                    SettingsAdmin.Default.Admin_CheckSquare = cBx_Square.Checked;
                if (cBx_Triangle.Checked)
                    SettingsAdmin.Default.Admin_CheckTriangle = cBx_Triangle.Checked;
                else
                    SettingsAdmin.Default.Admin_CheckTriangle = cBx_Triangle.Checked;
                if (cBx_Round.Checked)
                    SettingsAdmin.Default.Admin_CheckRound = cBx_Round.Checked;
                else
                    SettingsAdmin.Default.Admin_CheckRound = cBx_Round.Checked;



                if (rBtn_Easy.Checked)
                    SettingsAdmin.Default.Admin_rBtnEasy = rBtn_Easy.Checked;
                else
                    SettingsAdmin.Default.Admin_rBtnEasy = rBtn_Easy.Checked;
                if (rBtn_Normal.Checked)
                    SettingsAdmin.Default.Admin_rBtnNormal = rBtn_Normal.Checked;
                else
                    SettingsAdmin.Default.Admin_rBtnNormal = rBtn_Normal.Checked;
                if (rBtn_Hard.Checked)
                    SettingsAdmin.Default.Admin_rBtnHard = rBtn_Hard.Checked;
                else
                    SettingsAdmin.Default.Admin_rBtnHard = rBtn_Hard.Checked;


                if (rBtn_Custom.Checked)
                {
                    SettingsAdmin.Default.Admin_rBtnCustom = rBtn_Custom.Checked;
                    SettingsAdmin.Default.Admin_diffCustomNum1 = Convert.ToInt32(txtNum1.Text);
                    SettingsAdmin.Default.Admin_diffCustomNum2 = Convert.ToInt32(txtNum2.Text);
                }
                else
                    SettingsAdmin.Default.Admin_rBtnCustom = rBtn_Custom.Checked;

                SettingsAdmin.Default.Save();
            }
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
                {
                    lbl_CustomErrorNum1.Visible = false;
                }
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
                { 
                    lbl_CustomErrorNum2.Visible = false;
                }
                
                else
                {
                    lbl_CustomErrorNum2.Visible = true;
                    lbl_CustomErrorNum2.Text = "You entered an invalid value for Number 2!";
                }

            }
        }

        private void SettingScreen_Load(object sender, EventArgs e)
        {
            if (LoginScreen.flag == false)
            {
                //Check Boxes
                cBx_Square.Checked = SettingsUser.Default.User_CheckSquare;
                cBx_Triangle.Checked = SettingsUser.Default.User_CheckTriangle;
                cBx_Round.Checked = SettingsUser.Default.User_CheckRound;

                //Radio Buttons
                rBtn_Easy.Checked = SettingsUser.Default.User_rBtnEasy;
                rBtn_Normal.Checked = SettingsUser.Default.User_rBtnNormal;
                rBtn_Hard.Checked = SettingsUser.Default.User_rBtnHard;
                rBtn_Custom.Checked = SettingsUser.Default.User_rBtnCustom;

                //Custom Button
                txtNum1.Text = Convert.ToString(SettingsUser.Default.User_diffCustomNum1);
                txtNum2.Text = Convert.ToString(SettingsUser.Default.User_diffCustomNum2);
            }
            else
            {  //Check Boxes
                cBx_Square.Checked = SettingsAdmin.Default.Admin_CheckSquare;
                cBx_Triangle.Checked = SettingsAdmin.Default.Admin_CheckTriangle;
                cBx_Round.Checked = SettingsAdmin.Default.Admin_CheckRound;

                //Radio Buttons
                rBtn_Easy.Checked = SettingsAdmin.Default.Admin_rBtnEasy;
                rBtn_Normal.Checked = SettingsAdmin.Default.Admin_rBtnNormal;
                rBtn_Hard.Checked = SettingsAdmin.Default.Admin_rBtnHard;
                rBtn_Custom.Checked = SettingsAdmin.Default.Admin_rBtnCustom;

                //Custom Button
                txtNum1.Text = Convert.ToString(SettingsAdmin.Default.Admin_diffCustomNum1);
                txtNum2.Text = Convert.ToString(SettingsAdmin.Default.Admin_diffCustomNum2);
            }
        }
    }
}

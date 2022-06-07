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
using System.Xml;
using System.Xml.Linq;

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
          
            //FileStream fs = new FileStream(@"Entry.txt", FileMode.Append, FileAccess.Write);
            //StreamWriter write = new StreamWriter(fs);

            //if (cBx_Square.Checked)
            //    write.WriteLine("Square");
            //if (cBx_Triangle.Checked)
            //    write.WriteLine("Triangle");
            //if (cBx_Round.Checked)
            //    write.WriteLine("Round");

            //fs.Close();
           

            //if(LoginScreen.flag == false ) //USER
                //SHAPE
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


            //DIFFICULTY
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

            //DIFFICULTY CUSTOM
            if (rBtn_Custom.Checked)
            {
                SettingsUser.Default.User_rBtnCustom = rBtn_Custom.Checked;
                SettingsUser.Default.User_diffCustomNum1 = Convert.ToInt32(txtNum1.Text);
                SettingsUser.Default.User_diffCustomNum2 = Convert.ToInt32(txtNum2.Text);
            }
            else
                SettingsUser.Default.User_rBtnCustom = rBtn_Custom.Checked;
            
            //COLOR
            if (cBx_Yellow.Checked)
                SettingsUser.Default.User_colorYellow = cBx_Yellow.Checked;
            else
                SettingsUser.Default.User_colorYellow = cBx_Yellow.Checked;
            if (cBx_Blue.Checked)
                SettingsUser.Default.User_colorBlue = cBx_Blue.Checked;
            else
                SettingsUser.Default.User_colorBlue = cBx_Blue.Checked;
            if (cBx_Red.Checked)
                SettingsUser.Default.User_colorRed = cBx_Red.Checked;
            else
                SettingsUser.Default.User_colorRed = cBx_Red.Checked;


            int countShape = 0, countColor = 0;
            if (cBx_Square.Checked) countShape++;
            if (cBx_Triangle.Checked) countShape++;
            if (cBx_Round.Checked) countShape++;
            if (cBx_Yellow.Checked) countColor++;
            if (cBx_Blue.Checked) countColor++;
            if (cBx_Red.Checked) countColor++;

            if (countShape == 1 && countColor == 1)
                MessageBox.Show("Please make more choices!", "Warning Window!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                SettingsUser.Default.Save();

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
            //FileStream fs = new FileStream(@"Entry.txt", FileMode.Open, FileAccess.Read);
            //StreamReader sw = new StreamReader(fs);

            //if (sw.ReadLine() == "Square")
            //    cBx_Square.Checked = true;
            //else
            //    cBx_Square.Checked = false;
            //if (sw.ReadLine() == "Triangle")
            //    cBx_Triangle.Checked = true;
            //else
            //    cBx_Triangle.Checked = false;
            //if (sw.ReadLine() == "Round")
            //    cBx_Round.Checked = true;
            //else
            //    cBx_Round.Checked = false;

            //fs.Close();
            //string fileName = @"data.xml";
            //DataSet ds = new DataSet();
            //ds.ReadXml(fileName, XmlReadMode.InferSchema);

            //string name, password, difficulty, shape, color;
            //name = .Attribute("Name").Value.ToString();


            //foreach(XElement users in rootElement.Elements())
            //{
            //    ID = users.Attribute("ID").Value;
            //    for(int i =0; i<)

            //    //name = users.Attribute("Name").Value.ToString();
            //    //password = users.Attribute("Password").Value.ToString();
            //    //difficulty = users.Attribute("Difficulty").Value.ToString();
            //    //if (difficulty == "Easy")
            //    //    rBtn_Easy.Checked = true;
            //    //else if (difficulty == "Normal")
            //    //    rBtn_Normal.Checked = true;
            //    //else if (difficulty == "Hard")
            //    //    rBtn_Hard.Checked = true;

            //    //shape = users.Attribute("Shape").Value.ToString();
            //    //color = users.Attribute("Color").Value.ToString();
            //}




            //if (LoginScreen.flag == false)
            //{

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

            //Color Boxes
            cBx_Yellow.Checked = SettingsUser.Default.User_colorYellow;
            cBx_Blue.Checked = SettingsUser.Default.User_colorBlue;
            cBx_Red.Checked = SettingsUser.Default.User_colorRed;
        }

       
        //else
        //{  //Check Boxes
        //    cBx_Square.Checked = SettingsAdmin.Default.Admin_CheckSquare;
        //    cBx_Triangle.Checked = SettingsAdmin.Default.Admin_CheckTriangle;
        //    cBx_Round.Checked = SettingsAdmin.Default.Admin_CheckRound;

        //    //Radio Buttons
        //    rBtn_Easy.Checked = SettingsAdmin.Default.Admin_rBtnEasy;
        //    rBtn_Normal.Checked = SettingsAdmin.Default.Admin_rBtnNormal;
        //    rBtn_Hard.Checked = SettingsAdmin.Default.Admin_rBtnHard;
        //    rBtn_Custom.Checked = SettingsAdmin.Default.Admin_rBtnCustom;

        //    //Custom Button
        //    txtNum1.Text = Convert.ToString(SettingsAdmin.Default.Admin_diffCustomNum1);
        //    txtNum2.Text = Convert.ToString(SettingsAdmin.Default.Admin_diffCustomNum2);

        //    //Color Boxes
        //    cBx_Yellow.Checked = SettingsAdmin.Default.Admin_colorYellow;
        //    cBx_Blue.Checked = SettingsAdmin.Default.Admin_colorBlue;
        //    cBx_Red.Checked = SettingsAdmin.Default.Admin_colorRed;
        //}
    }
}

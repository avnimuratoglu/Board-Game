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
    public partial class GameScreen : Form
    {
        LoginScreen loginScreen = new LoginScreen();
        MenuScreen menuScreen = new MenuScreen();
        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            menuScreen.Close();
            loginScreen.Close();
            Application.Exit();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            
            {
                Button[,] button = new Button[9, 9];
                int top = 0;
                int left = 0;
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        button[i, j] = new Button();
                        button[i, j].Width = 50;
                        button[i, j].Height = 50;
                        button[i, j].Left = left;
                        button[i, j].Top = top;
                        this.Controls.Add(button[i, j]);
                        left += 50;
                        button[i, j].BackColor = Color.AliceBlue;}
                    top += 50;
                    left = 0;
                }

            }
        }
    }
}

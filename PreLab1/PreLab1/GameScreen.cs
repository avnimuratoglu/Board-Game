using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace PreLab1
{
    //public Color GetRandomColorOfList()
    //{
    //    Random random = new Random();
    //    List<Color> possibleColors = new List<Color>()
    //    {
    //        Color.Red,
    //        Color.Green,
    //        Color.Gold,
    //        Color.Blue
    //    };
    //    return possibleColors[random.Next(0, possibleColors.Count)];
    //}
    public partial class GameScreen : Form
    {
        LoginScreen loginScreen = new LoginScreen();
        MenuScreen menuScreen = new MenuScreen();

        public struct Coordinate
        {
            public int x;
            public int y;

            public Coordinate(int _x, int _y)
            {
                x = _x;
                y = _y;
            }
        }
        
        public Coordinate RandomCoordinate(int xBound, int yBound)
        {
            Random randomX = new Random();
            Random randomY = new Random();

            int x = randomX.Next(0, xBound);
            int y = randomY.Next(0, yBound);

            return new Coordinate(x, y);
        }

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

        List<Color> colors = new List<Color>()
        {
            Color.AliceBlue,
            Color.Blue,
            Color.Yellow,
            Color.Red
        };
        public void ShapeString()
        {
        }

        //static Random random = new Random();
        Random randomColor = new Random();
        Random randomShape = new Random();
        private Color GetRandomColor()
        {
            ArrayList colors = new ArrayList();
            colors.Add(Color.AliceBlue);
            if (SettingsUser.Default.User_colorYellow)
                colors.Add(Color.Yellow);
            if (SettingsUser.Default.User_colorBlue)
                colors.Add(Color.Blue);
            if (SettingsUser.Default.User_colorRed)
                colors.Add(Color.Red);

            List<Color> listOfColors = new List<Color>();

            foreach(Color color in colors)
            {
                listOfColors.Add(color);
            }
            //Color[] colors = new Color[4] { Color.Blue, Color.Yellow, Color.Red, Color.AliceBlue };
            return listOfColors[randomColor.Next(0, listOfColors.Count)];
        }
        private string GetRandomShape()
        {

            ArrayList shapes = new ArrayList();

            if (SettingsUser.Default.User_CheckSquare)
                shapes.Add("☐");
            if (SettingsUser.Default.User_CheckTriangle)
                shapes.Add("△");
            if (SettingsUser.Default.User_CheckRound)
                shapes.Add("◯");

            string[] arrShapes = shapes.ToArray(typeof(string)) as string[];

            //Color[] colors = new Color[4] { Color.Blue, Color.Yellow, Color.Red, Color.AliceBlue };
            return arrShapes[randomShape.Next(0, arrShapes.Length)];
        }

        void Button_MouseUp(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
        }
        void Button_MouseMove(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
        }
        void Button_MouseDown(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
        }
        private void GameScreen_Load(object sender, EventArgs e)
        {

            //ArrayList shapes = new ArrayList();

            //if (SettingsUser.Default.User_CheckSquare)
            //    shapes.Add("☐");
            //if (SettingsUser.Default.User_CheckTriangle)
            //    shapes.Add("△");
            //if (SettingsUser.Default.User_CheckRound)
            //    shapes.Add("◯");

            if (SettingsUser.Default.User_rBtnEasy)//Easy Board
            {
                Size = new Size(768, 790); //en boy
                Button[,] button = new Button[15, 15];
                int top = 0;
                int left = 0;

                
                for (int i = 0; i < 15; i++)
                {
                    for (int j = 0; j < 15; j++)
                    {
                        button[i, j] = new Button();
                        button[i, j].Width = 50;
                        button[i, j].Height = 50;
                        button[i, j].Left = left;
                        button[i, j].Top = top;
                        this.Controls.Add(button[i, j]);
                        button[i, j].BackColor = GetRandomColor();
                        if (button[i, j].BackColor != Color.AliceBlue)
                            button[i, j].Text = GetRandomShape();
                      
                        left += 50;
                    }
                    top += 50;
                    left = 0;
                }
            }
            if (SettingsUser.Default.User_rBtnNormal) // Normal board
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
                        button[i, j].BackColor = GetRandomColor();
                        if (button[i, j].BackColor != Color.AliceBlue)
                            button[i, j].Text = GetRandomShape();
                        //if (button[i, j].BackColor == Color.AliceBlue)
                        //    button[i, j].Visible = false;
                        left += 50;
                    }
                    top += 50;
                    left = 0;
                }
            }
            if (SettingsUser.Default.User_rBtnHard) //Hard Board
            {
                Size = new Size(318, 343); //en boy
                Button[,] button = new Button[6, 6];
                int top = 0;
                int left = 0;
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        button[i, j] = new Button();
                        button[i, j].Width = 50;
                        button[i, j].Height = 50;
                        button[i, j].Left = left;
                        button[i, j].Top = top;
                        this.Controls.Add(button[i, j]);
                        button[i, j].BackColor = GetRandomColor();
                        if (button[i, j].BackColor != Color.AliceBlue)
                            button[i, j].Text = GetRandomShape();
                        left += 50;
                    }
                    top += 50;
                    left = 0;
                }
            }
            if (SettingsUser.Default.User_rBtnCustom) //Custom Board
            {
                Size = new Size(650, 650); //en boy
                Button[,] button = new Button[SettingsUser.Default.User_diffCustomNum1, SettingsUser.Default.User_diffCustomNum2];
                int top = 0;
                int left = 0;
                for (int i = 0; i < SettingsUser.Default.User_diffCustomNum1; i++)
                {
                    for (int j = 0; j < SettingsUser.Default.User_diffCustomNum2; j++)
                    {
                        button[i, j] = new Button();
                        button[i, j].Width = 50;
                        button[i, j].Height = 50;
                        button[i, j].Left = left;
                        button[i, j].Top = top;
                        this.Controls.Add(button[i, j]);
                        button[i, j].BackColor = GetRandomColor();
                        if (button[i, j].BackColor != Color.AliceBlue)
                            button[i, j].Text = GetRandomShape();
                        left += 50;
                    }
                    top += 50;
                    left = 0;
                }
            }

        }

    }
}

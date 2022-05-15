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
        private static Random random = new Random();
        private bool clickTemp = false;
        private Color colorTemp;
        private string textTemp;
        private Button buttonTemp;
        private Button[,] buttonArray;
        private int[,] coordinate;
        private Coordinate coordFirst, coordLast;
      

        Coordinate findIndex(Button btn)
        {
            
            if (SettingsUser.Default.User_rBtnEasy)
            {
                coordinate = new int[15, 15];
                for (int i = 0; i < 15; i++)
                {
                    for (int j = 0; j < 15; j++)
                    {
                        if (buttonArray[i,j].Location == btn.Location)
                        {
                            return new Coordinate(i, j);
                        }
                    }
                }
            }
            else if (SettingsUser.Default.User_rBtnNormal)
            {
                coordinate = new int[9, 9];
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (buttonArray[i, j].Location == btn.Location)
                        {
                            return new Coordinate(i, j);
                        }
                    }
                }
            }
            else if (SettingsUser.Default.User_rBtnHard)
            {
                coordinate = new int[6, 6];
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (buttonArray[i, j].Location == btn.Location)
                        {
                            return new Coordinate(i, j);
                        }
                    }
                }
            }
            else if (SettingsUser.Default.User_rBtnCustom)
            {
                int a = SettingsUser.Default.User_diffCustomNum1;
                int b = SettingsUser.Default.User_diffCustomNum2;

                coordinate = new int[a, b];

                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        if (buttonArray[i, j].Location == btn.Location)
                        {
                            return new Coordinate(i, j);
                        }
                    }
                }
            }
            return new Coordinate(-1, -1);
        }

        void game(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int counterOfButtons = 0;
            

            if (clickTemp == false && btn.BackColor != Color.AliceBlue)
            {
               
                colorTemp = btn.BackColor;
                textTemp = btn.Text;
                buttonTemp = btn;
                coordFirst = findIndex(btn);

                if (btn.BackColor == Color.Blue)
                {
                    btn.BackColor = Color.Pink;
                }
                if (btn.BackColor == Color.Red)
                {
                    btn.BackColor = Color.Pink;
                }
                if (btn.BackColor == Color.Yellow)
                {
                    btn.BackColor = Color.Pink;
                }
               

                //MessageBox.Show("Buradan");
                clickTemp = true;

            }
            else if(clickTemp == true && btn.BackColor == Color.AliceBlue)
            {
                btn.BackColor = colorTemp;
                btn.Text = textTemp;
                buttonTemp.BackColor = Color.AliceBlue;
                buttonTemp.Text = "";
                coordLast= findIndex(btn);
               

                //MessageBox.Show("Buraya");
                clickTemp = false;

                int a = 0, b = 0;
                int lastElement;
                
                //tablo boyutu icin
                if (SettingsUser.Default.User_rBtnEasy)
                {
                    a = 15;
                    b = 15;
                    //allButtons = a * b;
                }
                else if(SettingsUser.Default.User_rBtnNormal)
                {
                    a = 9;
                    b = 9;
                    //allButtons = a * b;
                }
                else if (SettingsUser.Default.User_rBtnHard)
                {
                    a = 6;
                    b = 6;
                    //allButtons = a * b;
                }
                else if(SettingsUser.Default.User_rBtnCustom)
                {
                    a = SettingsUser.Default.User_diffCustomNum1;
                    b = SettingsUser.Default.User_diffCustomNum2;
                    //allButtons = a * b;
                }

                //BUTON PATLATMA 
                bool pop = false; //patlama kontrol 
                for (int i = 0; i < a; i++)
                {
                    if (buttonArray[coordLast.x, i].BackColor == btn.BackColor && buttonArray[coordLast.x, i].Text == btn.Text)
                    {
                        counterOfButtons++;

                        if (counterOfButtons >= 5)
                        {
                            pop = true;
                            lastElement = i;
                            for (int start = i; start >= 0; start--)
                            {
                                buttonArray[coordLast.x, start].BackColor = Color.AliceBlue;
                                buttonArray[coordLast.x, start].Text = "";
                                counterOfButtons--;
                                if (counterOfButtons == 0)
                                    break;
                            }
                        }
                    }
                    else
                        counterOfButtons = 0;

                }

               
                for (int j = 0; j < b; j++)
                {
                    if (buttonArray[j, coordLast.y].BackColor == btn.BackColor && buttonArray[j, coordLast.y].Text == btn.Text)
                    {
                        counterOfButtons++;
                        if (counterOfButtons >= 5)
                        {
                            pop = true;
                            lastElement = j;
                            for (int start = j; start >= 0; start--)
                            {
                                buttonArray[start, coordLast.y].BackColor = Color.AliceBlue;
                                buttonArray[start, coordLast.y].Text = "";
                                counterOfButtons--;
                                if (counterOfButtons == 0)
                                    break;
                            }
                        }
                    }
                    else
                        counterOfButtons = 0;
                }

                if(pop != true)
                {
                    int control = 0;
                    while (control != 3)
                    {
                        Coordinate c1 = RandomCoordinate(a, b);
                        if (buttonArray[c1.x, c1.y].BackColor == Color.AliceBlue)
                        {
                            control++;
                            buttonArray[c1.x, c1.y].Text = GetRandomShape();
                            buttonArray[c1.x, c1.y].BackColor = GetRandomColor();
                        }
                        //Coordinate c2 = RandomCoordinate(a, b);
                        //Coordinate c3 = RandomCoordinate(a, b);

                        //buttonArray[c2.x, c2.y].Text = GetRandomShape();
                        //buttonArray[c2.x, c2.y].BackColor = GetRandomColor();
                        //buttonArray[c3.x, c3.y].Text = GetRandomShape();
                        //buttonArray[c3.x, c3.y].BackColor = GetRandomColor();

                    }
                }            
            }
        }

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
            int x = random.Next(0, xBound);
            int y = random.Next(0, yBound);

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
            Color.Blue,
            Color.Yellow,
            Color.Red
        };

        //static Random random = new Random();
        Random randomColor = new Random();
        Random randomShape = new Random();
        private Color GetRandomColor()
        {
            ArrayList colors = new ArrayList();
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
                buttonArray = new Button[15, 15];
                int top = 0;
                int left = 0;

                
                for (int i = 0; i < 15; i++)
                {
                    for (int j = 0; j < 15; j++)
                    {
                        buttonArray[i, j] = new Button();
                        buttonArray[i, j].BackColor = Color.AliceBlue;
                        buttonArray[i, j].Width = 50;
                        buttonArray[i, j].Height = 50;
                        buttonArray[i, j].Left = left;
                        buttonArray[i, j].Top = top;
                        buttonArray[i, j].Click += new EventHandler(game);
                        this.Controls.Add(buttonArray[i, j]);
                        
                        left += 50;
                    }
                    top += 50;
                    left = 0;
                }

                int controleasy = 0;
                while (controleasy != 3)
                {
                    Coordinate c1 = RandomCoordinate(15, 15);
                    if (buttonArray[c1.x, c1.y].BackColor == Color.AliceBlue)
                    {
                        controleasy++;
                        buttonArray[c1.x, c1.y].Text = GetRandomShape();
                        buttonArray[c1.x, c1.y].BackColor = GetRandomColor();
                    }
                }
                //Coordinate c1 = RandomCoordinate(15, 15);
                //Coordinate c2 = RandomCoordinate(15, 15);
                //Coordinate c3 = RandomCoordinate(15, 15);
                //buttonArray[c1.x, c1.y].Text = GetRandomShape();
                //buttonArray[c1.x, c1.y].BackColor = GetRandomColor();
                //buttonArray[c2.x, c2.y].Text = GetRandomShape();
                //buttonArray[c2.x, c2.y].BackColor = GetRandomColor();
                //buttonArray[c3.x, c3.y].Text = GetRandomShape();
                //buttonArray[c3.x, c3.y].BackColor = GetRandomColor();
              
            }
            if (SettingsUser.Default.User_rBtnNormal) // Normal board
            {
                buttonArray = new Button[9, 9];
                int top = 0;
                int left = 0;
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        buttonArray[i, j] = new Button();
                        buttonArray[i, j].BackColor = Color.AliceBlue;
                        buttonArray[i, j].Width = 50;
                        buttonArray[i, j].Height = 50;
                        buttonArray[i, j].Left = left;
                        buttonArray[i, j].Top = top;
                        buttonArray[i, j].Click += new EventHandler(game);
                        this.Controls.Add(buttonArray[i, j]);
                        left += 50;
                    }
                    top += 50;
                    left = 0;
                }
                int controlnorm = 0;
                while (controlnorm != 3)
                {

                    Coordinate c1 = RandomCoordinate(9, 9);
                    if (buttonArray[c1.x, c1.y].BackColor == Color.AliceBlue)
                    {
                        controlnorm++;
                        buttonArray[c1.x, c1.y].Text = GetRandomShape();
                        buttonArray[c1.x, c1.y].BackColor = GetRandomColor();
                    }
                }
                //Coordinate c1 = RandomCoordinate(9, 9);
                //Coordinate c2 = RandomCoordinate(9, 9);
                //Coordinate c3 = RandomCoordinate(9, 9);
                //buttonArray[c1.x, c1.y].Text = GetRandomShape();
                //buttonArray[c1.x, c1.y].BackColor = GetRandomColor();
                //buttonArray[c2.x, c2.y].Text = GetRandomShape();
                //buttonArray[c2.x, c2.y].BackColor = GetRandomColor();
                //buttonArray[c3.x, c3.y].Text = GetRandomShape();
                //buttonArray[c3.x, c3.y].BackColor = GetRandomColor();
            }
            if (SettingsUser.Default.User_rBtnHard) //Hard Board
            {
                //int allButtons = 36;
                //int selectedButtons = 0;
                Size = new Size(318, 343); //en boy
                buttonArray = new Button[6, 6];
                int top = 0;
                int left = 0;
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        buttonArray[i, j] = new Button();
                        buttonArray[i, j].BackColor = Color.AliceBlue;
                        buttonArray[i, j].Width = 50;
                        buttonArray[i, j].Height = 50;
                        buttonArray[i, j].Left = left;
                        buttonArray[i, j].Top = top;
                        buttonArray[i, j].Click += new EventHandler(game);
                        this.Controls.Add(buttonArray[i, j]);
                        left += 50;
                    }
                    top += 50;
                    left = 0;
                }

                int controlhard = 0;
                while (controlhard != 3)
                {

                    Coordinate c1 = RandomCoordinate(6, 6);
                    if (buttonArray[c1.x, c1.y].BackColor == Color.AliceBlue)
                    {
                        controlhard++;
                        buttonArray[c1.x, c1.y].Text = GetRandomShape();
                        buttonArray[c1.x, c1.y].BackColor = GetRandomColor();
                    }
                    //for (int i = 0; i < 6; i++)
                    //{
                    //    for (int j = 0; j < 6; j++)
                    //    {
                    //        if (buttonArray[i, j].BackColor != Color.AliceBlue)
                    //        {
                    //            selectedButtons++;
                    //        }
                    //    }
                    //}
                    //if (selectedButtons == allButtons)
                    //{
                    //    MessageBox.Show("GAME OVER");
                    //}
                }
                

                //    Coordinate c1 = RandomCoordinate(6, 6);
                //Coordinate c2 = RandomCoordinate(6, 6);
                //Coordinate c3 = RandomCoordinate(6, 6);
                //buttonArray[c1.x, c1.y].Text = GetRandomShape();
                //buttonArray[c1.x, c1.y].BackColor = GetRandomColor();
                //buttonArray[c2.x, c2.y].Text = GetRandomShape();
                //buttonArray[c2.x, c2.y].BackColor = GetRandomColor();
                //buttonArray[c3.x, c3.y].Text = GetRandomShape();
                //buttonArray[c3.x, c3.y].BackColor = GetRandomColor();
            }
            if (SettingsUser.Default.User_rBtnCustom) //Custom Board
            {
                Size = new Size(650, 650); //en boy
                buttonArray = new Button[SettingsUser.Default.User_diffCustomNum1, SettingsUser.Default.User_diffCustomNum2];
                int top = 0;
                int left = 0;
                for (int i = 0; i < SettingsUser.Default.User_diffCustomNum1; i++)
                {
                    for (int j = 0; j < SettingsUser.Default.User_diffCustomNum2; j++)
                    {
                        buttonArray[i, j] = new Button();
                        buttonArray[i, j].BackColor = Color.AliceBlue;
                        buttonArray[i, j].Width = 50;
                        buttonArray[i, j].Height = 50;
                        buttonArray[i, j].Left = left;
                        buttonArray[i, j].Top = top;
                        buttonArray[i, j].Click += new EventHandler(game);
                        this.Controls.Add(buttonArray[i, j]);
                        left += 50;
                    }
                    top += 50;
                    left = 0;
                }

                int controlcust= 0;
                while (controlcust != 3)
                {

                    Coordinate c1 = RandomCoordinate(9, 9);
                    if (buttonArray[c1.x, c1.y].BackColor == Color.AliceBlue)
                    {
                        controlcust++;
                        buttonArray[c1.x, c1.y].Text = GetRandomShape();
                        buttonArray[c1.x, c1.y].BackColor = GetRandomColor();
                    }
                }

                //Coordinate c1 = RandomCoordinate(SettingsUser.Default.User_diffCustomNum1, SettingsUser.Default.User_diffCustomNum2);
                //Coordinate c2 = RandomCoordinate(SettingsUser.Default.User_diffCustomNum1, SettingsUser.Default.User_diffCustomNum2);
                //Coordinate c3 = RandomCoordinate(SettingsUser.Default.User_diffCustomNum1, SettingsUser.Default.User_diffCustomNum2);
                //buttonArray[c1.x, c1.y].Text = GetRandomShape();
                //buttonArray[c1.x, c1.y].BackColor = GetRandomColor();
                //buttonArray[c2.x, c2.y].Text = GetRandomShape();
                //buttonArray[c2.x, c2.y].BackColor = GetRandomColor();
                //buttonArray[c3.x, c3.y].Text = GetRandomShape();
                //buttonArray[c3.x, c3.y].BackColor = GetRandomColor();
            }

        }

    }
}

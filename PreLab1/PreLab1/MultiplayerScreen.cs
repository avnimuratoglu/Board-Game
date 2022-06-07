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
using System.Reflection;
using System.Media;
using System.Drawing;
using System.Data.SqlClient;
using System.Data;
using PreLab1.SqlVariables;
using System.Net.Sockets;

namespace PreLab1
{
    public partial class MultiplayerScreen : Form
    {
        private static Random random = new Random();
        private bool clickTemp = false;
        private Color colorTemp;
        private string textTemp;
        private Button buttonTemp;
        private Button[,] buttonArray;
        private int[,] coordinate;
        private Coordinate coordFirst, coordLast;
        private int point = 0; //toplanan puan  easy-1 normal-3 hard-5 custom-2
        public bool pop = false; //patlama kontrol 

        private Socket socket;
        private BackgroundWorker MessageReceiver = new BackgroundWorker();
        private TcpListener server = null;
        private TcpClient client;

        public MultiplayerScreen(bool isHost, string ip = null)
        {
            InitializeComponent();
            MessageReceiver.DoWork += MessageReceiver_DoWork;
            CheckForIllegalCrossThreadCalls = false;

            if(isHost)
            {
                server = new TcpListener(System.Net.IPAddress.Any, 5571);
                server.Start();

                socket = server.AcceptSocket();
            }
            else
            {
                try
                {
                    client = new TcpClient(ip, 5571);
                    socket = client.Client;
                    MessageReceiver.RunWorkerAsync();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Close();
                }
            }
        }

        
        private void MessageReceiver_DoWork(object sender, DoWorkEventArgs e)
        {
            if (pop)
                return;
            FreezeBoard();
            lbl_Info.Text = "Not Your Turn!";
            ReceiveMove();
            lbl_Info.Text = "Your Turn!";
            if (!pop)
                UnfreezeBoard();        
        }


        void countAllButtons(int row, int column)
        {
            //Button btn = new Button();
            int numberOfAliceBllueButons = 0;

            foreach (Button buttons in buttonArray)
            {
                if (buttons.BackColor == Color.AliceBlue)
                    numberOfAliceBllueButons++;
            }
            if (numberOfAliceBllueButons < 3)
            {
                MessageBox.Show("THE GAME IS OVER!", "GAME OVER", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void FreezeBoard()
        {
            foreach(Button btn in buttonArray)
            {
                btn.Enabled = false;
            }
        }

        private void UnfreezeBoard()
        {
            foreach (Button btn in buttonArray)
            {
                btn.Enabled = true;
            }
        }
        void randomizeButton(int row, int column)
        {
            int control = 0;
            while (control != 3)
            {
                Coordinate c1 = RandomCoordinate(row, column);
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
        void popButtons(int row, int column, Button btn)
        {

            int counterOfButtons = 0;

            for (int i = 0; i < row; i++)
            {
                if (buttonArray[coordLast.x, i].BackColor == btn.BackColor && buttonArray[coordLast.x, i].Text == btn.Text)
                {
                    counterOfButtons++;

                    if (counterOfButtons >= 5)
                    {
                        pop = true;
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

            for (int j = 0; j < column; j++)
            {
                if (buttonArray[j, coordLast.y].BackColor == btn.BackColor && buttonArray[j, coordLast.y].Text == btn.Text)
                {
                    counterOfButtons++;
                    if (counterOfButtons >= 5)
                    {
                        pop = true;
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
        }
        void SqlUpdateScore(int point)
        {
            SQL.CheckConnection(SQL.connectionUsers);

            int score = 0;
            try
            {
                SqlCommand commandScore = new SqlCommand("Select Score from Users_Table where UserName=@username", SQL.connectionUsers);
                commandScore.Parameters.AddWithValue("@username", LoginScreen.UserName);
                score = (int)commandScore.ExecuteScalar();
                SQL.connectionUsers.Close();

            }
            catch (Exception e)
            {
                score = 0;
            }

            if (score < point)
            {
                SqlCommand commandUpdate = new SqlCommand("Update Users_Table set Score=@score where UserName=@username", SQL.connectionUsers);

                commandUpdate.Parameters.AddWithValue("@username", LoginScreen.UserName);
                commandUpdate.Parameters.AddWithValue("@score", point);
                commandUpdate.ExecuteNonQuery();
                SQL.connectionUsers.Close();

            }
        }
        private void playSound()
        {
            //string fileName = "Run.wav";
            //findPath(fileName);
            SoundPlayer play = new SoundPlayer(@"C:\Users\Sevval Kolaca\Desktop\oop lab\sql son\sonsonyedek\PreLab1\PreLab1\Run.wav");
            //play.Load();
            play.Play();
        }
        int findMaxScore()
        {
            SQL.CheckConnection(SQL.connectionUsers);
            SqlCommand commandMax = new SqlCommand("Select Max(Score) from Users_Table", SQL.connectionUsers);
            int maxScore = (int)commandMax.ExecuteScalar();
            SQL.connectionUsers.Close();

            return maxScore;
        }

        Coordinate findIndex(Button btn)
        {

            coordinate = new int[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (buttonArray[i, j].Location == btn.Location)
                        return new Coordinate(i, j);
                }
            }
            return new Coordinate(-1, -1);
        }
        public void game(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //int counterOfButtons = 0;

            if (clickTemp == false && btn.BackColor != Color.AliceBlue)
            {
                colorTemp = btn.BackColor;
                textTemp = btn.Text;
                buttonTemp = btn;
                coordFirst = findIndex(btn);

                if (btn.BackColor == Color.Blue)
                    btn.BackColor = Color.SlateBlue;

                if (btn.BackColor == Color.Red)
                    btn.BackColor = Color.Salmon;

                if (btn.BackColor == Color.Yellow)
                    btn.BackColor = Color.Khaki;

                //MessageBox.Show("Buradan");
                clickTemp = true;

            }
            else if (clickTemp == true && btn.BackColor == Color.AliceBlue)
            {
                btn.BackColor = colorTemp;
                btn.Text = textTemp;
                buttonTemp.BackColor = Color.AliceBlue;
                buttonTemp.Text = "";
                coordLast = findIndex(btn);

                //MessageBox.Show("Buraya");
                clickTemp = false;

                int a = 0, b = 0;

                //tablo boyutu icin
                if (SettingsUser.Default.User_rBtnEasy)
                {
                    a = 15;
                    b = 15;
                    //allButtons = a * b;
                }
                else if (SettingsUser.Default.User_rBtnNormal)
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
                else if (SettingsUser.Default.User_rBtnCustom)
                {
                    a = SettingsUser.Default.User_diffCustomNum1;
                    b = SettingsUser.Default.User_diffCustomNum2;
                    //allButtons = a * b;
                }

                //BUTON PATLATMA 
                popButtons(a, b, btn);

                if (pop == true)
                {
                    //puanlama
                    if (SettingsUser.Default.User_rBtnEasy)
                    {
                        point += 1;
                        playSound();
                        SqlUpdateScore(point);
                        lbl_maxScoreInfo.Text = findMaxScore().ToString();
                        lblScore.Text = point.ToString();
                    }
                    else if (SettingsUser.Default.User_rBtnNormal)
                    {
                        point += 3;
                        playSound();
                        SqlUpdateScore(point);
                        lbl_maxScoreInfo.Text = findMaxScore().ToString();
                        lblScore.Text = point.ToString();
                    }
                    else if (SettingsUser.Default.User_rBtnHard)
                    {
                        point += 5;
                        playSound();
                        SqlUpdateScore(point);
                        lbl_maxScoreInfo.Text = findMaxScore().ToString();
                        lblScore.Text = point.ToString();
                    }
                    else if (SettingsUser.Default.User_rBtnCustom)
                    {
                        point += 2;
                        playSound();
                        SqlUpdateScore(point);
                        lbl_maxScoreInfo.Text = findMaxScore().ToString();
                        lblScore.Text = point.ToString();
                    }
                    pop = false;
                }
                else
                {
                    randomizeButton(a, b);
                    popButtons(a, b, btn);
                }

                //popButtons(a, b, btn);
                countAllButtons(a, b); ////////////////////// end game control //////////////////////
            }
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

            foreach (Color color in colors)
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


        private void ReceiveMove()
        {
            byte[] buffer = new byte[1];
            socket.Receive(buffer);
        }

        private void MultiplayerScreen_Load(object sender, EventArgs e)
        {
            Size = new Size(630, 500); //en boy
            buttonArray = new Button[9, 9];
            panel.Location = new Point(9 * 50, 50);
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
            int control = 0;
            while (control != 3)
            {
                int x = random.Next(0, 9);
                int y = random.Next(0, 9);
               
                Coordinate c1 = RandomCoordinate(x, y);
                if (buttonArray[c1.x, c1.y].BackColor == Color.AliceBlue)
                {
                    control++;
                    buttonArray[c1.x, c1.y].Text = GetRandomShape();
                    buttonArray[c1.x, c1.y].BackColor = GetRandomColor();
                }

            }
        }
    }
}

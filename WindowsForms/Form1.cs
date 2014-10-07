using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void AITurn()
        {
            Random random = new Random();
            int boxNumber = 0;
            if (emptyBox[5] == 1)
            {
                boxNumber = 5;
            }
            else
            {
                while (emptyBox[boxNumber] > 1 && emptyBox[0] < 10)
                {
                    boxNumber = random.Next(1, 9);
                }

            }

            switch (boxNumber)
            {
                case (1):
                    pictureBox1.Image = Image.FromFile(oPath);
                    emptyBox[boxNumber] = 3;
                    emptyBox[0]++;
                    break;
                case (2):
                    pictureBox2.Image = Image.FromFile(oPath);
                    emptyBox[boxNumber] = 3;
                    emptyBox[0]++;
                    break;
                case (3):
                    pictureBox3.Image = Image.FromFile(oPath);
                    emptyBox[boxNumber] = 3;
                    emptyBox[0]++;
                    break;
                case (4):
                    pictureBox4.Image = Image.FromFile(oPath);
                    emptyBox[boxNumber] = 3;
                    emptyBox[0]++;
                    break;
                case (5):
                    pictureBox5.Image = Image.FromFile(oPath);
                    emptyBox[boxNumber] = 3;
                    emptyBox[0]++;
                    break;
                case (6):
                    pictureBox6.Image = Image.FromFile(oPath);
                    emptyBox[boxNumber] = 3;
                    emptyBox[0]++;
                    break;
                case (7):
                    pictureBox7.Image = Image.FromFile(oPath);
                    emptyBox[boxNumber] = 3;
                    emptyBox[0]++;
                    break;
                case (8):
                    pictureBox8.Image = Image.FromFile(oPath);
                    emptyBox[boxNumber] = 3;
                    emptyBox[0]++;
                    break;
                case (9):
                    pictureBox9.Image = Image.FromFile(oPath);
                    emptyBox[boxNumber] = 3;
                    emptyBox[0]++;
                    break;
                default:
                    break;
            }
        }

        public static int[] emptyBox = new int[10] { 2, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        // 1 - true, 2 - crosses, 3 - naughts, first number is for turn counter
        public static int[,] winningLane = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 1, 4, 6 }, { 2, 5, 7 }, { 3, 6, 9 }, { 1, 5, 8 }, { 3, 5, 6 } };
        public static string oPath = Path.Combine(System.IO.Directory.GetCurrentDirectory(), "O.png");
        public static string xPath = Path.Combine(System.IO.Directory.GetCurrentDirectory(), "X.png");
        //public static string oPath = ("http://cs616625.vk.me/v616625282/aff5/NQHFmJ6HgCc.jpg");
        //public static string xPath = ("http://cs616625.vk.me/v616625282/afee/Al_jAAGmWjI.jpg");


        private void Form1_Load(object sender, EventArgs e)
        {
            //string path = System.IO.Directory.GetCurrentDirectory();
            //var oPath = Path.Combine(System.IO.Directory.GetCurrentDirectory(), "O.png");
            //var xPath = Path.Combine(System.IO.Directory.GetCurrentDirectory(), "X.png");


            /*pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            Image image = Image.FromFile("C:/Users/Алина/Downloads/O.png");
            pictureBox1.Image = image;
            pictureBox1.Height = image.Height;
            pictureBox1.Width = image.Width;*/
        }

        public int almostWin(int player) //2 - crosses, 3 - naughts
        {
            int total = 0;
            for (int combination = 0; combination <= 7; combination++)
            {
                for (int positionToExclude = 0; positionToExclude <= 2; positionToExclude++)
                {
                    for (int position = 0; position <= 2; position++)
                    {
                        if (position != positionToExclude)
                        {
                            total = total + emptyBox[winningLane[combination, position]];
                        }
                        total = total + player;
                        if (total == 6 || total ==9)
                        {
                            return combination;
                            //emptyBox empty value is need to be "0" instead of "1" beceuae of 1+2+3 case
                        }
                        total = 0;
                    }
                }
            }
            return 10;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (emptyBox[1] == 1)
            {
                pictureBox1.Image = Image.FromFile(xPath);
                emptyBox[1] = 2;
                emptyBox[0]++;
                AITurn();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (emptyBox[2] == 1)
            {
                pictureBox2.Image = Image.FromFile(xPath);
                emptyBox[2] = 2;
                emptyBox[0]++;
                AITurn();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (emptyBox[3] == 1)
            {
                pictureBox3.Image = Image.FromFile(xPath);
                emptyBox[3] = 2;
                emptyBox[0]++;
                AITurn();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (emptyBox[4] == 1)
            {
                pictureBox4.Image = Image.FromFile(xPath);
                emptyBox[4] = 2;
                emptyBox[0]++;
                AITurn();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (emptyBox[5] == 1)
            {
                pictureBox5.Image = Image.FromFile(xPath);
                emptyBox[5] = 2;
                emptyBox[0]++;
                AITurn();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (emptyBox[6] == 1)
            {
                pictureBox6.Image = Image.FromFile(xPath);
                emptyBox[6] = 2;
                emptyBox[0]++;
                AITurn();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (emptyBox[7] == 1)
            {
                pictureBox7.Image = Image.FromFile(xPath);
                emptyBox[7] = 2;
                emptyBox[0]++;
                AITurn();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (emptyBox[8] == 1)
            {
                pictureBox8.Image = Image.FromFile(xPath);
                emptyBox[8] = 2;
                emptyBox[0]++;
                AITurn();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (emptyBox[9] == 1)
            {
                pictureBox9.Image = Image.FromFile(xPath);
                emptyBox[9] = 2;
                emptyBox[0]++;
                AITurn();
            }
        }
    }
}

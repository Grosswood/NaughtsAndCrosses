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

        public void AITrun()
        {
            Random random = new Random();
            int boxNumber = 9;
            while (emptyBox[boxNumber] > 1 && emptyBox[9] < 10)
            {
                boxNumber = random.Next(0, 8);
            }

            switch (boxNumber)
            {
                case (0):
                    pictureBox1.Image = Image.FromFile(oPath);
                    emptyBox[boxNumber] = 3;
                    emptyBox[9]++;
                    break;
                case (1):
                    pictureBox2.Image = Image.FromFile(oPath);
                    emptyBox[boxNumber] = 3;
                    emptyBox[9]++;
                    break;
                case (2):
                    pictureBox3.Image = Image.FromFile(oPath);
                    emptyBox[boxNumber] = 3;
                    emptyBox[9]++;
                    break;
                case (3):
                    pictureBox4.Image = Image.FromFile(oPath);
                    emptyBox[boxNumber] = 3;
                    emptyBox[9]++;
                    break;
                case (4):
                    pictureBox5.Image = Image.FromFile(oPath);
                    emptyBox[boxNumber] = 3;
                    emptyBox[9]++;
                    break;
                case (5):
                    pictureBox6.Image = Image.FromFile(oPath);
                    emptyBox[boxNumber] = 3;
                    emptyBox[9]++;
                    break;
                case (6):
                    pictureBox7.Image = Image.FromFile(oPath);
                    emptyBox[boxNumber] = 3;
                    emptyBox[9]++;
                    break;
                case (7):
                    pictureBox8.Image = Image.FromFile(oPath);
                    emptyBox[boxNumber] = 3;
                    emptyBox[9]++;
                    break;
                case (8):
                    pictureBox9.Image = Image.FromFile(oPath);
                    emptyBox[boxNumber] = 3;
                    emptyBox[9]++;
                    break;
                default:
                    break;
            }
        }

        public static short[] emptyBox = new short[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 2 };
        // 1 - true, 2 - crosses, 3 - naughts, last number is for turn counter
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



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (emptyBox[0] == 1)
            {
                pictureBox1.Image = Image.FromFile(xPath);
                emptyBox[0] = 2;
                emptyBox[9]++;
                AITrun();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (emptyBox[1] == 1)
            {
                pictureBox2.Image = Image.FromFile(xPath);
                emptyBox[1] = 2;
                emptyBox[9]++;
                AITrun();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (emptyBox[2] == 1)
            {
                pictureBox3.Image = Image.FromFile(xPath);
                emptyBox[2] = 2;
                emptyBox[9]++;
                AITrun();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (emptyBox[3] == 1)
            {
                pictureBox4.Image = Image.FromFile(xPath);
                emptyBox[3] = 2;
                emptyBox[9]++;
                AITrun();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (emptyBox[4] == 1)
            {
                pictureBox5.Image = Image.FromFile(xPath);
                emptyBox[4] = 2;
                emptyBox[9]++;
                AITrun();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (emptyBox[5] == 1)
            {
                pictureBox6.Image = Image.FromFile(xPath);
                emptyBox[5] = 2;
                emptyBox[9]++;
                AITrun();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (emptyBox[6] == 1)
            {
                pictureBox7.Image = Image.FromFile(xPath);
                emptyBox[6] = 2;
                emptyBox[9]++;
                AITrun();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (emptyBox[7] == 1)
            {
                pictureBox8.Image = Image.FromFile(xPath);
                emptyBox[7] = 2;
                emptyBox[9]++;
                AITrun();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (emptyBox[8] == 1)
            {
                pictureBox9.Image = Image.FromFile(xPath);
                emptyBox[8] = 2;
                emptyBox[9]++;
                AITrun();
            }
        }
    }
}

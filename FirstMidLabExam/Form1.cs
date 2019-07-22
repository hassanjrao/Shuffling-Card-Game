using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstMidLabExam
{
    public partial class Form1 : Form
    {
        int c = 0;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.ImageLocation = "D:\\Lab Exam Files\\Ace.png";
            label2.Text = "";
        }

        public void cardSuffle()
        {

            Random r = new Random();
            c = r.Next(1, 12);
            
            if (c == 1)
            {
                pictureBox1.ImageLocation = "D:\\Lab Exam Files\\Ace.png";

            }
            if (c == 2)
            {
                pictureBox1.ImageLocation = "D:\\Lab Exam Files\\jack.png";
            }
            if (c == 3)
            {
                pictureBox1.ImageLocation = "D:\\Lab Exam Files\\king.png";
            }
            if (c == 4)
            {
                pictureBox1.ImageLocation = "D:\\Lab Exam Files\\two.png";

            }
            if (c == 5)
            {
                pictureBox1.ImageLocation = "D:\\Lab Exam Files\\three.png";
            }
            if (c == 6)
            {
                pictureBox1.ImageLocation = "D:\\Lab Exam Files\\four.png";
            }
            if (c == 7)
            {
                pictureBox1.ImageLocation = "D:\\Lab Exam Files\\five.png";

            }
            if (c == 8)
            {
                pictureBox1.ImageLocation = "D:\\Lab Exam Files\\six.png";
            }
            if (c == 9)
            {
                pictureBox1.ImageLocation = "D:\\Lab Exam Files\\seven.png";
                
            }
            if (c == 9)
            {
                pictureBox1.ImageLocation = "D:\\Lab Exam Files\\queen.png";
                
            }
            if (c == 10)
            {
                pictureBox1.ImageLocation = "D:\\Lab Exam Files\\nine.png";

            }
            if (c == 11)
            {
                pictureBox1.ImageLocation = "D:\\Lab Exam Files\\eight.png";
                c = 0;
            }







        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cardSuffle();
        }

        int score = 0;
        public void evenCard()
        {
            
            if (pictureBox1.ImageLocation.Equals("D:\\Lab Exam Files\\four.png") || pictureBox1.ImageLocation.Equals("D:\\Lab Exam Files\\two.png") || pictureBox1.ImageLocation.Equals("D:\\Lab Exam Files\\eight.png") || pictureBox1.ImageLocation.Equals("D:\\Lab Exam Files\\six.png"))
            {

                MessageBox.Show("You Won");
                if (score == 0)
                {
                    score += 100;
                    label2.Text = Convert.ToString(score);

                }
                else
                {
                    score += 100;
                    label2.Text = Convert.ToString(score);

                }

            }
            else
            {
                MessageBox.Show("You Lose");
                if (score == 0)
                {
                    score -= 100;
                    label2.Text = Convert.ToString(score);

                }
                else
                {
                    score -= 100;
                    label2.Text = Convert.ToString(score);

                }

            }

        }

        public void oddCard()
        {
            if (pictureBox1.ImageLocation.Equals("D:\\Lab Exam Files\\three.png") || pictureBox1.ImageLocation.Equals("D:\\Lab Exam Files\\five.png") || pictureBox1.ImageLocation.Equals("D:\\Lab Exam Files\\seven.png") || pictureBox1.ImageLocation.Equals("D:\\Lab Exam Files\\nine.png") || pictureBox1.ImageLocation.Equals("D:\\Lab Exam Files\\Ace.png"))
            {
                MessageBox.Show("You Won");
                if (score == 0)
                {
                    score += 100;
                    label2.Text = Convert.ToString(score);

                }
                else
                {
                    score += 100;
                    label2.Text = Convert.ToString(score);

                }

            }
            else
            {
                MessageBox.Show("You Lose");
                if (score == 0)
                {
                    score -= 100;
                    label2.Text = Convert.ToString(score);

                }
                else
                {
                    score -= 100;
                    label2.Text = Convert.ToString(score);

                }
            }
        }

        public void faceCard()
        {
            if (pictureBox1.ImageLocation.Equals("D:\\Lab Exam Files\\king.png") || pictureBox1.ImageLocation.Equals("D:\\Lab Exam Files\\jack.png") || pictureBox1.ImageLocation.Equals("D:\\Lab Exam Files\\queen.png"))
            {
                MessageBox.Show("You Won");
                if (score == 0)
                {
                    score += 100;
                    label2.Text = Convert.ToString(score);

                }
                else
                {
                    score += 100;
                    label2.Text = Convert.ToString(score);

                }
            }
            else
            {
                MessageBox.Show("You Lose");
                if (score == 0)
                {
                    score -= 100;
                    label2.Text = Convert.ToString(score);

                }
                else
                {
                    score -= 100;
                    label2.Text = Convert.ToString(score);

                }
            }
        }
    

        
        private void btnStops_Click(object sender, EventArgs e)
        {
            
            
            timer1.Stop();

            if (checkBoxEven.Checked)
            {
                evenCard();
            }

                
            else if (checkBoxOdd.Checked)
            {
                oddCard();
            }

            else if (checkBoxFace.Checked)
            {
                faceCard();
            }


        }

        private void checkBoxEven_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEven.Checked == true)
            {
                checkBoxOdd.Checked = false;
                checkBoxFace.Checked = false;
            }

            
        }

        private void checkBoxOdd_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOdd.Checked == true)
            {
                checkBoxEven.Checked = false;
                checkBoxFace.Checked = false;
            }
            
        }

        private void checkBoxFace_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFace.Checked == true)
            {
                checkBoxEven.Checked = false;
                checkBoxOdd.Checked = false;
            }
            
        }
    }
}

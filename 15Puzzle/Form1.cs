using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _15Puzzle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PuzzleButton7_Click(object sender, EventArgs e)
        {
            doClick(6);
        }

        private void PuzzleButton15_Click(object sender, EventArgs e)
        {
            doClick(14);
        }

        private void PuzzleButton14_Click(object sender, EventArgs e)
        {
            doClick(13);
        }

        private void PuzzleButton13_Click(object sender, EventArgs e)
        {
            doClick(12);
        }

        private void PuzzleButton9_Click(object sender, EventArgs e)
        {
            doClick(8);
        }

        private void PuzzleButton10_Click(object sender, EventArgs e)
        {
            doClick(9);
        }

        private void PuzzleButton11_Click(object sender, EventArgs e)
        {
            doClick(10);
        }

        private void PuzzleButton12_Click(object sender, EventArgs e)
        {
            doClick(11);
        }

        private void PuzzleButton8_Click(object sender, EventArgs e)
        {
            doClick(7);
        }

        private void PuzzleButton16_Click(object sender, EventArgs e)
        {
            doClick(15);
        }

        private void PuzzleButton6_Click(object sender, EventArgs e)
        {
            doClick(5);
        }

        private void PuzzleButton5_Click(object sender, EventArgs e)
        {
            doClick(4);
        }

        private void PuzzleButton1_Click(object sender, EventArgs e)
        {
            doClick(0);
        }

        private void PuzzleButton2_Click(object sender, EventArgs e)
        {
            doClick(1);
        }

        private void PuzzleButton3_Click(object sender, EventArgs e)
        {
            doClick(2);
        }

        private void PuzzleButton4_Click(object sender, EventArgs e)
        {
            doClick(3);
        }

        private void doClick(int currentIndex)
        {
            List<Infragistics.Win.Misc.UltraButton> buttonList = new List<Infragistics.Win.Misc.UltraButton>();
            buttonList.Add(PuzzleButton1);
            buttonList.Add(PuzzleButton2);
            buttonList.Add(PuzzleButton3);
            buttonList.Add(PuzzleButton4);
            buttonList.Add(PuzzleButton5);
            buttonList.Add(PuzzleButton6);
            buttonList.Add(PuzzleButton7);
            buttonList.Add(PuzzleButton8);
            buttonList.Add(PuzzleButton9);
            buttonList.Add(PuzzleButton10);
            buttonList.Add(PuzzleButton11);
            buttonList.Add(PuzzleButton12);
            buttonList.Add(PuzzleButton13);
            buttonList.Add(PuzzleButton14);
            buttonList.Add(PuzzleButton15);
            buttonList.Add(PuzzleButton16);

            if (currentIndex + 1 <= 15 && !((currentIndex + 1) % 4 == 0))
            {
                if (buttonList[currentIndex + 1].Text == " ")
                {
                    buttonList[currentIndex + 1].Text = buttonList[currentIndex].Text;
                    buttonList[currentIndex].Text = " ";
                }
            }
            if (currentIndex - 1 >= 0 && !((currentIndex) % 4 == 0))
            {
                if (buttonList[currentIndex - 1].Text == " ")
                {
                    buttonList[currentIndex - 1].Text = buttonList[currentIndex].Text;
                    buttonList[currentIndex].Text = " ";
                }
            }
            if (currentIndex - 4 >= 0)
            {
                if (buttonList[currentIndex - 4].Text == " ")
                {
                    buttonList[currentIndex - 4].Text = buttonList[currentIndex].Text;
                    buttonList[currentIndex].Text = " ";
                }
            }
            if (currentIndex + 4 <= 15)
            {
                if (buttonList[currentIndex + 4].Text == " ")
                {
                    buttonList[currentIndex + 4].Text = buttonList[currentIndex].Text;
                    buttonList[currentIndex].Text = " ";
                }
            }

           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < 100000; i++)
            {
                doClick(r.Next(16));
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < 100000; i++)
            {
                doClick(r.Next(16));
            }
        }

    }
}

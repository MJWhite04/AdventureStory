using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace AdventureStory
{
    
    public partial class Form1 : Form
    {
        //Starting Page
        int page = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            outputLabel.Text = "Welcome";
            option1Label.Text = "...";
            option2Label.Text = "...";
            option3Label.Text = "...";
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            //Check what page we are on, then flip to the next page in the squence

            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 99;
            }
            else if (page == 3)
            {
                page = 5;
            }
            else if (page == 5)
            {
                page = 6;
            }
            else if (page == 6)
            {
                page = 99;
            }
            else if (page == 4)
            {
                page = 99;
            }
            else if (page == 8)
            {
                page = 9;
            }
            else if (page == 9)
            {
                page = 11;
            }
            else if (page == 11)
            {
                page = 13;
            }
            else if (page == 13)
            {
                page = 100;
            }
            DisplayPage();
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            //Checks to see what page it is on then flips to the next page
            if (page == 1)
            {
                page = 99;
            }
            else if (page == 2)
            {
                page = 3;
            }
            else if (page == 3)
            {
                page = 4;
            }
            else if (page == 4)
            {
                page = 6;
            }
            else if (page == 8)
            {
                page = 99;
            }
            else if (page == 9)
            {
                page = 10;
            }
            else if (page == 11)
            {
                page = 6;
            }
            DisplayPage();
        }

        private void option3Button_Click(object sender, EventArgs e)
        {
            if (page == 2)
            {
                page = 99;
            }
            else if (page == 5)
            {
                page = 4;
            }
            else if (page == 4)
            {
                page = 8;
            }
            else if (page == 8)
            {
                page = 99;
            }
            else if (page == 9)
            {
                page = 10;
            }
            else if (page == 11)
            {
                page = 14;
            }
            else if (page == 14)
            {
                page = 99;
            }
            DisplayPage();
        }
        private void DisplayPage()
        {
            //All the case statements(shows whats on the screen)
            switch (page)
            {
                case 1:
                    outputLabel.Text = "You are Trapped, Play Game?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "...";
                    break;
                case 2:
                    outputLabel.Text = "Level 1: What country has the largest land mass";
                    option1Label.Text = "Canada";
                    option2Label.Text = "Russia";
                    option3Label.Text = "USA";
                    break;
                case 3:
                    outputLabel.Text = "Beat level 1/3";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "...";
                    break;
                case 4:
                    outputLabel.Text = "You hear something in the woods what do you do?";
                    option1Label.Text = "Investigate";
                    option2Label.Text = "Run";
                    option3Label.Text = "Go in castle";
                    break;
                case 5:
                    outputLabel.Text = "You are thirsty, Take a Drink?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "...";
                    break;
                case 6:
                    outputLabel.Text = "Water was infected and you died.";
                    option1Label.Text = "...";
                    option2Label.Text = "...";
                    option3Label.Text = "...";
                    break;
                case 7:
                    outputLabel.Text = "It was a bear and you died.";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "...";
                    break;
                case 8:
                    outputLabel.Text = "You are faced with level 2. ?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "...";
                    break;
                case 9:
                    outputLabel.Text = "Level 2 complete";
                    option1Label.Text = "...";
                    option2Label.Text = "...";
                    option3Label.Text = "...";
                    break;
                case 10:
                    outputLabel.Text = "Level 2 complete";
                    option1Label.Text = "...";
                    option2Label.Text = "...";
                    option3Label.Text = "...";
                    break;
                case 11:
                    outputLabel.Text = "Level 2 complete";
                    option1Label.Text = "...";
                    option2Label.Text = "...";
                    option3Label.Text = "...";
                    break;
                case 13:
                    outputLabel.Text = "Level 2 complete";
                    option1Label.Text = "...";
                    option2Label.Text = "...";
                    option3Label.Text = "...";
                    break;
                case 14:
                    outputLabel.Text = "Level 2 complete";
                    option1Label.Text = "...";
                    option2Label.Text = "...";
                    option3Label.Text = "...";
                    break;
                case 99:
                    outputLabel.Text = "Wrong Choice. Play Again";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "...";
                    break;
                case 100:
                    outputLabel.Text = "Thanks for Playing";
                    option1Label.Text = "...";
                    option2Label.Text = "...";
                    option3Label.Text = "...";
                    break;
                default:
                    break;
            }
        }
    }
}

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
        //Starting page number
        int page = 0;

        //code for generating random number
        Random randgen = new Random();

        //code for sound
        SoundPlayer ScarySound = new SoundPlayer(Properties.Resources.Scary_Sound);
        SoundPlayer BearGrowl = new SoundPlayer(Properties.Resources.Bear_Growl);
        SoundPlayer Thinking = new SoundPlayer(Properties.Resources.Thinking);
        SoundPlayer RollDice = new SoundPlayer(Properties.Resources.Roll_Dice);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Starting Page
            outputLabel.Text = "Welcome";
            option1Label.Text = "Start";
            option2Label.Text = "Start";
            option3Label.Text = "Start";

            //Creates number for later on in the code
            int rando = randgen.Next(1, 101);
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            //Check what page we are on, then flip to the next page in the squence

            if (page == 0)
            {
                page = 1;
            }
            else if (page == 1)
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
                page = 7;
            }
            else if (page == 7)
            {
                page = 1;
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
            else if (page == 99)
            {
                page = 0;
            }
            DisplayPage();
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            //Checks to see what page it is on then flips to the next page

            if (page == 0)
            {
                page = 1;
            }
            else if (page == 1)
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
            else if (page == 7)
            {
                page = 100;
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
            else if (page == 99)
            {
                page = 100;
            }
            DisplayPage();
        }

        private void option3Button_Click(object sender, EventArgs e)
        {
            //Check what page we are on, then flip to the next page in the squence
            if (page == 0)
            {
                page = 1;
            }
            else if (page == 2)
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
            else if (page == 10)
            {
                //creates random number
                int rando = randgen.Next(1, 101);
                if (rando > 50)
                {
                    page = 100;
                }
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
                    ScarySound.Play();
                    outputLabel.Text = "You are Trapped, Play Game?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    break;
                case 2:
                    outputLabel.Text = "Muliple Choice.";
                    Refresh();
                    Thread.Sleep(1000);
                    Thinking.Play();
                    imageBox.Image = Properties.Resources.Map;
                    outputLabel.Text = "Level 1: What country has the largest land mass";
                    option1Label.Text = "Canada";
                    option2Label.Text = "Russia";
                    option3Label.Text = "USA";
                    break;
                case 3:
                    outputLabel.Text = "Beat level 1/3";
                    Refresh();
                    Thread.Sleep(1000);
                    imageBox.Image = Properties.Resources.Fork_in_the_road;
                    outputLabel.Text = "There is a fork in the road.";
                    option1Label.Text = "Right";
                    option2Label.Text = "Left";
                    option3Label.Text = "";
                    break;
                case 4:
                    BearGrowl.Play();
                    imageBox.Image = Properties.Resources.forest;
                    outputLabel.Text = "You hear something in the woods what do you do?";
                    option1Label.Text = "Investigate";
                    option2Label.Text = "Run";
                    option3Label.Text = "Go in castle";
                    break;
                case 5:
                    //imageBox.Image = Properties.Resources.
                    outputLabel.Text = "You find water, Take a Drink?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "";
                    option3Label.Text = "No";
                    break;
                case 6:
                    outputLabel.Text = "You took a drink of water.";
                    Refresh();
                    Thread.Sleep(750);
                    outputLabel.Text = "Water was infected and you died";
                    option1Label.Text = "Continue to play again";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    break;
                case 7:
                    imageBox.Image = Properties.Resources.Bear;
                    outputLabel.Text = "It was a bear and you died.";
                    Refresh();
                    Thread.Sleep(1000);
                    outputLabel.Text = "Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    break;
                case 8:
                    outputLabel.Text = "You are faced with level 2.";
                    Refresh();
                    Thread.Sleep(1000);
                    Thinking.Play();
                    imageBox.Image = Properties.Resources.Calendar;
                    outputLabel.Text = "How many Months have 28 Days?";
                    option1Label.Text = "All";
                    option2Label.Text = "February";
                    option3Label.Text = "July";
                    break;
                case 9:
                    outputLabel.Text = "Level 2 complete";
                    Refresh();
                    Thread.Sleep(1000);
                    imageBox.Image = Properties.Resources.Staircase;
                    outputLabel.Text = "Theres a stairwell, Go up or Down";
                    option1Label.Text = "Up";
                    option2Label.Text = "Down";
                    option3Label.Text = "";
                    break;
                case 10: 
                    outputLabel.Text = "You trip and fall down.";
                    Refresh();
                    Thread.Sleep(1000);
                    RollDice.Play();
                    outputLabel.Text = "Press your Luck";
                    option1Label.Text = "Roll";
                    option2Label.Text = "The";
                    option3Label.Text = "Dice.";
                    break;
                case 11:
                    outputLabel.Text = "You are faced with level 3.";
                    Refresh();
                    Thread.Sleep(1000);
                    Thinking.Play();
                    //imageBox.Image = Properties.Resources.
                    outputLabel.Text = "Pick an Item to escape";
                    option1Label.Text = "Parachute";
                    option2Label.Text = "Water";
                    option3Label.Text = "Rope";
                    break;
                case 13:
                    outputLabel.Text = "You Escaped!";
                    option1Label.Text = "Freedom";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    break;
                case 14:
                    imageBox.Image = Properties.Resources.Bear;
                    Refresh();
                    BearGrowl.Play();
                    outputLabel.Text = "You Rappel down the wall and find the bear.";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    option3Label.Text = "Play Again";
                    break;
                case 99:
                    outputLabel.Text = "Unfortunate, Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    break;
                case 100:
                    //imageBox.Image = Properties.Resources.
                    outputLabel.Text = "Thanks for playing";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    //Close program
                    Refresh();
                    Thread.Sleep(1000);
                    Close();
                    break;
                default:
                    break;

                   
            }
        }
    }
}

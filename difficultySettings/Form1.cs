/* 
 * Gurvir Uppal
 * Difficulty Settings 
 * May 3, 2021
 * Mr. T
 * ICS3U
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace difficultySettings
{




    public partial class background : Form
    {
        //Global Variables
        string herroName;
        string difficultyLevel;

        public background()
        {
            InitializeComponent();
        }

        private void easyButton_Click(object sender, EventArgs e)
        {

            easyButton.BackColor = Color.Green;     //set the button fore colour to green
            mediumButton.BackColor = Color.Black;
            hardButton.BackColor = Color.Black;

            difficultyLevel = "easy";          //set the global variable difficultyLevel to easy
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            easyButton.BackColor = Color.Black;
            mediumButton.BackColor = Color.Orange;          //set the button fore colour to orange 
            hardButton.BackColor = Color.Black;

            difficultyLevel = "medium";                 //set the global variable difficultyLevel to medium
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            easyButton.BackColor = Color.Black;
            mediumButton.BackColor = Color.Black;      
            hardButton.BackColor = Color.Red;            //set the button fore colour to red

            difficultyLevel = "hard";            //set the global variable difficultyLevel to hard
        }

        private void beginButton_Click(object sender, EventArgs e)
        {

            herroName = userInput.Text;

            namePrint.Text = $"Welcome {herroName}";  //print the welcome message

            outputText.Text = $"A True Brave Hero! Go Forth and Conquer the {difficultyLevel} path!!"; //print the goodbye message



        }


    }
}

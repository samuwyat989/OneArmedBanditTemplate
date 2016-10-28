using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace OneArmedBandit
{
    public partial class Form1 : Form
    {
        // random number generator
        Random randGen = new Random();
        // int value for score initialized to 10
        int score = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void spinButton_Click(object sender, EventArgs e) 
        {
            // get random values for each reel (store each in separate int variable)
            int reelValue1 = randGen.Next(1, 4);
            int reelValue2 = randGen.Next(1, 4);
            int reelValue3 = randGen.Next(1, 4);

            // check value of reel 1 with a switch statement and set appropriate image
            switch(reelValue1)
            {
                case 1:
                    reel1.Image = (Properties.Resources.cherry_100x125);
                    break;
                case 2:
                    reel1.Image = (Properties.Resources.diamond_100x125);
                    break;
                case 3:
                    reel1.Image = (Properties.Resources._7_100x125);
                    break;
            }

            // check value of reel 2 with a switch statement and set appropriate image

            switch (reelValue2)
            {
                case 1:
                    reel2.Image = (Properties.Resources.cherry_100x125);
                    break;
                case 2:
                    reel2.Image = (Properties.Resources.diamond_100x125);
                    break;
                case 3:
                    reel2.Image = (Properties.Resources._7_100x125);
                    break;
            }

            // check value of reel 3 with a switch statement and set appropriate image

            switch (reelValue3)
            {
                case 1:
                    reel3.Image = (Properties.Resources.cherry_100x125);
                    break;
                case 2:
                    reel3.Image = (Properties.Resources.diamond_100x125);
                    break;
                case 3:
                    reel3.Image = (Properties.Resources._7_100x125);
                    break;
            }

            /// STOP HERE ----------------------------------------------------------
            /// Test to make sure that your program will display random
            /// images to each reel. Only continue on after you know this works
            /// --------------------------------------------------------------------


            // Use compound if statement to check if all reels are equal. 
            // If yes show "winner" statement and add 3 to score.
            // If no show "play again" statement and subtract 1 from score. 

            if (reelValue1 == reelValue2 && reelValue2 == reelValue3)
            {
                outputLabel.Text = "Winner!";
                score = score + 3;
                scoreDisplay.Text = Convert.ToString(score);
            }
            else
            {
                outputLabel.Text = "Play Again.";
                score--;
                scoreDisplay.Text = Convert.ToString(score);
            }

            // if score has reached 0 display "lose" message and set button enabled property to false
            
            if(score == 0)
            {
                spinButton.Enabled = false;
                outputLabel.Text = "";
            }

            // display updated score

        }
    }
}

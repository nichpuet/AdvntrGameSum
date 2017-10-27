using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvntrGameSum
{
    public partial class Form1 : Form
    {
        int scene = 0;
        Random rand50 = new Random();
        Random rand25 = new Random();

        public Form1()
        {
            InitializeComponent();
            outputLabel.Enabled = false;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int randNum50 = rand50.Next(1, 3);
            int randNum25 = rand25.Next(1, 5);

            if (e.KeyCode == Keys.B)
            {
            }
            else if (e.KeyCode == Keys.R)
            {
            }
            else if (e.KeyCode == Keys.G)
            {
            }
            else if (e.KeyCode == Keys.Y)
            {
            }

            switch (scene)
            {
                case 1:
                    outputLabel.Text = "You come to an elevator. /n choose a floor.";
                    redLabel.Text = "Floor 3";
                    blueLabel.Text = " Floor 2";
                    greenLabel.Text = "Floor 4";
                    yellowLabel.Text = "Floor 5";
                    break;

                case 2:
                    outputLabel.Text = "You enter a breached room and are sucked out into space. \n Click on the white box to try again.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    yellowLabel.Text = "";
                    outputLabel.Enabled = true;
                    break;
                case 3:
                    outputLabel.Text = "You enter a control room. Do you become the captain?";
                    blueLabel.Text = "You are the \ncaptain now";
                    redLabel.Text = "Don't become the \ncaptain.";
                    greenLabel.Text = "";
                    yellowLabel.Text = "";
                    break;
                case 4:
                    outputLabel.Text = "You don't know how to fly a spaceship and the ship starts to collapse around you. You have died. \nClick white box to play again";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "";
                    yellowLabel.Text = "";
                    outputLabel.Enabled = true;
                    break;
                case 5:
                    outputLabel.Text = "You don't become the captain and notice a spare escape pod to your left. You have survived. \nClick white box to play again.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "";
                    yellowLabel.Text = "";
                    outputLabel.Enabled = true;
                    break;
                case 6:
                    outputLabel.Text = "You come out of the elevator to a long dark hallway. How do you proceed.";
                    blueLabel.Text = "Proceed Carefully";
                    redLabel.Text = "Run as fast as \nyou can";
                    greenLabel.Text = "";
                    yellowLabel.Text = "";
                    break;
                case 7:
                    outputLabel.Text = "You slowly make your way down the hallway, but are attacked by an alien lurking in the shadows! You have died. Click on the white box to restart.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "";
                    yellowLabel.Text = "";
                    outputLabel.Enabled = true;
                    break;
                case 8:
                    outputLabel.Text = "You run quickly down the hallway and notice an alien lurking behind you. You round the corner and enter a hangar with an unattended alien ship.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "";
                    yellowLabel.Text = "";
                    break;
                case 9:
                    if (randNum25 == 1)
                    {
                        outputLabel.Text = "You manage to start the alien ship and fly out into space surviving the encounter. You have survived. Click the white box to play again.";
                        blueLabel.Text = "";
                        redLabel.Text = "";
                        greenLabel.Text = "";
                        yellowLabel.Text = "";
                        outputLabel.Enabled = true;
                    }
                    else
                    {
                        outputLabel.Text = "You fail to start the ship and have alerted all the aliens on the ship!";
                        blueLabel.Text = "Hide behind some crates";
                        redLabel.Text = "Search the ship";
                        greenLabel.Text = "";
                        yellowLabel.Text = "";
                    }
                    break;
                case 10:
                    outputLabel.Text = "You get found by the aliens and they throw you out into space. You have died. \nClick on the white box to restart.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "";
                    yellowLabel.Text = "";
                    outputLabel.Enabled = true;
                    break;
                case 11:
                    outputLabel.Text = "You find one of the alien guns, time to stand your ground. Pick a target";
                    blueLabel.Text = "Alien 1";
                    redLabel.Text = "Alien 2";
                    greenLabel.Text = "Alien 3";
                    yellowLabel.Text = "";
                    break;
                case 12:
                    outputLabel.Text = "You take down the first alien, but start getting shot at by the second alien!";
                    if (randNum50 == 1)
                    {
                        outputLabel.Text = "You get hit by the second aliens shots. You have died. \nClick on the white box to try again.";
                        blueLabel.Text = "";
                        redLabel.Text = "";
                        greenLabel.Text = "";
                        yellowLabel.Text = "";
                        outputLabel.Enabled = true;
                    }
                    else
                    {
                        outputLabel.Text = "The second alien misses you! Pick a target.";
                        blueLabel.Text = "Alien 2";
                        redLabel.Text = "Alien 3";
                        greenLabel.Text = "";
                        yellowLabel.Text = "";
                    }
                    break;
                case 13:
                    outputLabel.Text = "You take a shot at the second alien but he takes the hit and fires back.";
                    if (randNum50 == 1)
                    {
                        outputLabel.Text = "You get hit by the second aliens shots. You have died. \nClick on the white box to try again.";
                        blueLabel.Text = "";
                        redLabel.Text = "";
                        greenLabel.Text = "";
                        yellowLabel.Text = "";
                        outputLabel.Enabled = true;
                    }
                    else
                    {
                        outputLabel.Text += "\nPick a target";
                        blueLabel.Text = "Alien 2";
                        redLabel.Text = "Alien 3";
                        greenLabel.Text = "";
                        yellowLabel.Text = "";
                    }
                    break;
                case 14:
                    outputLabel.Text = "You take the alien down with the second shot but the third one picks up its gun and takes a shot";
                    if (randNum50 == 1)
                    {
                        outputLabel.Text = "You get hit by the second aliens shots. You have died. \nClick on the white box to try again.";
                        blueLabel.Text = "";
                        redLabel.Text = "";
                        greenLabel.Text = "";
                        yellowLabel.Text = "";
                        outputLabel.Enabled = true;
                    }
                    else
                    {
                        outputLabel.Text = "You take out the last alien with ease and get the ship running. You have escaped. \nClick on the white box to try again.";
                        blueLabel.Text = "";
                        redLabel.Text = "";
                        greenLabel.Text = "";
                        yellowLabel.Text = "";
                        outputLabel.Enabled = true;
                    }
                        break;
                case 15:
                    outputLabel.Text = "You miss the second alien and get easily taken down by the first. You have died. \nClick on the white box to try again.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "";
                    yellowLabel.Text = "";
                    outputLabel.Enabled = true;
                    break;
                case 16:
                    outputLabel.Text = "Take down the third alien unnoticed. But for how long? Pick a target.";
                    blueLabel.Text = "Alien 1";
                    redLabel.Text = "Alien 2";
                    greenLabel.Text = "";
                    yellowLabel.Text = "";
                    break;
                case 17:
                    outputLabel.Text = "You come out of the label into the engineering bay. Try to find equipment and seal the breach?";
                    blueLabel.Text = "Yes";
                    redLabel.Text = "No";
                    greenLabel.Text = "";
                    yellowLabel.Text = "";
                    break;
                case 18:
                    if (randNum25 == 1)
                    {
                        outputLabel.Text = "You have successfully repaired the ship. You have survived. \nClick on the white box to play again.";
                        blueLabel.Text = "";
                        redLabel.Text = "";
                        greenLabel.Text = "";
                        yellowLabel.Text = "";
                        outputLabel.Enabled = true;
                    }
                    else
                    {
                        outputLabel.Text = "You have failed to repair the ship and are pulled out into space. You have died. \nClick on the white box to play again";
                        blueLabel.Text = "";
                        redLabel.Text = "";
                        greenLabel.Text = "";
                        yellowLabel.Text = "";
                        outputLabel.Enabled = true;
                    }
                    break;
                case 19:
                    outputLabel.Text = "You don't try to seal the breach and run down an empty hallway. You come across an empty alien ship.";
                    break;
            }
        }

        private void outputLabel_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "";
            blueLabel.Text = "Go to the /nright room";
            redLabel.Text = "Go to the /nleft room";
        }
    }
}

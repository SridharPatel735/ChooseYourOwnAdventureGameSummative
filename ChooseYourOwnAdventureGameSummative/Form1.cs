using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ChooseYourOwnAdventureGameSummative
{
    public partial class Form1 : Form
    {

        Random randGen = new Random();
        int scene = 0;
        int percent;

        public Form1()
        {
            InitializeComponent();
            outputLabel.Text = "You find yourself at the edge of a forest. You hear a noise inside the forest. " +
                        "On the other side of the forest is a road.";
            bOutputLabel.Text = "Go to the forest.";
            mOutputLabel.Text = "Go to the road.";
            scoreLabel.Text = "" + scene;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.M)       //red button press
            {
                if (scene == 0) { scene = 11; }
                else if (scene == 1)
                {
                    percent = randGen.Next(0, 101);
                    if (percent >= 50) { scene = 2; }
                    else { scene = 3; }
                }
                else if (scene == 2) { scene = 0; }
                else if (scene == 3)
                {
                    percent = randGen.Next(0, 101);
                    if (percent >= 25) { scene = 4; }
                    else { scene = 5; }
                }
                else if (scene == 4) { scene = 0; }
                else if (scene == 5) { scene = 8; }
                else if (scene == 6) { scene = 0; }
                else if (scene == 8)
                {
                    percent = randGen.Next(0, 101);
                    if (percent >= 10) { scene = 9; }
                    else { scene = 0; }
                }
                else if (scene == 9) { scene = 0; }
                else if (scene == 10) { scene = 0; }
                else if (scene == 11) { scene = 12; }
                else if (scene == 12) { scene = 13; }
                else if (scene == 13) { scene = 0; }
                else if (scene == 14) { scene = 13; }
                else if (scene == 15) { scene = 13; }
                else if (scene == 17) { scene = 0; }
                else if (scene == 99) { scene = 0; }
            }
            else if (e.KeyCode == Keys.B)  //Green button press
            {
                if (scene == 0) { scene = 1; }
                else if (scene == 1) { scene = 0; }
                else if (scene == 2) { scene = 98; }
                else if (scene == 3)
                {
                    percent = randGen.Next(0, 101);
                    if (percent >= 25) { scene = 6; }
                    else { scene = 7; }
                }
                else if (scene == 4) { scene = 98; }
                else if (scene == 6) { scene = 98; }
                else if (scene == 7) { scene = 8; }
                else if (scene == 8)
                {
                    percent = randGen.Next(0, 101);
                    if (percent >= 10) { scene = 10; }
                    else { scene = 99; }
                }
                else if (scene == 9) { scene = 98; }
                else if (scene == 10) { scene = 98; }
                else if (scene == 11) { scene = 14; }
                else if (scene == 12) { scene = 14; }
                else if (scene == 13) { scene = 98; }
                else if (scene == 14) { scene = 1; }
                else if (scene == 15)
                {
                    percent = randGen.Next(0, 101);
                    if (percent >= 50) { scene = 17; }
                    else { scene = 16; }
                }
                else if (scene == 16) { scene = 99; }
                else if (scene == 17) { scene = 98; }
                else if (scene == 99) { scene = 98; }
            }
            else if (e.KeyCode == Keys.Space)  //Blue Button
            {
                if (scene == 12) { scene = 14; }
                else if (scene == 14) { scene = 15; }
            }
            else if (e.KeyCode == Keys.N)  //Yellow Button
            {
                if (scene == 12) { scene = 13; }
            }

            scoreLabel.Text = "" + scene;

            switch (scene)
            {
                case 0:  //start scene  
                    outputLabel.Text = "You find yourself at the edge of a forest. You hear a noise inside the forest. " +
                        "On the other side of the forest is a road.";
                    bOutputLabel.Text = "Go to the forest.";
                    mOutputLabel.Text = "Go to the road.";
                    scenePicture.BackgroundImage = Properties.Resources.ForestRoad;
                    break;
                case 1:
                    outputLabel.Text = "You encounter a large pit. Do you continue?";
                    bOutputLabel.Text = "No";
                    mOutputLabel.Text = "Yes";
                    //nButtonLabel.Visible = true;
                    break;
                case 2:
                    outputLabel.Text = "You did not survive the jump, you died. Play Again?";
                    bOutputLabel.Text = "No";
                    mOutputLabel.Text = "Yes";
                    break;
                case 3:
                    outputLabel.Text = "You survived the jump. Yay!!! You come across a man with a bloody knife.";
                    bOutputLabel.Text = "Run away.";
                    mOutputLabel.Text = "Fight.";
                    break;
                case 4:
                    outputLabel.Text = "The man with the knife kills you. Play again?";
                    bOutputLabel.Text = "No";
                    mOutputLabel.Text = "Yes";
                    break;
                case 5:
                    outputLabel.Text = "You manage to escape the man with a knife. Yay!";
                    bOutputLabel.Text = "Continue";
                    mOutputLabel.Text = "";
                    mButtonLabel.Visible = false;
                    break;
                case 6:
                    outputLabel.Text = "The man with the knife kills you. Play again?";
                    bOutputLabel.Text = "No";
                    mOutputLabel.Text = "Yes";
                    break;
                case 7:
                    outputLabel.Text = "You manage to escape the man with a knife. Yay!";
                    bOutputLabel.Text = "Continue";
                    mOutputLabel.Text = "";
                    mButtonLabel.Visible = false;
                    break;
                case 8:
                    outputLabel.Text = "You come across a river. Do you take your chances in the forest or cross the river?";
                    bOutputLabel.Text = "River";
                    mOutputLabel.Text = "Forest";
                    mButtonLabel.Visible = true;
                    break;
                case 9:
                    outputLabel.Text = "You died due to starvation. Play Again?";
                    bOutputLabel.Text = "No";
                    mOutputLabel.Text = "Yes";
                    break;
                case 10:
                    outputLabel.Text = "You drowned in the river. Play Again?";
                    bOutputLabel.Text = "No";
                    mOutputLabel.Text = "Yes";
                    break;
                case 11:
                    outputLabel.Text = "After a while of walking you spot a person walking towards you.";
                    bOutputLabel.Text = "Keep walking.";
                    mOutputLabel.Text = "Cross the street.";
                    break;
                case 12:
                    outputLabel.Text = "The person also crosses the street. Then you are face to face with the person.";
                    bOutputLabel.Text = "Say: Hey.";
                    mOutputLabel.Text = "Ignore the person and keep walking.";
                    nOutputLabel.Text = "Cross the street again.";
                    spaceOutputLabel.Text = "Say: What do you want?";
                    nButtonLabel.Visible = true;
                    spaceLabel.Visible = true;
                    break;
                case 13:
                    outputLabel.Text = "You keep walking and down the desolate road and eventually die of starvation. Play again?";
                    bOutputLabel.Text = "No";
                    mOutputLabel.Text = "Yes";
                    nButtonLabel.Visible = false;
                    spaceLabel.Visible = false;
                    break;
                case 14:
                    outputLabel.Text = "The person ignores you and walks past. What do you do now?";
                    bOutputLabel.Text = "Walk back to the forest?";
                    mOutputLabel.Text = "Keep walking?";
                    spaceOutputLabel.Text = "Hitchhike for a ride?";
                    spaceLabel.Visible = true;
                    break;
                case 15:
                    outputLabel.Text = "A car pulls up next to you. The sketchy dude inside asks if you need a ride. Do you get in?";
                    bOutputLabel.Text = "Get in the car.";
                    mOutputLabel.Text = "Decline the ride.";
                    spaceLabel.Visible = false;
                    break;
                case 16:
                    outputLabel.Text = "The man leaves you safely at your destination.";
                    mOutputLabel.Text = "";
                    mButtonLabel.Visible = false;
                    bOutputLabel.Text = "Continue";
                    break;
                case 17:
                    outputLabel.Text = "The sketchy man kills you and takes your belongings. Play again?";
                    bOutputLabel.Text = "No";
                    mOutputLabel.Text = "Yes";
                    mButtonLabel.Visible = true;
                    break;
                case 98:
                    outputLabel.Text = "Hope you liked it!";
                    mOutputLabel.Text = "";
                    mButtonLabel.Visible = false;
                    bOutputLabel.Text = "";
                    bButtonLabel.Visible = false;

                    break;
                case 99:
                    outputLabel.Text = "";
                    bOutputLabel.Text = "No";
                    mOutputLabel.Text = "Yes";
                    break;
                default:
                    break;
            }
        }
    }
}

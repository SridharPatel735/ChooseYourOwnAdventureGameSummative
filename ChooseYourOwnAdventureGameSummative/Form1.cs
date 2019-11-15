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
using System.Threading;
/// <summary>
/// Created by Sridhar and Calem
/// November 2019
/// Created an adventure game
/// </summary>
namespace ChooseYourOwnAdventureGameSummative
{
    public partial class Form1 : Form
    {
        //Creating the varibles and random generator
        Random randGen = new Random();
        int scene = 0;
        int percent;
        SoundPlayer yay = new SoundPlayer(Properties.Resources.Yay);
        SoundPlayer gameover = new SoundPlayer(Properties.Resources.gameover);
        SoundPlayer riverSound = new SoundPlayer(Properties.Resources.Riversounds);
        SoundPlayer forestSound = new SoundPlayer(Properties.Resources.forestAmbience);
        SoundPlayer roadSound = new SoundPlayer(Properties.Resources.nighttime_ambience);

        public Form1()
        {
            InitializeComponent();
            //The start scene and creating the sounds
            yay.Stop();
            roadSound.Stop();
            gameover.Stop();
            riverSound.Stop();
            forestSound.Play();

            nButtonLabel.Visible = false;
            spaceLabel.Visible = false;
            mButtonLabel.Visible = true;
            bButtonLabel.Visible = true;
            outputLabel.Text = "You find yourself at the edge of a forest. You hear a noise inside the forest. " +
                        "On the other side of the forest is a road.";
            bOutputLabel.Text = "Go to the forest.";
            mOutputLabel.Text = "Go to the road.";
            spaceOutputLabel.Text = "";
            nOutputLabel.Text = "";
            Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Creating the sounds

            //Scene change
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
            //Scene change
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
            //Scene change
            else if (e.KeyCode == Keys.Space)  //Blue Button
            {
                if (scene == 12) { scene = 14; }
                else if (scene == 14) { scene = 15; }
            }
            //Scene change
            else if (e.KeyCode == Keys.N)  //Yellow Button
            {
                if (scene == 12) { scene = 13; }
            }

            //Each scene and changes
            switch (scene)
            {
                case 0:
                    yay.Stop();
                    roadSound.Stop();
                    gameover.Stop();
                    riverSound.Stop();
                    forestSound.Play();
                    nButtonLabel.Visible = false;
                    spaceLabel.Visible = false;
                    mButtonLabel.Visible = true;
                    bButtonLabel.Visible = true;
                    outputLabel.Text = "You find yourself at the edge of a forest. You hear a noise inside the forest. " +
                        "On the other side of the forest is a road.";
                    bOutputLabel.Text = "Go to the forest.";
                    mOutputLabel.Text = "Go to the road.";
                    spaceOutputLabel.Text = "";
                    nOutputLabel.Text = "";
                    scenePicture.BackgroundImage = Properties.Resources.ForestRoad;
                    break;
                case 1:
                    yay.Stop();
                    roadSound.Stop();
                    gameover.Stop();
                    riverSound.Stop();
                    forestSound.Play();
                    nButtonLabel.Visible = false;
                    spaceLabel.Visible = false;
                    mButtonLabel.Visible = true;
                    bButtonLabel.Visible = true;
                    scenePicture.BackgroundImage = Properties.Resources.LargePit;
                    outputLabel.Text = "You encounter a large pit. ";
                    outputLabel.Text += "Do you continue?";
                    bOutputLabel.Text = "No";
                    mOutputLabel.Text = "Yes";
                    spaceOutputLabel.Text = "";
                    nOutputLabel.Text = "";
                    break;
                case 2:
                    yay.Stop();
                    roadSound.Stop();
                    forestSound.Stop();
                    riverSound.Stop();
                    gameover.Play();
                    nButtonLabel.Visible = false;
                    spaceLabel.Visible = false;
                    mButtonLabel.Visible = true;
                    bButtonLabel.Visible = true;
                    scenePicture.BackgroundImage = Properties.Resources.YouDied;
                    outputLabel.Text = "You did not survive the jump, you died.";
                    bOutputLabel.Text = "";
                    mOutputLabel.Text = "";
                    spaceOutputLabel.Text = "";
                    nOutputLabel.Text = "";
                    Refresh();
                    Thread.Sleep(1250);
                    outputLabel.Text += " Play Again?";
                    bOutputLabel.Text = "No";
                    mOutputLabel.Text = "Yes";
                    spaceOutputLabel.Text = "";
                    nOutputLabel.Text = "";
                    break;
                case 3:
                    yay.Stop();
                    roadSound.Stop();
                    gameover.Stop();
                    riverSound.Stop();
                    forestSound.Play();
                    nButtonLabel.Visible = false;
                    spaceLabel.Visible = false;
                    mButtonLabel.Visible = true;
                    bButtonLabel.Visible = true;
                    outputLabel.Text = "You survived the jump. Yay!!!";
                    bOutputLabel.Text = "";
                    mOutputLabel.Text = "";
                    spaceOutputLabel.Text = "";
                    nOutputLabel.Text = "";
                    Refresh();
                    Thread.Sleep(1250);
                    scenePicture.BackgroundImage = Properties.Resources.BloodyKnife;
                    outputLabel.Text += " You come across a man with a bloody knife.";
                    bOutputLabel.Text = "Run away.";
                    mOutputLabel.Text = "Fight.";
                    spaceOutputLabel.Text = "";
                    nOutputLabel.Text = "";
                    break;
                case 4:
                    yay.Stop();
                    roadSound.Stop();
                    forestSound.Stop();
                    riverSound.Stop();
                    gameover.Play();
                    nButtonLabel.Visible = false;
                    spaceLabel.Visible = false;
                    mButtonLabel.Visible = true;
                    bButtonLabel.Visible = true;
                    scenePicture.BackgroundImage = Properties.Resources.CartoonStab;
                    outputLabel.Text = "The man with the knife kills you. ";
                    bOutputLabel.Text = "";
                    mOutputLabel.Text = "";
                    spaceOutputLabel.Text = "";
                    nOutputLabel.Text = "";
                    Refresh();
                    Thread.Sleep(1250);
                    outputLabel.Text += "Play again?";
                    bOutputLabel.Text = "No";
                    mOutputLabel.Text = "Yes";
                    spaceOutputLabel.Text = "";
                    nOutputLabel.Text = "";
                    break;
                case 5:
                    yay.Stop();
                    roadSound.Stop();
                    gameover.Stop();
                    riverSound.Stop();
                    forestSound.Play();
                    nButtonLabel.Visible = false;
                    spaceLabel.Visible = false;
                    mButtonLabel.Visible = true;
                    bButtonLabel.Visible = false;
                    outputLabel.Text = "You manage to escape the man with a knife. Yay!";
                    bOutputLabel.Text = "";
                    mOutputLabel.Text = "Continue";
                    spaceOutputLabel.Text = "";
                    nOutputLabel.Text = "";
                    scenePicture.BackgroundImage = Properties.Resources.YAY_;
                    break;
                case 6:
                    yay.Stop();
                    roadSound.Stop();
                    forestSound.Stop();
                    riverSound.Stop();
                    gameover.Play();
                    nButtonLabel.Visible = false;
                    spaceLabel.Visible = false;
                    mButtonLabel.Visible = true;
                    bButtonLabel.Visible = true;
                    scenePicture.BackgroundImage = Properties.Resources.CartoonStab;
                    outputLabel.Text = "The man with the knife kills you. ";
                    bOutputLabel.Text = "";
                    mOutputLabel.Text = "";
                    spaceOutputLabel.Text = "";
                    nOutputLabel.Text = "";
                    Refresh();
                    Thread.Sleep(1250);
                    outputLabel.Text += "Play again?";
                    bOutputLabel.Text = "No";
                    mOutputLabel.Text = "Yes";
                    spaceOutputLabel.Text = "";
                    nOutputLabel.Text = "";
                    break;
                case 7:
                    yay.Stop();
                    roadSound.Stop();
                    gameover.Stop();
                    riverSound.Stop();
                    forestSound.Play();
                    nButtonLabel.Visible = false;
                    spaceLabel.Visible = false;
                    mButtonLabel.Visible = false;
                    bButtonLabel.Visible = true;
                    outputLabel.Text = "You manage to escape the man with a knife. Yay!";
                    bOutputLabel.Text = "Continue";
                    mOutputLabel.Text = "";
                    spaceOutputLabel.Text = "";
                    nOutputLabel.Text = "";
                    scenePicture.BackgroundImage = Properties.Resources.YAY_;
                    break;
                case 8:
                    yay.Stop();
                    roadSound.Stop();
                    gameover.Stop();
                    forestSound.Stop();
                    riverSound.Play();
                    nButtonLabel.Visible = false;
                    spaceLabel.Visible = false;
                    mButtonLabel.Visible = true;
                    bButtonLabel.Visible = true;
                    outputLabel.Text = "You come across a river. Do you take your chances in the forest or cross the river?";
                    bOutputLabel.Text = "River";
                    mOutputLabel.Text = "Forest";
                    spaceOutputLabel.Text = "";
                    nOutputLabel.Text = "";
                    scenePicture.BackgroundImage = Properties.Resources.ForestRiver;
                    break;
                case 9:
                    yay.Stop();
                    roadSound.Stop();
                    forestSound.Stop();
                    riverSound.Stop();
                    gameover.Play();
                    nButtonLabel.Visible = false;
                    spaceLabel.Visible = false;
                    mButtonLabel.Visible = true;
                    bButtonLabel.Visible = true;
                    scenePicture.BackgroundImage = Properties.Resources.YouDied;
                    outputLabel.Text = "You died due to starvation. ";
                    bOutputLabel.Text = "";
                    mOutputLabel.Text = "";
                    spaceOutputLabel.Text = "";
                    nOutputLabel.Text = "";
                    Refresh();
                    Thread.Sleep(1250);
                    outputLabel.Text += "Play again?";
                    bOutputLabel.Text = "No";
                    mOutputLabel.Text = "Yes";
                    spaceOutputLabel.Text = "";
                    nOutputLabel.Text = "";
                    break;
                case 10:
                    yay.Stop();
                    roadSound.Stop();
                    forestSound.Stop();
                    riverSound.Stop();
                    gameover.Play();
                    nButtonLabel.Visible = false;
                    spaceLabel.Visible = false;
                    mButtonLabel.Visible = true;
                    bButtonLabel.Visible = true;
                    scenePicture.BackgroundImage = Properties.Resources.YouDied;
                    outputLabel.Text = "You drowned in the river. ";
                    bOutputLabel.Text = "";
                    mOutputLabel.Text = "";
                    spaceOutputLabel.Text = "";
                    nOutputLabel.Text = "";
                    Refresh();
                    Thread.Sleep(1250);
                    outputLabel.Text += "Play again?";
                    bOutputLabel.Text = "No";
                    mOutputLabel.Text = "Yes";
                    spaceOutputLabel.Text = "";
                    nOutputLabel.Text = "";
                    break;
                case 11:
                    yay.Stop();
                    gameover.Stop();
                    riverSound.Stop();
                    forestSound.Stop();
                    roadSound.Play();
                    nButtonLabel.Visible = false;
                    spaceLabel.Visible = false;
                    mButtonLabel.Visible = true;
                    bButtonLabel.Visible = true;
                    outputLabel.Text = "After a while of walking you spot a person walking towards you.";
                    bOutputLabel.Text = "Keep walking.";
                    mOutputLabel.Text = "Cross the street.";
                    spaceOutputLabel.Text = "";
                    nOutputLabel.Text = "";
                    scenePicture.BackgroundImage = Properties.Resources.ManOnRoadBetter;
                    break;
                case 12:
                    yay.Stop();
                    gameover.Stop();
                    riverSound.Stop();
                    forestSound.Stop();
                    roadSound.Play();
                    nButtonLabel.Visible = true;
                    spaceLabel.Visible = true;
                    mButtonLabel.Visible = true;
                    bButtonLabel.Visible = true;
                    outputLabel.Text = "The person also crosses the street. Then you are face to face with the person.";
                    bOutputLabel.Text = "Say: Hey.";
                    mOutputLabel.Text = "Ignore the person and keep walking.";
                    nOutputLabel.Text = "Cross the street again.";
                    spaceOutputLabel.Text = "Say: What do you want?";
                    scenePicture.BackgroundImage = Properties.Resources.Face2FaceMan;
                    break;
                case 13:
                    yay.Stop();
                    roadSound.Stop();
                    riverSound.Stop();
                    forestSound.Stop();
                    gameover.Play();
                    nButtonLabel.Visible = false;
                    spaceLabel.Visible = false;
                    mButtonLabel.Visible = true;
                    bButtonLabel.Visible = true;
                    scenePicture.BackgroundImage = Properties.Resources.YouDied;
                    outputLabel.Text = "You keep walking and down the desolate road and eventually die of starvation. ";
                    bOutputLabel.Text = "";
                    mOutputLabel.Text = "";
                    spaceOutputLabel.Text = "";
                    nOutputLabel.Text = "";
                    Refresh();
                    Thread.Sleep(1250);
                    outputLabel.Text += "Play again?";
                    bOutputLabel.Text = "No";
                    mOutputLabel.Text = "Yes";
                    spaceOutputLabel.Text = "";
                    nOutputLabel.Text = "";
                    break;
                case 14:
                    yay.Stop();
                    gameover.Stop();
                    riverSound.Stop();
                    forestSound.Stop();
                    roadSound.Play();
                    nButtonLabel.Visible = false;
                    spaceLabel.Visible = true;
                    mButtonLabel.Visible = true;
                    bButtonLabel.Visible = true;
                    outputLabel.Text = "The person ignores you and walks past. What do you do now?";
                    bOutputLabel.Text = "Walk back to the forest.";
                    mOutputLabel.Text = "Keep walking.";
                    spaceOutputLabel.Text = "Hitchhike for a ride.";
                    nOutputLabel.Text = "";
                    scenePicture.BackgroundImage = Properties.Resources.ManWalksPast;
                    break;
                case 15:
                    yay.Stop();
                    gameover.Stop();
                    riverSound.Stop();
                    forestSound.Stop();
                    roadSound.Play();
                    nButtonLabel.Visible = false;
                    spaceLabel.Visible = false;
                    mButtonLabel.Visible = true;
                    bButtonLabel.Visible = true;
                    outputLabel.Text = "A car pulls up next to you. The sketchy dude inside asks if you need a ride. Do you get in?";
                    bOutputLabel.Text = "Get in the car.";
                    mOutputLabel.Text = "Decline the ride.";
                    spaceOutputLabel.Text = "";
                    nOutputLabel.Text = "";
                    scenePicture.BackgroundImage = Properties.Resources.CarManNight;
                    break;
                case 16:
                    yay.Stop();
                    roadSound.Stop();
                    gameover.Stop();
                    riverSound.Stop();
                    forestSound.Stop();
                    nButtonLabel.Visible = false;
                    spaceLabel.Visible = false;
                    mButtonLabel.Visible = false;
                    bButtonLabel.Visible = true;
                    outputLabel.Text = "The man leaves you safely at your destination.";
                    mOutputLabel.Text = "";
                    bOutputLabel.Text = "Continue";
                    spaceOutputLabel.Text = "";
                    nOutputLabel.Text = "";
                    scenePicture.BackgroundImage = Properties.Resources.ForestHouse;
                    break;
                case 17:
                    yay.Stop();
                    roadSound.Stop();
                    riverSound.Stop();
                    forestSound.Stop();
                    gameover.Play();
                    nButtonLabel.Visible = false;
                    spaceLabel.Visible = false;
                    mButtonLabel.Visible = true;
                    bButtonLabel.Visible = true;
                    scenePicture.BackgroundImage = Properties.Resources.YouDied;
                    outputLabel.Text = "The sketchy man kills you and takes your belongings. ";
                    bOutputLabel.Text = "";
                    mOutputLabel.Text = "";
                    spaceOutputLabel.Text = "";
                    nOutputLabel.Text = "";
                    Refresh();
                    Thread.Sleep(1250);
                    outputLabel.Text += "Play again?";
                    bOutputLabel.Text = "No";
                    mOutputLabel.Text = "Yes";
                    spaceOutputLabel.Text = "";
                    nOutputLabel.Text = "";
                    break;
                case 98:
                    yay.Stop();
                    roadSound.Stop();
                    gameover.Stop();
                    riverSound.Stop();
                    forestSound.Stop();
                    nButtonLabel.Visible = false;
                    spaceLabel.Visible = false;
                    mButtonLabel.Visible = false;
                    bButtonLabel.Visible = false;
                    outputLabel.Text = "Hope you liked it!";
                    mOutputLabel.Text = "";
                    bOutputLabel.Text = "";
                    spaceOutputLabel.Text = "";
                    nOutputLabel.Text = "";
                    scenePicture.BackgroundImage = Properties.Resources.ThanksForPlaying;
                    Refresh();
                    Thread.Sleep(2000);
                    this.Close();
                    break;
                case 99:
                    roadSound.Stop();
                    gameover.Stop();
                    riverSound.Stop();
                    forestSound.Stop();
                    yay.Play();
                    nButtonLabel.Visible = false;
                    spaceLabel.Visible = false;
                    mButtonLabel.Visible = true;
                    bButtonLabel.Visible = true;
                    scenePicture.BackgroundImage = Properties.Resources.ForestHouse;
                    outputLabel.Text = "You finally make it home after all this time. You win! ";
                    bOutputLabel.Text = "";
                    mOutputLabel.Text = "";
                    spaceOutputLabel.Text = "";
                    nOutputLabel.Text = "";
                    Refresh();
                    Thread.Sleep(1250);
                    outputLabel.Text += "Play again?";
                    bOutputLabel.Text = "No";
                    mOutputLabel.Text = "Yes";
                    spaceOutputLabel.Text = "";
                    nOutputLabel.Text = "";
                    break;
                default:
                    break;
            }
        }
    }
}

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
            scoreLabel.Text = "" + scene;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (scene == 2) { scene = 97; }
            else if (scene == 4) { scene = 97; }
            else if (scene == 6) { scene = 97; }
            else if (scene == 9) { scene = 97; }
            else if (scene == 10) { scene = 97; }
            else if (scene == 13) { scene = 97; }
            else if (scene == 17) { scene = 97; }

            if (e.KeyCode == Keys.M)       //red button press
            {
                if (scene == 0) { scene = 11; }
                else if (scene == 1)
                {
                    percent = randGen.Next(0, 101);
                    if (percent >= 50) { scene = 2; }
                    else { scene = 3; }
                }
                else if (scene == 3)
                {
                    percent = randGen.Next(0, 101);
                    if (percent >= 25) { scene = 4; }
                    else { scene = 5; }
                }
                else if (scene == 5) { scene = 8; }
                else if (scene == 8)
                {
                    percent = randGen.Next(0, 101);
                    if (percent >= 10) { scene = 9; }
                    else { scene = 0; }
                }
                else if (scene == 11) { scene = 12; }
                else if (scene == 12) { scene = 13; }
                else if (scene == 14) { scene = 13; }
                else if (scene == 15) { scene = 13; }
                else if (scene == 97) { scene = 0; }
                else if (scene == 99) { scene = 0; }
            }
            else if (e.KeyCode == Keys.B)  //Green button press
            {
                if (scene == 0) { scene = 1; }
                else if (scene == 1) { scene = 0; }
                else if (scene == 3)
                {
                    percent = randGen.Next(0, 101);
                    if (percent >= 25) { scene = 6; }
                    else { scene = 7; }
                }
                else if (scene == 7) { scene = 8; }
                else if (scene == 8)
                {
                    percent = randGen.Next(0, 101);
                    if (percent >= 10) { scene = 10; }
                    else { scene = 99; }
                }
                else if (scene == 11) { scene = 14; }
                else if (scene == 12) { scene = 14; }
                else if (scene == 14) { scene = 1; }
                else if (scene == 15)
                {
                    percent = randGen.Next(0, 101);
                    if (percent >= 50) { scene = 17; }
                    else { scene = 16; }
                }
                else if (scene == 16) { scene = 99; }
                else if (scene == 97) { scene = 98; }
                else if (scene == 99) { scene = 97; }
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
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 13:
                    break;
                case 14:
                    break;
                case 15:
                    break;
                case 16:
                    break;
                case 17:
                    break;
                case 97:
                    break;
                case 98:
                    break;
                case 99:
                    break;
                default:
                    break;
            }
        }
    }
}

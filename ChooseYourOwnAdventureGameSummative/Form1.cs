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
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            outputLabel.Text = "" + scene;
            if (e.KeyCode == Keys.M)       //red button press
            {
                if (scene == 0) { scene = 11; }
                else if (scene == 1)
                {
                    percent = randGen.Next(0, 101);
                    if (percent >= 50) { scene = 2; }
                    else { scene = 3; }
                }
                else if (scene == 2) { scene = 98; }
                else if (scene == 3)
                {
                    percent = randGen.Next(0, 101);
                    if (percent >= 25) { scene = 4; }
                    else { scene = 5; }
                }
                else if (scene == 4) { scene = 98; }
                else if (scene == 5) { scene = 8; }
                else if (scene == 8)
                {
                    percent = randGen.Next(0, 101);
                    if (percent >= 10) { scene = 9; }
                    else { scene = 0; }
                }
                else if (scene == 9) { scene = 98; }
                else if (scene == 11) { scene = 12; }
                // if (scene == 12) { scene =  }
                else if (scene == 13) { scene = 98; }
                else if (scene == 14) { scene = 13; }
                else if (scene == 15) { scene = 13; }
            }
            else if (e.KeyCode == Keys.B)  //Green button press
            {
                if (scene == 0) { scene = 1; }
                else if (scene == 1) { scene = 0; }
                else if (scene == 2) { scene = 98; }
                else if (scene == 3)
                {
                    percent = randGen.Next(0, 101);
                    if (percent >= 25) {scene = 6; }
                    else {scene = 7; }
                }
                else if (scene == 6) { scene = 98; }
                else if (scene == 7) { scene = 8; }
                else if (scene == 8)
                {
                    percent = randGen.Next(0, 101);
                    if (percent >= 10) { scene = 10; }
                    else { scene = 99; }
                }
                else if (scene == 10) { scene = 98; }
                else if (scene == 11) { scene = 14; }
                //else if (scene == 12) { scene =   }
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
            }
        }
    }
}

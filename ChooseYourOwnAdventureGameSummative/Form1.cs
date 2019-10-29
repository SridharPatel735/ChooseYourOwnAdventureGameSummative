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

        int scene = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M)       //red button press
            {
                if (scene == 0) { scene = ; }
                else if (scene == 1) { scene =  }
                else if (scene == 2) { scene =  }
                else if (scene == 3) { scene =  }
                else if (scene == 4) { scene =  }
                else if (scene == 5) { scene =  }
                else if (scene == 6) { scene =  }
                else if (scene == 7) { scene =  }
                else if (scene == 8) { scene =  }
                else if (scene == 9) { scene =  }
                else if (scene == 10) { scene =  }
                else if (scene == 11) { scene =  }
                else if (scene == 12) { scene =  }
                else if (scene == 13) { scene =  }
                else if (scene == 14) { scene =  }
                else if (scene == 15) { scene =  }
                else if (scene == 16) { scene =  }
                else if (scene == 17) { scene =  }
            }
            else if (e.KeyCode == Keys.B)  //Green button press
            {
                if (scene == 0) { scene = 1; }
                else if (scene == 1) { scene =  }
                else if (scene == 2) { scene =  }
                else if (scene == 3) { scene =  }
                else if (scene == 4) { scene =  }
                else if (scene == 5) { scene =  }
                else if (scene == 6) { scene =  }
                else if (scene == 7) { scene =  }
                else if (scene == 8) { scene =  }
                else if (scene == 9) { scene =  }
                else if (scene == 10) { scene =  }
                else if (scene == 11) { scene =  }
                else if (scene == 12) { scene =  }
                else if (scene == 13) { scene =  }
                else if (scene == 14) { scene =  }
                else if (scene == 15) { scene =  }
                else if (scene == 16) { scene =  }
                else if (scene == 17) { scene =  }
            }
        }
    }
}

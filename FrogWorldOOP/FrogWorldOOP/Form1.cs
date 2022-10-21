using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrogWorldOOP
{
    public partial class FrogWorld : Form
    {

        public Frog[] frogs = new Frog[5];
        public HoverFrog[] hoverFrogs = new HoverFrog[5];
        public UndergroundFrog[] undergroundFrogs = new UndergroundFrog[5];

        int countF = 0;
        int countHF = 0;
        int countUF = 0;

        public FrogWorld()
        {
            InitializeComponent();
        }

        private void cmdNewFrog_Click(object sender, EventArgs e)
        {
            string name;
            if (comboBox1.SelectedItem == "Frog")
            {
                name = "Fred" + countF;
                if (countF < 5)
                {
                    frogs[countF] = new Frog(this, name);
                    countF += 1;
                }
            }
            else if (comboBox1.SelectedItem == "HoverFrog")
            {
                name = "HoverSam" + countHF;
                if (countHF < 5)
                {
                    hoverFrogs[countHF] = new HoverFrog(this, name);
                    countHF += 1;
                }
            }
            else if (comboBox1.SelectedItem == "UndergroundFrog")
            {
                name = "DownUnderGreg" + countUF;
                if (countUF < 5)
                {
                    undergroundFrogs[countUF] = new UndergroundFrog(this, name);
                    countUF += 1;
                }
            }
        }
    }
}

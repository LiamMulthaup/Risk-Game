using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Risk
{
    public partial class RiskBoard : Form
    {
        string attackingTerritory;
        string defendingTerritory;
        Boolean attacking = true;
        int turnPhase = 0;
        int players;
        public RiskBoard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "label1";
                attackingmethod();
            }
            if (attacking == true)
            {
                defendingTerritory = "label1";
                defendingmethod();

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "label7";
                attackingmethod();
            }

        }

        private void label12_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "label12";
                attackingmethod();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "label2";
                attackingmethod();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "label13";
                attackingmethod();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "label4";
                attackingmethod();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "label5";
                attackingmethod();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "label11";
                attackingmethod();
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "label13";
                attackingmethod();
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "label14";
                attackingmethod();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "label16";
                attackingmethod();
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "label15";
                attackingmethod();
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "label17";
                attackingmethod();
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "label18";
                attackingmethod();
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "label19";
                attackingmethod();
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "label20";
                attackingmethod();
            }
        }

        private void label21_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "label21";
                attackingmethod();
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "label22";
                attackingmethod();
            }
        }

        private void label25_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "label25";
                attackingmethod();
            }
        }

        private void label24_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "label24";
                attackingmethod();
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "label23";
                attackingmethod();
            }
        }

        private void label26_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "label26";
                attackingmethod();
            }
        }

        private void label27_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "label27";
                attackingmethod();
            }
        }

        private void label28_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "label28";
                attackingmethod();
            }
        }

        private void label32_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "label32";
                attackingmethod();
            }
        }

        private void label33_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "label33";
                attackingmethod();
            }
        }

        private void label31_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "label31";
                attackingmethod();
            }
        }

        private void label29_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "label29";
                attackingmethod();
            }
        }

        private void label30_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "label30";
                attackingmethod();
            }
        }

        private void label36_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "label36";
                attackingmethod();
            }
        }

        private void label35_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "label35";
                attackingmethod();
            }

        }

        private void label34_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "label34";
                attackingmethod();
            }
        }

        private void label37_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "label37";
                attackingmethod();
            }
        }

        private void label38_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "label38";
                attackingmethod();
            }
        }

        private void label40_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "label40";
                attackingmethod();
            }
        }

        private void label41_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "label41";
                attackingmethod();
            }
        }

        private void label42_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "label42";
                attackingmethod();
            }
        }

        private void label39_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "label39";
                attackingmethod();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "label6";
                attackingmethod();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "label8";
                attackingmethod();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "label9";
                attackingmethod();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "label10";
                attackingmethod();
            }
        }

        private void attackingmethod()
        {
            attacking = true;

        }
          
        private void defendingmethod()
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {

        }

        private void deployButton_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void useCardButton_Click(object sender, EventArgs e)
        {

        }

        private void beginTurnButton_Click(object sender, EventArgs e)
        {

        }

        private void label50_Click(object sender, EventArgs e)
        {

        }
    }
}

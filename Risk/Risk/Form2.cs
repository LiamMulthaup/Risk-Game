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
    public partial class riskInstructions : Form
    {
        int page = 0;
        object[] panels;
        public riskInstructions()
        {
            InitializeComponent();
            panels = new object[] { panel1, panel2, panel3, panel4, panel5, panel6, panel7, panel8 };// Add more panels for more pages.
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            page++;
            checkPage(1);
        }
        private void checkPage(int movement)
        {
            if (page == 0)
            {
                backButton.Visible = false;
            }
            else
            {
                backButton.Visible = true;
            }
            if (page == panels.Length - 1)
            {
                forwardButton.Visible = false;
            }
            else
            {
                forwardButton.Visible = true;
            }
            Panel invisipanel = panels[page - movement] as Panel;
            Panel visipanel = panels[page] as Panel;
            invisipanel.Visible = false;
            visipanel.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            page--;
            checkPage(-1);
        }
    }
}

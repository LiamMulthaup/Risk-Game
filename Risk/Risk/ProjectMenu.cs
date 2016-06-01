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
    public partial class ProjectMenu : Form
    {
        public ProjectMenu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            RiskBoard frm = new RiskBoard();
            frm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            creditsButton.Visible = false;
            label4.Visible = false;
        }
        private void resizing(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
            credits frm = new credits();
            frm.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            riskInstructions frm = new riskInstructions();
            frm.Show();
        }

        private void commentsLabel_Click(object sender, EventArgs e)
        {
            Comments frm = new Comments();
            frm.Show();
        }
    }
}

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
    public partial class credits : Form
    {
        public credits()
        {
            InitializeComponent();
            rollingCredits.Start();
        }

        private void credits_Load(object sender, EventArgs e)
        {

        }

        private void rollingCredits_Tick(object sender, EventArgs e)
        {
            if (korysCredit.Location.Y < 0)
            {
                rollingCredits.Stop();
                this.Close();
            }
            creditsLabel.Location = new Point(creditsLabel.Location.X, creditsLabel.Location.Y - 1);
            liamsCredit.Location = new Point(liamsCredit.Location.X, liamsCredit.Location.Y - 1);
            korysCredit.Location = new Point(korysCredit.Location.X, korysCredit.Location.Y - 1);
        }
    }
}

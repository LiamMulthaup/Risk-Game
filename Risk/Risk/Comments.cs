using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Risk
{
    public partial class Comments : Form
    {
        string username = "";
        public Comments()
        {
            InitializeComponent();
            refreshTimer.Start();
        }

        private void Comments_Load(object sender, EventArgs e)
        {
            refreshPage();
        }

        private void refreshPage()
        {
            commentViewer.Items.Clear();
            StreamReader outputFile = File.OpenText("comments.txt");
            while (!outputFile.EndOfStream)
            {
                commentViewer.Items.Insert(0, outputFile.ReadLine());
                commentViewer.Items.Insert(1, "");
            }
            outputFile.Close();
        }

        private void commentButton_Click(object sender, EventArgs e)
        {
            StreamWriter inputFile = File.AppendText("comments.txt");
            inputFile.WriteLine(username + ": " + commentTextBox.Text);
            commentViewer.Items.Insert(0, username + ": " + commentTextBox.Text);
            commentViewer.Items.Insert(1, "");
            commentTextBox.Text = "";
            inputFile.Close();
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            refreshPage();
        }

        private void beginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextbox.Text != "")
            {
                username = usernameTextbox.Text;
                loginPanel.Visible = false;
                commentTextBox.Visible = true;
                commentButton.Visible = true;
                commentTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Fill out Name");
            }
        }
    }
}

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
        public Comments()
        {
            InitializeComponent();
        }

        private void Comments_Load(object sender, EventArgs e)
        {
            StreamReader outputFile = File.OpenText("comments.txt");
            while (!outputFile.EndOfStream)
            {
                commentViewer.Items.Add(outputFile.ReadLine());
                commentViewer.Items.Add("");
            }
            outputFile.Close();
        }

        private void commentButton_Click(object sender, EventArgs e)
        {
            StreamWriter inputFile = File.AppendText("comments.txt");
            inputFile.WriteLine(commentTextBox.Text);
            commentViewer.Items.Add(commentTextBox.Text);
            commentViewer.Items.Add("");
            commentTextBox.Text = "";
            inputFile.Close();
        }
    }
}

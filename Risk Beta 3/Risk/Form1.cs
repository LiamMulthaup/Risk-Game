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
        string player1Name = "";
        string player2Name = "";
        string player3Name = "";
        string player4Name = "";
        string player5Name = "";
        string player6Name = "";
        string attackingTerritory;
        string defendingTerritory;
        Boolean attacking = true;
        int turnPhase = 0;
        int players;
        int orderplayer1, orderplayer2, orderplayer3, orderplayer4, orderplayer5, orderplayer6;
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

        private void beginGameButton_Click(object sender, EventArgs e)
        {
            int ready = 0;
            if (players > 1 && player1Name != "" && colorListBox1.SelectedIndex != -1 && player2Name != "" && colorListBox2.SelectedIndex != -1 &&
                colorListBox1.SelectedItem != colorListBox2.SelectedItem)
            {
                ready++;
                ready++;
            }
            if (players > 2 && player3Name != "" && colorListBox3.SelectedIndex != -1 && 
                colorListBox3.SelectedItem != colorListBox2.SelectedItem && colorListBox3.SelectedItem != colorListBox1.SelectedItem )
            {
                ready++;
            }
            
            if (players > 3 && player4Name != "" && colorListBox4.SelectedIndex != -1 &&
                colorListBox4.SelectedItem != colorListBox3.SelectedItem && colorListBox4.SelectedItem != colorListBox2.SelectedItem && colorListBox4.SelectedItem != colorListBox1.SelectedItem)
            {
                ready++;
            }
            
            if (players > 4 && player5Name != "" && colorListBox5.SelectedIndex != -1 &&
                colorListBox5.SelectedItem != colorListBox4.SelectedItem && colorListBox5.SelectedItem != colorListBox3.SelectedItem && colorListBox5.SelectedItem != colorListBox2.SelectedItem && colorListBox5.SelectedItem != colorListBox1.SelectedItem)
            {
                ready++;
            }
            if (players > 5 && player6Name != "" && colorListBox6.SelectedIndex != -1 &&
                colorListBox6.SelectedItem != colorListBox5.SelectedItem && colorListBox6.SelectedItem != colorListBox4.SelectedItem && colorListBox6.SelectedItem != colorListBox3.SelectedItem && colorListBox6.SelectedItem != colorListBox2.SelectedItem && colorListBox6.SelectedItem != colorListBox1.SelectedItem)
            {
                ready++;
            }
            if (ready == players)
            {
                beginGameButton.Visible = false;
                beginGameGroup.Visible = false;
            }
            else
            {
                MessageBox.Show("You forgot something");
            }
        }

        private void nameText1_TextChanged(object sender, EventArgs e)
        {
            if (nameText1.Text == " ")
            {
                MessageBox.Show("Can't have a space for the first letter");
                nameText1.Text = "";
            }
            else
            {
                player1Name = nameText1.Text;
            }
        }

        private void nameText2_TextChanged(object sender, EventArgs e)
        {
            if (nameText2.Text == " ")
            {
                MessageBox.Show("Can't have a space for the first letter");
                nameText2.Text = "";
            }
            else
            {
                player2Name = nameText2.Text;
            }
        }

        private void nameText3_TextChanged(object sender, EventArgs e)
        {
            if (nameText3.Text == " ")
            {
                MessageBox.Show("Can't have a space for the first letter");
                nameText3.Text = "";
            }
            else
            {
                player3Name = nameText3.Text;
            }
        }

        private void nameText4_TextChanged(object sender, EventArgs e)
        {
            if (nameText4.Text == " ")
            {
                MessageBox.Show("Can't have a space for the first letter");
                nameText4.Text = "";
            }
            else
            {
                player4Name = nameText4.Text;
            }
        }

        private void nameText5_TextChanged(object sender, EventArgs e)
        {
            if (nameText5.Text == " ")
            {
                MessageBox.Show("Can't have a space for the first letter");
                nameText5.Text = "";
            }
            else
            {
                player5Name = nameText5.Text;
            }
        }

        private void nameText6_TextChanged(object sender, EventArgs e)
        {
            if (nameText6.Text == " ")
            {
                MessageBox.Show("Can't have a space for the first letter");
                nameText6.Text = "";
            }
            else
            {
                player6Name = nameText6.Text;
            }
        }

        private void choosingBox_Enter(object sender, EventArgs e)
        {

        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            bool finishForm = false;
            if (players > 1 && player1Name != "" && colorListBox1.SelectedIndex != -1 && player2Name != "" && colorListBox2.SelectedIndex != -1)
            {
                Random rand = new Random();
                orderplayer1 = rand.Next(players) + 1;
                order1.Text = orderplayer1.ToString();
                order1.Visible = true;
                orderButton.Visible = false;
                beginGameButton.Visible = true;
            }
            else if (finishForm == false)
            {
                finishForm = true;
                MessageBox.Show("Finish Form");
                order1.Visible = false;
                orderButton.Visible = true;
                beginGameButton.Visible = false;
            }
            if (players > 1 && player1Name != "" && colorListBox1.SelectedIndex != -1 && player2Name != "" && colorListBox2.SelectedIndex != -1)
            {
                if (players > 1 && player2Name != "" && colorListBox2.SelectedIndex != -1)
                {
                    Random rand = new Random();
                    while (orderplayer2 == orderplayer1 || orderplayer2 == 0)
                    {
                        orderplayer2 = rand.Next(players) + 1;
                    }
                    order2.Text = orderplayer2.ToString();
                    order2.Visible = true;
                }
            }
            else if (finishForm == false)
            {
                finishForm = true;
                MessageBox.Show("Finish Form");
                order2.Visible = false;
                orderButton.Visible = true;
                beginGameButton.Visible = false;
            }
            if (players > 2 && player3Name != "" && colorListBox3.SelectedIndex != -1)
            {
                Random rand = new Random();
                while (orderplayer3 == orderplayer2 || orderplayer3 == orderplayer1 || orderplayer3 == 0)
                {
                    orderplayer3 = rand.Next(players) + 1;
                }
                order3.Text = orderplayer3.ToString();
                order3.Visible = true;
            }
            else if (finishForm == false)
            {
                finishForm = true;
                MessageBox.Show("Finish Form");
                order3.Visible = false;
                orderButton.Visible = true;
                beginGameButton.Visible = false;
            }
            if (players > 3 && player4Name != "" && colorListBox4.SelectedIndex != -1)
            {
                Random rand = new Random();
                while (orderplayer4 == orderplayer3 || orderplayer4 == orderplayer2 || orderplayer4 == orderplayer1 || orderplayer4 == 0)
                {
                    orderplayer4 = rand.Next(players) + 1;
                }
                order4.Text = orderplayer4.ToString();
                order4.Visible = true;
            }
            else if (finishForm == false)
            {
                finishForm = true;
                MessageBox.Show("Finish Form");
                order4.Visible = false;
                orderButton.Visible = true;
                beginGameButton.Visible = false;
            }
            if (players > 4 && player5Name != "" && colorListBox5.SelectedIndex != -1)
            {
                Random rand = new Random();
                while (orderplayer5 == orderplayer4 || orderplayer5 == orderplayer3 || orderplayer5 == orderplayer2 || orderplayer5 == orderplayer1 || orderplayer5 == 0)
                {
                    orderplayer5 = rand.Next(players) + 1;
                }
                order5.Text = orderplayer5.ToString();
                order5.Visible = true;
            }
            else if (finishForm == false)
            {
                finishForm = true;
                MessageBox.Show("Finish Form");
                order5.Visible = false;
                orderButton.Visible = true;
                beginGameButton.Visible = false;
            }
            if (players > 5 && player6Name != "" && colorListBox6.SelectedIndex != -1)
            {
                Random rand = new Random();
                while (orderplayer6 == orderplayer5 || orderplayer6 == orderplayer4 || orderplayer6 == orderplayer3 || orderplayer6 == orderplayer2 || orderplayer6 == orderplayer1 || orderplayer6 == 0)
                {
                    orderplayer6 = rand.Next(players) + 1;
                }
                order6.Text = orderplayer6.ToString();
                order6.Visible = true;
            }
            else if (finishForm == false)
            {
                finishForm = true;
                MessageBox.Show("Finish Form");
                order6.Visible = false;
                orderButton.Visible = true;
                beginGameButton.Visible = false;
            }

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (playerNumberTextBox.Text == "")
                {
                    players = 0;
                    randomLabel8.Visible = false; randomLabel14.Visible = false; randomLabel15.Visible = false; nameText1.Visible = false; colorListBox1.Visible = false;
                    randomLabel9.Visible = false; nameText2.Visible = false; colorListBox2.Visible = false;
                    randomLabel10.Visible = false; nameText3.Visible = false; colorListBox3.Visible = false;
                    randomLabel11.Visible = false; nameText4.Visible = false; colorListBox4.Visible = false;
                    randomLabel12.Visible = false; nameText5.Visible = false; colorListBox5.Visible = false;
                    randomLabel13.Visible = false; nameText6.Visible = false; colorListBox6.Visible = false;
                }
                if (playerNumberTextBox.Text != "")
                {
                    randomLabel10.Visible = false; nameText3.Visible = false; colorListBox3.Visible = false;
                    randomLabel11.Visible = false; nameText4.Visible = false; colorListBox4.Visible = false;
                    randomLabel12.Visible = false; nameText5.Visible = false; colorListBox5.Visible = false;
                    randomLabel13.Visible = false; nameText6.Visible = false; colorListBox6.Visible = false;
                    players = int.Parse(playerNumberTextBox.Text);
                    if (players > 6) { MessageBox.Show("No more than 6"); }
                    else {
                        if (players < 2) { MessageBox.Show("Need at least 2 players"); }
                        if (players > 1)
                        {
                            orderButton.Visible = true;
                            randomLabel8.Visible = true; randomLabel14.Visible = true; randomLabel15.Visible = true; nameText1.Visible = true; colorListBox1.Visible = true;
                            randomLabel9.Visible = true; nameText2.Visible = true; colorListBox2.Visible = true; randomLabel16.Visible = true;
                        }
                        if (players > 2) { randomLabel10.Visible = true; nameText3.Visible = true; colorListBox3.Visible = true; }
                        if (players > 3) { randomLabel11.Visible = true; nameText4.Visible = true; colorListBox4.Visible = true; }
                        if (players > 4) { randomLabel12.Visible = true; nameText5.Visible = true; colorListBox5.Visible = true; }
                        if (players > 5) { randomLabel13.Visible = true; nameText6.Visible = true; colorListBox6.Visible = true; }
                    }
                }
            }
            catch
            {
                MessageBox.Show("invalid number");
            }
            }
    }
}

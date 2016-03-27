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
        string color1, color2, color3, color4, color5, color6;
        string player1Name = "";
        string player2Name = "";
        string player3Name = "";
        string player4Name = "";
        string player5Name = "";
        string player6Name = "";
        string attackingTerritory;
        string defendingTerritory;
        Boolean attacking = true;
        int turn;
        string turnColor, turnName;
        int turnPhase = 0;
        int players;
        int orderplayer1, orderplayer2, orderplayer3, orderplayer4, orderplayer5, orderplayer6;
        int armiesUsed, armiesTotal;
        public RiskBoard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "Argentina";
                attackingmethod();
            }
            if (attacking == true)
            {
                defendingTerritory = "Argentina";
                defendingmethod();
            }
            if (turnPhase == 1)
            {
                if (argentina.BackColor == System.Drawing.Color.Transparent)
                {
                    if (turnColor == "red")
                    {
                        argentina.BackColor = System.Drawing.Color.Red;
                        argentina.Text = "1";
                    }
                    if (turnColor == "blue")
                    {
                        argentina.BackColor = System.Drawing.Color.LightBlue;
                        argentina.Text = "1";
                    }

                    if (turnColor == "green")
                    {
                        argentina.BackColor = System.Drawing.Color.LightGreen;
                        argentina.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        argentina.BackColor = System.Drawing.Color.Brown;
                        argentina.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        argentina.BackColor = System.Drawing.Color.Purple;
                        argentina.Text = "1";
                    }

                    if (turnColor == "pink")
                    {
                        argentina.BackColor = System.Drawing.Color.Pink;
                        argentina.Text = "1";
                    }
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && argentina.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && argentina.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && argentina.BackColor == System.Drawing.Color.LightGreen) || (turnColor == "brown" && argentina.BackColor == System.Drawing.Color.Brown) || (turnColor == "purple" && argentina.BackColor == System.Drawing.Color.Purple) || (turnColor == "pink" && argentina.BackColor == System.Drawing.Color.Pink))
                {
                    argentina.Text = (int.Parse(argentina.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            } 
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "Madagascar";
                attackingmethod();
            }

        }

        private void label12_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "Western United States";
                attackingmethod();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "Brazil";
                attackingmethod();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "Peru";
                attackingmethod();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "Venezuela";
                attackingmethod();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "North Africa";
                attackingmethod();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "Central America";
                attackingmethod();
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "Eastern United States";
                attackingmethod();
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "Alberta";
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
                attackingTerritory = "Quebec";
                attackingmethod();
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "Ontario";
                attackingmethod();
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "Alaska";
                attackingmethod();
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "Northwest Territory";
                attackingmethod();
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "Greenland";
                attackingmethod();
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "Iceland";
                attackingmethod();
            }
        }

        private void label21_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "Great Britain";
                attackingmethod();
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "Scandinavia";
                attackingmethod();
            }
        }

        private void label25_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "Western Europe";
                attackingmethod();
            }
        }

        private void label24_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "Northern Europe";
                attackingmethod();
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "Ukraine";
                attackingmethod();
            }
        }

        private void label26_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "Southern Europe";
                attackingmethod();
            }
        }

        private void label27_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "Middle East";
                attackingmethod();
            }
        }

        private void label28_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "Afghanistan";
                attackingmethod();
            }
        }

        private void label32_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "Ural";
                attackingmethod();
            }
        }

        private void label33_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "Siberia";
                attackingmethod();
            }
        }

        private void label31_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "China";
                attackingmethod();
            }
        }

        private void label29_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "India";
                attackingmethod();
            }
        }

        private void label30_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "Siam";
                attackingmethod();
            }
        }

        private void label36_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "Mongolia";
                attackingmethod();
            }
        }

        private void label35_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "Irkutsk";
                attackingmethod();
            }

        }

        private void label34_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "Yakutsk";
                attackingmethod();
            }
        }

        private void label37_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "Kamchatka";
                attackingmethod();
            }
        }

        private void label38_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "Japan";
                attackingmethod();
            }
        }

        private void label40_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "Indonesia";
                attackingmethod();
            }
        }

        private void label41_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "New Guinea";
                attackingmethod();
            }
        }

        private void label42_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "Eastern Australia";
                attackingmethod();
            }
        }

        private void label39_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "Western Australia";
                attackingmethod();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "South Africa";
                attackingmethod();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "Congo";
                attackingmethod();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "East Africa";
                attackingmethod();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            if (attacking == false)
            {
                attackingTerritory = "Egypt";
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
                if (players > 1)
                {
                    color1 = colorListBox1.SelectedItem.ToString();
                    color2 = colorListBox2.SelectedItem.ToString();
                }
                if (players > 2)
                {
                    color3 = colorListBox3.SelectedItem.ToString();
                }
                if (players > 3)
                {
                    color4 = colorListBox4.SelectedItem.ToString();
                }
                if (players > 4)
                {
                    color5 = colorListBox5.SelectedItem.ToString();
                }
                if (players > 5)
                {
                    color6 = colorListBox6.SelectedItem.ToString();
                }
                    beginGameButton.Visible = false;
                beginGameGroup.Visible = false;
                turn = 1;
                checkTurn();
                armiesUsed = 0;
                armiesTotal = 50 - (players * 5);
                initialdeployTroops();
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
            else if (finishForm == false && players > 1)
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
            else if (finishForm == false && players > 1)
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
            else if (finishForm == false && players > 2)
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
            else if (finishForm == false && players > 3)
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
            else if (finishForm == false && players > 4)
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
            else if (finishForm == false && players > 5)
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
        private void checkTurn()
        {
            if (orderplayer1 == turn)
            {
                turnColor = color1;
                turnName = player1Name;
            }
            if (orderplayer2 == turn)
            {
                turnColor = color2;
                turnName = player2Name;
            }
            if (orderplayer3 == turn)
            {
                turnColor = color3;
                turnName = player3Name;
            }
            if (orderplayer4 == turn)
            {
                turnColor = color4;
                turnName = player4Name;
            }
            if (orderplayer5 == turn)
            {
                turnColor = color5;
                turnName = player5Name;
            }
            if (orderplayer6 == turn)
            {
                turnColor = color6;
                turnName = player6Name;
            }

        }
        private void initialdeployTroops()
        {
            turnPhase = 1;
            choosingBox.Visible = true;
            randomLabel5.Text = turnName + "'s turn " + "(" + armiesUsed + "/" + armiesTotal + ")";
            if (turn == 6)
            {
                armiesUsed++;
                turn = 1;
            }
            else
            {
                turn++;
            }
            if (armiesUsed == armiesTotal)
            {
                turnPhase = 2;
            }
        }
    }
}

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
    public partial class RiskBoard : Form
    {

        string color1, color2, color3, color4, color5, color6; // Idenify player by color.

        string player1Name = "";//player variables identifies player by name.
        string player2Name = "";
        string player3Name = "";
        string player4Name = "";
        string player5Name = "";
        string player6Name = "";

        object attackingTerritory;
        object defendingTerritory;

        string[] color = new string[43]; //Identifies territory by way of color.
        int turn; // Identifies turn.
        string turnColor, turnName; // identifies turn by name or color.
        int turnPhase = 0; // Directs code in what part of the turn it is.
        int players; // Identifies how many players there are.
        int orderplayer1, orderplayer2, orderplayer3, orderplayer4, orderplayer5, orderplayer6; // Identifies player by order.

        int armiesUsed, armiesTotal; // Shows how many armies have been use and how many are left.

        int timup = 0; // Used to distinguish which alert should be hidden when the timer is up,
        int commandTest = 0;

        string[] numberData = new string[42]; //An array used for recorderd army data.

        int deffendingTroops; // Used to transfer the deffending armies # between two unconnected methods
        int attackingtimCounter = 0;
        int originalTransferringValue;

        bool winner = false;
        int[][] playerCards = new int[7][];
        int page;
        int playerNumber;
        List<int> selectedPlayerCards = new List<int>();
        int cardvalue = 3;

        bool cardIncrementingSetting = true;

        public RiskBoard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            territoryLabelClick(sender);
        }

        private void territoryLabelClick(object sender)
        {
            int colorid;
            colorid = senderdecryption(sender);
            Label lbl = sender as Label;
            lbl.Visible = false;
            if (turnPhase == 3 && color[colorid] == turnColor && armiesUsed != armiesTotal)
            {
                lbl.Text = (int.Parse(lbl.Text) + 1).ToString();
                deployedTroop();
            }
            if (turnPhase == 4 && color[colorid] == turnColor && int.Parse(lbl.Text) != 1)
            {
                turnPhase = 5; armiesTrackBar.Maximum = int.Parse(lbl.Text) - 1; armiesTrackBar.Maximum = int.Parse(lbl.Text) - 1; attackingTerritory = sender;
                runGame();
            }
            if (turnPhase == 5 && color[colorid] != turnColor)
            {
                if (CheckIfAdjacent(sender, attackingTerritory) == true)
                {
                    defendingTerritory = sender;
                    turnPhase = 6;
                    runGame();
                }
                deffendingTroops = int.Parse(lbl.Text);
            }
            if (turnPhase == 9 && color[colorid] == turnColor && int.Parse(lbl.Text) != 1)
            {
                attackingTerritory = sender;
                turnPhase = 10;
                runGame();
            }
            if (turnPhase == 10 && color[colorid] == turnColor && attackingTerritory != sender)
            {
                checkifTransferrable(sender);
            }
            if (turnPhase == 1)
            {
                if (lbl.BackColor == System.Drawing.Color.Transparent)
                {
                    setColorTerritory(lbl, colorid);
                    lbl.Text = "1";
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && lbl.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && lbl.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && lbl.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && lbl.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && lbl.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && lbl.BackColor == System.Drawing.Color.Pink))
                {
                    lbl.Text = (int.Parse(lbl.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
                
            }
            lbl.Visible = true;
        }

        private void checkifTransferrable(object sender)
        {
            object territory = sender;
            object source;
            object[] territoryArray = new object[42] {
                argentina, brazil, venezuela, peru,
                centralAmerica, westernUnitedStates, easternUnitedStates, alberta, ontario, quebec, greenLand, northWestTerritory, alaska,
                northAfrica, egypt, eastAfrica, congo, southAfrica, madagascar,
                iceland, scandinavia, greatBritain, westernEurope, southernEurope, northernEurope, ukraine,
                middleEast, afghanistan, india, siam, china, ural, siberia, mongolia, japan, irkutsk, yakutsk, kamchatka,
                indonesia, newGuinea, easternAustralia, westernAustralia
            };
            bool[] pathTracker = new bool[42] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            int[] activeTerritories = new int[1];
            List<int> newactiveTerritories = new List<int>();
            bool repeatedonce = false;
            bool finish = false;
            while (finish == false)
            {
                int halfRepetitions = 0;
                while (halfRepetitions < activeTerritories.Length)
                {
                    if (repeatedonce == true)
                    {
                        territory = territoryArray[activeTerritories[halfRepetitions]];
                    }

                    int counter = 0;
                    while (counter < territoryArray.Length)
                    {
                        source = territoryArray[counter];
                        if (CheckIfAdjacent(territory, source) == true && color[senderdecryption(source)] == turnColor && pathTracker[counter] == false)
                        {
                            repeatedonce = true;
                            newactiveTerritories.Add(counter);
                            pathTracker[counter] = true;
                            if (source == sender)
                            {
                                newactiveTerritories.Clear();
                                counter = territoryArray.Length;
                                halfRepetitions = activeTerritories.Length;
                                defendingTerritory = sender;
                                turnPhase = 11;
                                runGame();
                            }
                        }
                        counter++;
                    }
                    halfRepetitions++;
                }
                if (newactiveTerritories.Count == 0)
                {
                    finish = true;
                }
                else
                {
                    activeTerritories = new int[newactiveTerritories.Count];
                    int x = 0;
                    while (x < activeTerritories.Length)
                    {
                        activeTerritories[x] = newactiveTerritories[x];
                        x++;
                    }
                }
            }

            
        }

        private string findTerritoryStringName(object sender)
        {
            string territoryName = "";
            if (sender == argentina) { territoryName = "Argentina"; }
            if (sender == brazil) { territoryName = "Brazil"; ; }
            if (sender == venezuela) { territoryName = "Venezuela"; }
            if (sender == peru) { territoryName = "Peru"; }
            if (sender == centralAmerica) { territoryName = "Central America"; }
            if (sender == westernUnitedStates) { territoryName = "Western United States"; }
            if (sender == easternUnitedStates) { territoryName = "Eastern United States"; }
            if (sender == ontario) { territoryName = "Ontario"; }
            if (sender == alberta) { territoryName = "Alberta"; }
            if (sender == quebec) { territoryName = "Quebec"; }
            if (sender == alaska) { territoryName = "Alaska"; }
            if (sender == northWestTerritory) { territoryName = "Northwest Territory"; }
            if (sender == greenLand) { territoryName = "Greenland"; }
            if (sender == iceland) { territoryName = "Iceland"; }
            if (sender == scandinavia) { territoryName = "Scandinavia"; }
            if (sender == greatBritain) { territoryName = "Great Britain"; }
            if (sender == ukraine) { territoryName = "Ukraine"; }
            if (sender == northernEurope) { territoryName = "Northern Europe"; }
            if (sender == westernEurope) { territoryName = "Western Europe"; }
            if (sender == southernEurope) { territoryName = "Southern Europe"; }
            if (sender == northAfrica) { territoryName = "North Africa"; }
            if (sender == southAfrica) { territoryName = "South Africa"; }
            if (sender == congo) { territoryName = "Congo"; }
            if (sender == egypt) { territoryName = "Egypt"; }
            if (sender == eastAfrica) { territoryName = "East Africa"; }
            if (sender == madagascar) { territoryName = "Madagascar"; }
            if (sender == middleEast) { territoryName = "Middle East"; }
            if (sender == afghanistan) { territoryName = "Afghanistan"; }
            if (sender == india) { territoryName = "India"; }
            if (sender == china) { territoryName = "China"; }
            if (sender == siam) { territoryName = "Siam"; }
            if (sender == ural) { territoryName = "Ural"; }
            if (sender == mongolia) { territoryName = "Mongolia"; }
            if (sender == siberia) { territoryName = "Siberia"; }
            if (sender == irkutsk) { territoryName = "Irkutsk"; }
            if (sender == yakutsk) { territoryName = "Yakutsk"; }
            if (sender == japan) { territoryName = "Japan"; }
            if (sender == kamchatka) { territoryName = "Kamchatka"; }
            if (sender == indonesia) { territoryName = "Indonesia"; }
            if (sender == newGuinea) { territoryName = "New Guinea"; }
            if (sender == easternAustralia) { territoryName = "Eastern Australia"; }
            if (sender == westernAustralia) { territoryName = "Western Australia"; }
            return territoryName;
        }

        private void setColorTerritory(Label lbl, int colorid)
        {
            color[colorid] = turnColor;
            if (turnColor == "red")
            {
                lbl.BackColor = System.Drawing.Color.Red;
            }
            if (turnColor == "blue")
            {
                lbl.BackColor = System.Drawing.Color.LightBlue;
            }

            if (turnColor == "green")
            {
                lbl.BackColor = System.Drawing.Color.Green;
            }

            if (turnColor == "brown")
            {
                lbl.BackColor = System.Drawing.Color.Tan;
            }

            if (turnColor == "purple")
            {
                lbl.BackColor = System.Drawing.Color.MediumPurple;
            }

            if (turnColor == "pink")
            {
                lbl.BackColor = System.Drawing.Color.Pink;
            }
        }

        private int senderdecryption(object sender)
        {
            int colorid = 0;
            if (sender == argentina) { colorid = 1; }
            if (sender == brazil) { colorid = 2; }
            if (sender == venezuela) { colorid = 3; }
            if (sender == peru) { colorid = 4; }
            if (sender == centralAmerica) { colorid = 5; }
            if (sender == westernUnitedStates) { colorid = 6; }
            if (sender == easternUnitedStates) { colorid = 7; }
            if (sender == ontario) { colorid = 8; }
            if (sender == alberta) { colorid = 9; }
            if (sender == quebec) { colorid = 10; }
            if (sender == alaska) { colorid = 11; }
            if (sender == northWestTerritory) { colorid = 12; }
            if (sender == greenLand) { colorid = 13; }
            if (sender == iceland) { colorid = 14; }
            if (sender == scandinavia) { colorid = 15; }
            if (sender == greatBritain) { colorid = 16; }
            if (sender == ukraine) { colorid = 17; }
            if (sender == northernEurope) { colorid = 18; }
            if (sender == westernEurope) { colorid = 19; }
            if (sender == southernEurope) { colorid = 20; }
            if (sender == northAfrica) { colorid = 21; }
            if (sender == southAfrica) { colorid = 22; }
            if (sender == congo) { colorid = 23; }
            if (sender == egypt) { colorid = 24; }
            if (sender == eastAfrica) { colorid = 25; }
            if (sender == madagascar) { colorid = 26; }
            if (sender == middleEast) { colorid = 27; }
            if (sender == afghanistan) { colorid = 28; }
            if (sender == india) { colorid = 29; }
            if (sender == china) { colorid = 30; }
            if (sender == siam) { colorid = 31; }
            if (sender == ural) { colorid = 32; }
            if (sender == mongolia) { colorid = 33; }
            if (sender == siberia) { colorid = 34; }
            if (sender == irkutsk) { colorid = 35; }
            if (sender == yakutsk) { colorid = 36; }
            if (sender == japan) { colorid = 37; }
            if (sender == kamchatka) { colorid = 38; }
            if (sender == indonesia) { colorid = 39; }
            if (sender == newGuinea) { colorid = 40; }
            if (sender == easternAustralia) { colorid = 41; }
            if (sender == westernAustralia) { colorid = 42; }
            return colorid;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            territoryLabelClick(sender);
        }

        private void label12_Click(object sender, EventArgs e)
        {
            territoryLabelClick(sender);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            territoryLabelClick(sender);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            territoryLabelClick(sender);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            territoryLabelClick(sender);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            territoryLabelClick(sender);
        }

        private void label11_Click(object sender, EventArgs e)
        {
            territoryLabelClick(sender);
        }

        private void label13_Click(object sender, EventArgs e)
        {
            territoryLabelClick(sender);
        }

        private void label14_Click(object sender, EventArgs e)
        {
            territoryLabelClick(sender);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            beginGameGroup.Location = new Point(120, 66);
            playerCards[1] =  new int[] { 1, 2, 3, 2, 1, 2, 2, 3, 1, 2, 3 };
            playerCards[2] = new int[] { 1, 2, 3, 2, 2, 1, 2, 3, 1 };
        }

        private void label16_Click(object sender, EventArgs e)
        {
            territoryLabelClick(sender);
        }

        private void label15_Click(object sender, EventArgs e)
        {
            territoryLabelClick(sender);
        }

        private void label17_Click(object sender, EventArgs e)
        {
            territoryLabelClick(sender);
        }

        private void label18_Click(object sender, EventArgs e)
        {
            territoryLabelClick(sender);
        }

        private void label19_Click(object sender, EventArgs e)
        {
            territoryLabelClick(sender);
        }

        private void label20_Click(object sender, EventArgs e)
        {
            territoryLabelClick(sender);
        }

        private void label21_Click(object sender, EventArgs e)
        {
            territoryLabelClick(sender);
        }

        private void label22_Click(object sender, EventArgs e)
        {
            territoryLabelClick(sender);
        }

        private void label25_Click(object sender, EventArgs e)
        {
            territoryLabelClick(sender);
        }

        private void label24_Click(object sender, EventArgs e)
        {
            territoryLabelClick(sender);
        }

        private void label23_Click(object sender, EventArgs e)
        {
            territoryLabelClick(sender);
        }

        private void label26_Click(object sender, EventArgs e)
        {
            territoryLabelClick(sender);
        }

        private void label27_Click(object sender, EventArgs e)
        {
            territoryLabelClick(sender);
        }

        private void label28_Click(object sender, EventArgs e)
        {
            territoryLabelClick(sender);
        }

        private void label32_Click(object sender, EventArgs e)
        {
            territoryLabelClick(sender);
        }

        private void label33_Click(object sender, EventArgs e)
        {
            territoryLabelClick(sender);
        }

        private void label31_Click(object sender, EventArgs e)
        {
            territoryLabelClick(sender);
        }

        private void label29_Click(object sender, EventArgs e)
        {
            territoryLabelClick(sender);
        }

        private void label30_Click(object sender, EventArgs e)
        {
            territoryLabelClick(sender);
        }

        private void label36_Click(object sender, EventArgs e)
        {
            territoryLabelClick(sender);
        }

        private void label35_Click(object sender, EventArgs e)
        {
            territoryLabelClick(sender);
        }

        private void label34_Click(object sender, EventArgs e)
        {
            territoryLabelClick(sender);
        }

        private void label37_Click(object sender, EventArgs e)
        {
            territoryLabelClick(sender);
        }

        private void label38_Click(object sender, EventArgs e)
        {
            territoryLabelClick(sender);
        }

        private void label40_Click(object sender, EventArgs e)
        {
            territoryLabelClick(sender);
        }

        private void label41_Click(object sender, EventArgs e)
        {
            territoryLabelClick(sender);
        }

        private void label42_Click(object sender, EventArgs e)
        {
            territoryLabelClick(sender);
        }

        private void label39_Click(object sender, EventArgs e)
        {
            territoryLabelClick(sender);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            territoryLabelClick(sender);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            territoryLabelClick(sender);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            territoryLabelClick(sender);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            territoryLabelClick(sender);
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (turnPhase == 6)
            {
                diceBox.Visible = true;
                diceBox.Location = new Point(186, 105);
                armiesTrackBar.Visible = false;
                attackingArmies.Text = (armiesTrackBar.Value).ToString();
                deffendingArmies.Text = deffendingTroops.ToString();
                attackingMethod();
            }
        }
        private void attackingMethod()
        {
            Label lbl = defendingTerritory as Label;
            if (int.Parse(lbl.Text) <= 0)
            {
                finishAttacking(true);
            }
            else
            {
                int attackingamountv = int.Parse(attackingArmies.Text);
                int deffendingamountv = int.Parse(deffendingArmies.Text);
                turnPhase = 7;
                dice1.Visible = false;
                dice2.Visible = false;
                dice3.Visible = false;
                dice4.Visible = false;
                dice5.Visible = false;
                attackingTerritoryLabel.Text = findTerritoryStringName(attackingTerritory);
                deffendingTerritoryLabel.Text = findTerritoryStringName(defendingTerritory);
                if (attackingamountv > 0) { dice1.Visible = true; }
                if (attackingamountv > 1) { dice2.Visible = true; }
                if (attackingamountv > 2) { dice3.Visible = true; }
                if (deffendingamountv > 0) { dice4.Visible = true; }
                if (deffendingamountv > 1) { dice5.Visible = true; }
                attackingTim.Enabled = true;
                attackingTim.Start();
                dice1.Text = "0";
                dice2.Text = "0";
                dice3.Text = "0";
                dice4.Text = "0";
                dice5.Text = "0";
            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            if (turnPhase == 5)
            {
                turnPhase = 4;
                deffendingTerritoryText.Text = "";
                attackingTerritoryText.Text = "(choose)";
            }
            if (turnPhase == 6)
            {
                turnPhase = 5;
                attackingArmiesText.Text = "";
                armiesTrackBar.Visible = false;
                runGame();
            }
        }

        private void deployButton_Click(object sender, EventArgs e)
        {
            if (armiesUsed == armiesTotal)
            {
                turnPhase = 4;
                deployBox.Visible = false;
                attackingBox.Visible = true;
                runGame();
            }
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
                colorListBox3.SelectedItem != colorListBox2.SelectedItem && colorListBox3.SelectedItem != colorListBox1.SelectedItem)
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
                timup = 1;
                deployAlert.Visible = true;
                deployAlert.Location = new Point(317, 202);
                alertTimer();
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

        private void tim_Tick(object sender, EventArgs e)
        {
            tim.Stop();
            tim.Enabled = false;
            if (timup == 1)
            {
                deployAlert.Visible = false;
            }
            if (timup == 2)
            {
                attackingAlert.Visible = false;
            }
            if (timup == 3)
            {
                attackingAlert.Visible = false;
            }
            if (timup == 4)
            {
                diceBox.Visible = false;
                tim.Interval = 4000;
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

        private void commandButton_Click(object sender, EventArgs e)
        {
            if (commandText.Text == "phase 2 please") { armiesUsed = 0; armiesTotal = 0; initialdeployTroops();
                commandCenterGroup.Visible = false;
            }
            if (commandText.Text == "gimme cards") { getCards();
                commandCenterGroup.Visible = false;
            }
            if (commandText.Text == "gimme armies 10")
            {
                armiesTotal += 10;
            }
            if (commandText.Text == "")
            {
                commandCenterGroup.Visible = false;
            }
        }

        private void commandTimer_Tick(object sender, EventArgs e)
        {
            if (commandTest == 0)
            {
                label1.Visible = true;
                commandTest = 1;
                commandTimer.Interval = 5000;
            }
            else
            {
                if (commandTest == 1)
                {
                    commandTimer.Interval = 2000;
                    commandTest = 2;
                }
                else
                {
                    if (commandTest == 2)
                    {
                        commandTimer.Interval = 8000;
                        commandTest = 3;
                    }
                    else
                    {
                        if (commandTest == 3)
                        {
                            commandTest = 0;
                            commandTimer.Stop();
                            commandTimer.Enabled = false;
                        }
                    }
                }
            }


        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            if (commandTest == 0)
            {
                label1.Visible = false;
                commandTimer.Interval = 1000;
                commandTimer.Enabled = true;
                commandTimer.Start();
            }
            if (commandTest == 1 || commandTest == 3)
            {
                commandTimer.Stop();
                commandTest = 0;
            }
            if (commandTest == 2)
            {
                commandTimer.Stop();
                commandTest = 0;
                commandCenterGroup.Location = new Point(300, 200);
                commandCenterGroup.Visible = true;
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
            resetText();
            armiesUsed = 0;
            troopsDeployedText.Text = "(" + armiesUsed + "/" + armiesTotal + ")";
        }

        private void useCardButton_Click(object sender, EventArgs e)
        {
            if (selectedPlayerCards.Count == 3 && playerCards[playerNumber][selectedPlayerCards[0]] != playerCards[playerNumber][selectedPlayerCards[1]] && playerCards[playerNumber][selectedPlayerCards[0]] != playerCards[playerNumber][selectedPlayerCards[2]] && playerCards[playerNumber][selectedPlayerCards[1]] != playerCards[playerNumber][selectedPlayerCards[2]])
            {
                if (cardIncrementingSetting == true)
                {
                    armiesTotal += cardvalue;
                    cardvalue += 3;
                }
                else
                {
                    armiesTotal += 10;
                }
                removeCards(playerNumber, selectedPlayerCards);
                selectedPlayerCards.Clear();
                showCards();
            }
        }

        private void removeCards(int playerid, List<int> cardsToBeRemoved)
        {
            List<int> PlayerCardPlaceHolder = new List<int>();
            for (int x = 0; x < playerCards[playerid].Length; x++)
            {
                PlayerCardPlaceHolder.Add(playerCards[playerid][x]);
            }
            for (int x = 1; x < cardsToBeRemoved.Count; x++)
            {
                try
                {
                    for (int y = x; y < cardsToBeRemoved[y - 1]; y--)
                    {
                        int xv = cardsToBeRemoved[y - 1];
                        int yv = cardsToBeRemoved[y];
                        cardsToBeRemoved[y] = xv;
                        cardsToBeRemoved[y - 1] = yv;
                    }
                }
                catch
                {

                }
            }
            for (int x = 0; x < cardsToBeRemoved.Count; x++)
            {
                PlayerCardPlaceHolder.RemoveAt(cardsToBeRemoved[x]);
            }
            playerCards[playerid] = new int[PlayerCardPlaceHolder.Count];
            for (int x = 0; x < PlayerCardPlaceHolder.Count; x++)
            {
                playerCards[playerid][x] = PlayerCardPlaceHolder[x];
            }
        }

        private void beginTurnButton_Click(object sender, EventArgs e)
        {
            turnPhase = 3;
            armiesUsed = 0;
            newTurnBox.Visible = false;
            selectedPlayerCards.Clear();
            runGame();
        }

        private void armiesTrackBar_Scroll(object sender, EventArgs e)
        {
            if (turnPhase == 6)
            {
                attackingArmiesText.Text = (armiesTrackBar.Value).ToString();
            }
            if (turnPhase == 11)
            {
                transferredArmiesText.Text = (armiesTrackBar.Value).ToString();
            }
        }

        private void attackingTim_Tick(object sender, EventArgs e)
        {
            int attackingamountv = int.Parse(attackingArmies.Text);
            int deffendingamountv = int.Parse(deffendingArmies.Text);
            if (attackingtimCounter < 20)
            {
                Random rand1 = new Random();
                attackingtimCounter++;
                if (attackingamountv > 0)
                {
                    dice1.Text = ((rand1.Next(6) + 1)).ToString();
                }
                if (attackingamountv > 1)
                {
                    dice2.Text = ((rand1.Next(6) + 1)).ToString();
                }
                if (attackingamountv > 2)
                {
                    dice3.Text = ((rand1.Next(6) + 1)).ToString();
                }
                if (deffendingamountv > 0)
                {
                    dice4.Text = ((rand1.Next(6) + 1)).ToString();
                }
                if (deffendingamountv > 1)
                {
                    dice5.Text = ((rand1.Next(6) + 1)).ToString();
                }
            }
            else
            {
                attackingtimCounter = 0;
                attackingTim.Enabled = false;
                attackingTim.Stop();
                int highestAttackingDice, middleAttackingDice, highestDeffendingDice, middleDeffendingDice;
                if (int.Parse(dice3.Text) > int.Parse(dice2.Text) && int.Parse(dice3.Text) > int.Parse(dice1.Text))
                {
                    highestAttackingDice = int.Parse(dice3.Text);

                    if (int.Parse(dice2.Text) > int.Parse(dice1.Text))
                    {
                        middleAttackingDice = int.Parse(dice2.Text);
                    }
                    else
                    {
                        middleAttackingDice = int.Parse(dice1.Text);
                    }
                }
                else if (int.Parse(dice2.Text) > int.Parse(dice1.Text))
                {
                    highestAttackingDice = int.Parse(dice2.Text);

                    if (int.Parse(dice3.Text) > int.Parse(dice1.Text))
                    {
                        middleAttackingDice = int.Parse(dice3.Text);
                    }
                    else
                    {
                        middleAttackingDice = int.Parse(dice1.Text);
                    }
                }
                else
                {
                    highestAttackingDice = int.Parse(dice1.Text);
                    if (int.Parse(dice3.Text) > int.Parse(dice2.Text))
                    {
                        middleAttackingDice = int.Parse(dice3.Text);
                    }
                    else
                    {
                        middleAttackingDice = int.Parse(dice2.Text);
                    }
                }

                if (int.Parse(dice4.Text) > int.Parse(dice5.Text))
                {
                    highestDeffendingDice = int.Parse(dice4.Text);
                    middleDeffendingDice = int.Parse(dice5.Text);
                }
                else
                {
                    highestDeffendingDice = int.Parse(dice5.Text);
                    middleDeffendingDice = int.Parse(dice4.Text);
                }
                
                if (int.Parse(attackingArmies.Text) > 1 && int.Parse(deffendingArmies.Text) > 1)
                {
                    if (middleAttackingDice > middleDeffendingDice)
                    {
                        deffendingArmies.Text = (int.Parse(deffendingArmies.Text) - 1).ToString();
                    }
                    else
                    {
                        attackingArmies.Text = (int.Parse(attackingArmies.Text) - 1).ToString();
                    }
                }

                if (highestAttackingDice > highestDeffendingDice)
                {
                    deffendingArmies.Text = (int.Parse(deffendingArmies.Text) - 1).ToString();
                }
                else
                {
                    attackingArmies.Text = (int.Parse(attackingArmies.Text) - 1).ToString();
                }
                turnPhase = 6;
                if (int.Parse(attackingArmies.Text) == 0)
                {
                    finishAttacking(false);
                    resetAttacking();
                }
                if (int.Parse(deffendingArmies.Text) == 0)
                {
                    string colorid = color[senderdecryption(defendingTerritory)];
                    finishAttacking(true);
                    if (checkTerritoryAmount(colorid) == 0)
                    {
                        int defeatedPlayer = 0;
                        int playerOrderNumber = 0;
                        if (color1 == colorid) { playerOrderNumber = orderplayer1; defeatedPlayer = 1; }
                        if (color2 == colorid) { playerOrderNumber = orderplayer2; defeatedPlayer = 2; }
                        if (color3 == colorid) { playerOrderNumber = orderplayer3; defeatedPlayer = 3; }
                        if (color4 == colorid) { playerOrderNumber = orderplayer4; defeatedPlayer = 4; }
                        if (color5 == colorid) { playerOrderNumber = orderplayer5; defeatedPlayer = 5; }
                        if (color6 == colorid) { playerOrderNumber = orderplayer6; defeatedPlayer = 6; }
                        getLosersCards(defeatedPlayer);
                        removePlayer(playerOrderNumber);
                    }
                    if (winner == false)
                    {
                        winner = true;
                        getCards();
                    }
                }
            }
        }
        private void getCards()
        {
            int SIZE;
            int[] playerCardsSaved;
            try
            {
                SIZE = playerCards[playerNumber].Length;
                playerCardsSaved = new int[SIZE];
                for (int x = 0; x < SIZE; x++)
                {
                    playerCardsSaved[x] = playerCards[playerNumber][x];
                }
                playerCards[playerNumber] = new int[SIZE + 1];
                for (int x = 0; x < SIZE; x++)
                {
                    playerCards[playerNumber][x] = playerCardsSaved[x];
                }
                Random rand = new Random();
                playerCards[playerNumber][SIZE] = rand.Next(3) + 1;
            }
            catch
            {
                SIZE = 0;
                playerCards[playerNumber] = new int[SIZE + 1];
                Random rand = new Random();
                playerCards[playerNumber][SIZE] = rand.Next(3) + 1;
            }
            
        }

        private void getLosersCards(int defeatedPlayer)
        {
            List<int> defeatedCards = new List<int>();
            for (int x = 0; x < playerCards[defeatedPlayer].Length; x++)
            { defeatedCards.Add(playerCards[defeatedPlayer][x]); }
            try
            {
                AddSpecificCards(defeatedCards, playerNumber);
                removeCards(defeatedPlayer, defeatedCards);
            }
            catch
            { }
        }

        private void AddSpecificCards(List<int> addedCards, int cardGainer)
        {
            int cardHolderLength;
            try
            {
                int[] playerCardsPlaceHolder = new int[playerCards[cardGainer].Length];
                for (int x = 0; x < playerCardsPlaceHolder.Length; x++)
                {
                    playerCardsPlaceHolder[x] = playerCards[cardGainer][x];
                }
                playerCards[cardGainer] = new int[playerCardsPlaceHolder.Length + addedCards.Count];
                for (int x = 0; x < playerCardsPlaceHolder.Length; x++)
                {
                    playerCards[cardGainer][x] = playerCardsPlaceHolder[x];
                }
                cardHolderLength = playerCardsPlaceHolder.Length;
            }
            catch
            {
                cardHolderLength = 0;
            }
            for (int x = 0; x < addedCards.Count; x++)
            {
                playerCards[cardGainer][x + cardHolderLength] = addedCards[x];
            }
        }

        private void removePlayer(int playerOrderNumber)
        {
            string playerstuff = "";
            if (orderplayer1 == playerOrderNumber) { orderplayer1 = -1; playerstuff = player1Name; }
            if (orderplayer2 == playerOrderNumber) { orderplayer2 = -1; playerstuff = player2Name; }
            if (orderplayer3 == playerOrderNumber) { orderplayer3 = -1; playerstuff = player3Name; }
            if (orderplayer4 == playerOrderNumber) { orderplayer4 = -1; playerstuff = player4Name; }
            if (orderplayer5 == playerOrderNumber) { orderplayer5 = -1; playerstuff = player5Name; }
            if (orderplayer6 == playerOrderNumber) { orderplayer6 = -1; playerstuff = player6Name; }
            if (orderplayer1 > playerOrderNumber) { orderplayer1--; }
            if (orderplayer2 > playerOrderNumber) { orderplayer2--; }
            if (orderplayer3 > playerOrderNumber) { orderplayer3--; }
            if (orderplayer4 > playerOrderNumber) { orderplayer4--; }
            if (orderplayer5 > playerOrderNumber) { orderplayer5--; }
            if (orderplayer6 > playerOrderNumber) { orderplayer6--; }
            if (turn > playerOrderNumber) { turn--; }
            players--;
            if (players == 1)
            {
                MessageBox.Show("Player " + turnName + " WON!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Player " + playerstuff + " defeated!");
            }
        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void stopAttackingButton_Click(object sender, EventArgs e)
        {
            if (attackingTim.Enabled == false)
            {
                finishAttacking(false);
                resetAttacking();
            }
        }

        private void resetAttacking()
        {
            turnPhase = 4;
            diceBox.Visible = false;
            attackingArmiesText.Text = "";
            deffendingTerritoryText.Text = "";
            attackingTerritoryText.Text = "(choose)";
            attackingTerritory = "";
            defendingTerritory = "";
        }

        private void continueAttackingButton_Click(object sender, EventArgs e)
        {
            if (turnPhase == 6 && attackingTim.Enabled == false)
            {
                attackingMethod();
            }
        }

        private void winTransferTrackBar_Scroll(object sender, EventArgs e)
        {
            int basetransferringValue = originalTransferringValue - winTransferTrackBar.Value + winTransferTrackBar.Maximum;
            if (winTransferGroup.Visible == true)
            {
                winTransferAmount.Text = (winTransferTrackBar.Value).ToString();

                Label lbl = attackingTerritory as Label;
                lbl.Text = (basetransferringValue).ToString();

                lbl = defendingTerritory as Label;
                lbl.Text = (winTransferTrackBar.Value).ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            winTransferGroup.Visible = false;
            resetAttacking();
        }

        private void finishAttackingButton_Click(object sender, EventArgs e)
        {
            attackingTerritory = "";
            defendingTerritory = "";
            attackingArmiesText.Text = "";
            attackingBox.Visible = false;
            transferBox.Visible = true;
            turnPhase = 9;
            runGame();
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
                    randomLabel16.Visible = false;
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

        private void transferButton_Click(object sender, EventArgs e)
        {
            if (turnPhase == 11)
            {
                int subtractedValue = int.Parse(transferredArmiesText.Text);
                Label lbl = attackingTerritory as Label;
                lbl.Text = (int.Parse(lbl.Text) - subtractedValue).ToString();
                lbl = defendingTerritory as Label;
                lbl.Text = (int.Parse(lbl.Text) + subtractedValue).ToString();
            }
            sourceTerritoryText.Text = "";
            receivingTerritoryText.Text = "";
            transferredArmiesText.Text = "";
            endTurn();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (turnPhase == 10)
            {
                turnPhase = 9;
                receivingTerritoryText.Text = "";
                runGame();
            }
            if (turnPhase == 11)
            {
                turnPhase = 10;
                transferredArmiesText.Text = "";
                armiesTrackBar.Visible = false;
                defendingTerritory = "";
                runGame();
            }
        }

        private void checkTurn()
        {
            if (orderplayer1 == turn)
            {
                turnColor = color1;
                turnName = player1Name;
                playerNumber = 1;
            }
            if (orderplayer2 == turn)
            {
                turnColor = color2;
                turnName = player2Name;
                playerNumber = 2;
            }
            if (orderplayer3 == turn)
            {
                turnColor = color3;
                turnName = player3Name;
                playerNumber = 3;
            }
            if (orderplayer4 == turn)
            {
                turnColor = color4;
                turnName = player4Name;
                playerNumber = 4;
            }
            if (orderplayer5 == turn)
            {
                turnColor = color5;
                turnName = player5Name;
                playerNumber = 5;
            }
            if (orderplayer6 == turn)
            {
                turnColor = color6;
                turnName = player6Name;
                playerNumber = 6;
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cardClick(sender, 0);
        }

        private void CardPic2_Click(object sender, EventArgs e)
        {
            cardClick(sender, 1);
        }

        private void CardPic3_Click(object sender, EventArgs e)
        {
            cardClick(sender, 2);
        }

        private void CardPic4_Click(object sender, EventArgs e)
        {
            cardClick(sender, 3);
        }

        private void CardPic5_Click(object sender, EventArgs e)
        {
            cardClick(sender, 4);
        }

        private void cardClick(object sender, int id)
        {
            PictureBox pic = sender as PictureBox;
            if (pic.BorderStyle == BorderStyle.None)
            {
                pic.BorderStyle = BorderStyle.FixedSingle;
                selectedPlayerCards.Add(id + ((page - 1) * 5));
            }
            else
            {
                pic.BorderStyle = BorderStyle.None;
                selectedPlayerCards.Remove(id + ((page - 1) * 5));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            page--;
            showCards();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            page++;
            showCards();
        }

        private void initialdeployTroops()//A method that controls the transitions between players during the beginning game setup.
        {
            turnPhase = 1;
            choosingBox.Visible = true;
            randomLabel5.Text = turnName + "'s turn " + "(" + armiesUsed + "/" + armiesTotal + ")" + "(" + turnColor + ")";
            if (armiesUsed == armiesTotal)
            {
                turnPhase = 2;
                turn = 1;
                choosingBox.Visible = false;
                runGame();
                checkUnclaimed();
            }
            else
            {
                if (turn == players)//If all the players have gone through their turn, perform the following actions.
                {
                    armiesUsed++;//Add one to the armies used.
                    turn = 1;//Reset turn.
                }
                else
                {
                    turn++;//Go to next turn.
                }
            }
        }
        private void deployedTroop()
        {
            armiesUsed++;
            troopsDeployedText.Text = "(" + armiesUsed + "/" + armiesTotal + ")";
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            settingsPanel.Location = new Point(29, 14);
            settingsPanel.Visible = true;
        }

        private void closeSettingsPanel_Click(object sender, EventArgs e)
        {
            settingsPanel.Visible = false;
            cardIncrementingSetting = cardIncreasingSettingCheckBox.Checked;
        }

        private void showCards()//takes card data and uses it to display them on the newTurnBox.
        {
            CardPic1.Visible = false;
            CardPic2.Visible = false;
            CardPic3.Visible = false;
            CardPic4.Visible = false;
            CardPic5.Visible = false;
            try
            {
                int x = (page - 1) * 5;
                while (x < page * 5)
                {
                    if (playerCards[playerNumber].Length > x)
                    {
                        int y = x - ((page - 1) * 5);
                        if (y == 0) { CheckCardType(x, CardPic1); }
                        if (y == 1) { CheckCardType(x, CardPic2); }
                        if (y == 2) { CheckCardType(x, CardPic3); }
                        if (y == 3) { CheckCardType(x, CardPic4); }
                        if (y == 4) { CheckCardType(x, CardPic5); }
                    }
                    x++;
                }
                if (playerCards[playerNumber].Length > page * 5)
                {
                    cardRightPageTurnButton.Visible = true;
                }
                else
                {
                    cardRightPageTurnButton.Visible = false;
                }
                if (page > 1)
                {
                    cardLeftPageTurnButton.Visible = true;
                }
                else
                {
                    cardLeftPageTurnButton.Visible = false;
                }
            }
            catch
            {

            }
        }
        private void CheckCardType(int x, PictureBox pic)
        {
            pic.Visible = true;
            if (playerCards[playerNumber][x] == 1)
            {
                pic.Image = Properties.Resources.King_Spades;
                pic.Refresh();
            }
            if (playerCards[playerNumber][x] == 2)
            {
                pic.Image = Properties.Resources.Queen_Spades;
                pic.Refresh();
            }
            if (playerCards[playerNumber][x] == 3)
            {
                pic.Image = Properties.Resources.Jack_Spades__1_;
                pic.Refresh();
            }

            if (selectedPlayerCards.IndexOf(x) != -1)
            {
                pic.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                pic.BorderStyle = BorderStyle.None;
            }
        }
        private void runGame()// This is a sort of hub for the actual running of the game, methods return here if they are transitioning a phase.
        {
            if (turnPhase == 2)
            {
                winner = false;
                checkTurn();
                newTurnBox.Visible = true;
                newTurnBox.Location = new Point(268, 199);
                newTurnBox.Text = "Begin Turn: " + turnName;
                page = 1;
                showCards();
                armiesTotal = 0;
                checkArmyGain();
            }
            if (turnPhase == 3)
            {
                recordPresentArmyData();
                timup = 1;
                deployAlert.Visible = true;
                deployAlert.Location = new Point(317, 202);
                deployBox.Visible = true;
                deployBox.Text = "Deploy Troops: " + turnName + " (" + turnColor + ")";
                troopsDeployedText.Text = "(" + armiesUsed + "/" + armiesTotal + ")";
                attackingBox.Text = "Attack: " + turnName + " (" + turnColor + ")";
                transferBox.Text = "Transfer Troops: " + turnName + " (" + turnColor + ")";
                alertTimer();
            }
            if (turnPhase == 4)
            {
                timup = 3;
                attackingAlert.Visible = true;
                attackingAlert.Location = new Point(317, 202);
                alertTimer();
                attackingTerritoryText.Text = "(choose)";
            }
            if (turnPhase == 5 && armiesTrackBar.Maximum > 0)
            {
                attackingTerritoryText.Text = findTerritoryStringName(attackingTerritory);
                deffendingTerritoryText.Text = "(choose)";
            }
            if (turnPhase == 6)
            {
                deffendingTerritoryText.Text = findTerritoryStringName(defendingTerritory);
                armiesTrackBar.Visible = true;
                armiesTrackBar.Value = armiesTrackBar.Maximum;
                attackingArmiesText.Text = (armiesTrackBar.Maximum).ToString();
            }
            if (turnPhase == 9)
            {
                sourceTerritoryText.Text = "(choose)";
                transferButton.Text = "skip";
            }
            if (turnPhase == 10)
            {
                sourceTerritoryText.Text = findTerritoryStringName(attackingTerritory);
                receivingTerritoryText.Text = "(choose)";
                transferButton.Text = "skip";
            }
            if (turnPhase == 11)
            {
                receivingTerritoryText.Text = findTerritoryStringName(defendingTerritory);
                armiesTrackBar.Visible = true;
                Label lbl = attackingTerritory as Label;
                armiesTrackBar.Maximum = int.Parse(lbl.Text) - 1;
                armiesTrackBar.Value = armiesTrackBar.Maximum;
                transferredArmiesText.Text = (armiesTrackBar.Maximum).ToString();
                transferButton.Text = "Transfer";
            }
        }

        private void endTurn()
        {
            armiesTrackBar.Visible = false;
            transferBox.Visible = false;
            attackingTerritory = "";
            defendingTerritory = "";
            turnPhase = 2;
            if (turn < players)
            {
                turn++;
            }
            else
            {
                turn = 1;
            }
            runGame();
        }

        private void alertTimer()
        {
            tim.Interval = 1000;
            tim.Enabled = true;
            tim.Start();
        }
        private void checkUnclaimed()
        {
            if (argentina.Text == "+") { argentina.Text = "0"; }
            if (venezuela.Text == "+") { venezuela.Text = "0"; }
            if (brazil.Text == "+") { brazil.Text = "0"; }
            if (peru.Text == "+") { peru.Text = "0"; }
            if (centralAmerica.Text == "+") { centralAmerica.Text = "0"; }
            if (easternUnitedStates.Text == "+") { easternUnitedStates.Text = "0"; }
            if (quebec.Text == "+") { quebec.Text = "0"; }
            if (westernUnitedStates.Text == "+") { westernUnitedStates.Text = "0"; }
            if (ontario.Text == "+") { ontario.Text = "0"; }
            if (alberta.Text == "+") { alberta.Text = "0"; }
            if (alaska.Text == "+") { alaska.Text = "0"; }
            if (northWestTerritory.Text == "+") { northWestTerritory.Text = "0"; }
            if (greenLand.Text == "+") { greenLand.Text = "0"; }
            if (northAfrica.Text == "+") { northAfrica.Text = "0"; }
            if (egypt.Text == "+") { egypt.Text = "0"; }
            if (eastAfrica.Text == "+") { eastAfrica.Text = "0"; }
            if (congo.Text == "+") { congo.Text = "0"; }
            if (southAfrica.Text == "+") { southAfrica.Text = "0"; }
            if (madagascar.Text == "+") { madagascar.Text = "0"; }
            if (westernEurope.Text == "+") { westernEurope.Text = "0"; }
            if (southernEurope.Text == "+") { southernEurope.Text = "0"; }
            if (northernEurope.Text == "+") { northernEurope.Text = "0"; }
            if (greatBritain.Text == "+") { greatBritain.Text = "0"; }
            if (ukraine.Text == "+") { ukraine.Text = "0"; }
            if (scandinavia.Text == "+") { scandinavia.Text = "0"; }
            if (iceland.Text == "+") { iceland.Text = "0"; }
            if (middleEast.Text == "+") { middleEast.Text = "0"; }
            if (afghanistan.Text == "+") { afghanistan.Text = "0"; }
            if (india.Text == "+") { india.Text = "0"; }
            if (siam.Text == "+") { siam.Text = "0"; }
            if (china.Text == "+") { china.Text = "0"; }
            if (ural.Text == "+") { ural.Text = "0"; }
            if (mongolia.Text == "+") { mongolia.Text = "0"; }
            if (siberia.Text == "+") { siberia.Text = "0"; }
            if (yakutsk.Text == "+") { yakutsk.Text = "0"; }
            if (irkutsk.Text == "+") { irkutsk.Text = "0"; }
            if (japan.Text == "+") { japan.Text = "0"; }
            if (kamchatka.Text == "+") { kamchatka.Text = "0"; }
            if (indonesia.Text == "+") { indonesia.Text = "0"; }
            if (newGuinea.Text == "+") { newGuinea.Text = "0"; }
            if (westernAustralia.Text == "+") { westernAustralia.Text = "0"; }
            if (easternAustralia.Text == "+") { easternAustralia.Text = "0"; }


        }

        private int checkTerritoryAmount(string checkedColor)
        {
            int x = 0;
            int y = 1;
            while (y <= 42)
            {
                if (color[y] == checkedColor) { x++; }
                y++;
            }
            return x;
        }

        private void checkArmyGain()
        {
            int x = checkTerritoryAmount(turnColor);
            armiesTotal += x / 3;
            if (armiesTotal < 1) { armiesTotal = 1; }
            if (color[1] == turnColor && color[2] == turnColor && color[3] == turnColor && color[4] == turnColor)
            {
                armiesTotal += 2;
            }
            if (color[39] == turnColor && color[40] == turnColor && color[41] == turnColor && color[42] == turnColor)
            {
                armiesTotal += 2;
            }
            if (color[21] == turnColor && color[22] == turnColor && color[23] == turnColor && color[24] == turnColor && color[25] == turnColor && color[26] == turnColor)
            {
                armiesTotal += 3;
            }
            if (color[5] == turnColor && color[6] == turnColor && color[7] == turnColor && color[8] == turnColor && color[9] == turnColor && color[10] == turnColor && color[11] == turnColor && color[12] == turnColor && color[13] == turnColor)
            {
                armiesTotal += 5;
            }
            if (color[14] == turnColor && color[15] == turnColor && color[16] == turnColor && color[17] == turnColor && color[18] == turnColor && color[19] == turnColor && color[20] == turnColor)
            {
                armiesTotal += 5;
            }
            if (color[27] == turnColor && color[28] == turnColor && color[29] == turnColor && color[30] == turnColor && color[31] == turnColor && color[32] == turnColor && color[33] == turnColor && color[34] == turnColor && color[35] == turnColor && color[36] == turnColor && color[37] == turnColor && color[38] == turnColor)
            {
                armiesTotal += 7;
            }
        }
        private void recordPresentArmyData()
        {

            numberData[0] = argentina.Text;
            numberData[1] = venezuela.Text;
            numberData[2] = brazil.Text;
            numberData[3] = peru.Text;
            numberData[4] = centralAmerica.Text;
            numberData[5] = easternUnitedStates.Text;
            numberData[6] = quebec.Text;
            numberData[7] = westernUnitedStates.Text;
            numberData[8] = ontario.Text;
            numberData[9] = alberta.Text;
            numberData[10] = alaska.Text;
            numberData[11] = northWestTerritory.Text;
            numberData[12] = greenLand.Text;
            numberData[13] = northAfrica.Text;
            numberData[14] = egypt.Text;
            numberData[15] = eastAfrica.Text;
            numberData[16] = congo.Text;
            numberData[17] = southAfrica.Text;
            numberData[18] = madagascar.Text;
            numberData[19] = westernEurope.Text;
            numberData[20] = southernEurope.Text;
            numberData[21] = northernEurope.Text;
            numberData[22] = greatBritain.Text;
            numberData[23] = ukraine.Text;
            numberData[24] = scandinavia.Text;
            numberData[25] = iceland.Text;
            numberData[26] = middleEast.Text;
            numberData[27] = afghanistan.Text;
            numberData[28] = india.Text;
            numberData[29] = siam.Text;
            numberData[30] = china.Text;
            numberData[31] = ural.Text;
            numberData[32] = mongolia.Text;
            numberData[33] = siberia.Text;
            numberData[34] = yakutsk.Text;
            numberData[35] = irkutsk.Text;
            numberData[36] = japan.Text;
            numberData[37] = kamchatka.Text;
            numberData[38] = indonesia.Text;
            numberData[39] = newGuinea.Text;
            numberData[40] = westernAustralia.Text;
            numberData[41] = easternAustralia.Text;
        }
        private void resetText()
        {
            argentina.Text = numberData[0];
            venezuela.Text = numberData[1];
            brazil.Text = numberData[2];
            peru.Text = numberData[3];
            centralAmerica.Text = numberData[4];
            easternUnitedStates.Text = numberData[5];
            quebec.Text = numberData[6];
            westernUnitedStates.Text = numberData[7];
            ontario.Text = numberData[8];
            alberta.Text = numberData[9];
            alaska.Text = numberData[10];
            northWestTerritory.Text = numberData[11];
            greenLand.Text = numberData[12];
            northAfrica.Text = numberData[13];
            egypt.Text = numberData[14];
            eastAfrica.Text = numberData[15];
            congo.Text = numberData[16];
            southAfrica.Text = numberData[17];
            madagascar.Text = numberData[18];
            westernEurope.Text = numberData[19];
            southernEurope.Text = numberData[20];
            northernEurope.Text = numberData[21];
            greatBritain.Text = numberData[22];
            ukraine.Text = numberData[23];
            scandinavia.Text = numberData[24];
            iceland.Text = numberData[25];
            middleEast.Text = numberData[26];
            afghanistan.Text = numberData[27];
            india.Text = numberData[28];
            siam.Text = numberData[29];
            china.Text = numberData[30];
            ural.Text = numberData[31];
            mongolia.Text = numberData[32];
            siberia.Text = numberData[33];
            yakutsk.Text = numberData[34];
            irkutsk.Text = numberData[35];
            japan.Text = numberData[36];
            kamchatka.Text = numberData[37];
            indonesia.Text = numberData[38];
            newGuinea.Text = numberData[39];
            westernAustralia.Text = numberData[40];
            easternAustralia.Text = numberData[41];
        }
        private bool CheckIfAdjacent(object territory, object source)
        {
            bool adjacent = false;
            if ((territory == argentina && (source == brazil || source == peru)) ||
                (territory == peru && (source == brazil || source == argentina || source == venezuela)) ||
                (territory == venezuela && (source == brazil || source == peru || source == centralAmerica)) ||
                (territory == brazil && (source == northAfrica || source == argentina || source == venezuela)) ||
                (territory == centralAmerica && (source == venezuela || source == easternUnitedStates || source == westernUnitedStates)) ||
                (territory == easternUnitedStates && (source == westernUnitedStates || source == centralAmerica || source == alberta || source == ontario)) ||
                (territory == westernUnitedStates && (source == centralAmerica || source == easternUnitedStates || source == quebec || source == ontario)) ||
                (territory == quebec && (source == ontario || source == greenLand || source == easternUnitedStates)) ||
                (territory == ontario && (source == quebec || source == easternUnitedStates || source == westernUnitedStates || source == alberta || source == northWestTerritory || source == alaska || source == greenLand)) ||
                (territory == alberta && (source == ontario || source == northWestTerritory || source == alaska || source == westernUnitedStates)) ||
                (territory == alaska && (source == northWestTerritory || source == alberta || source == kamchatka)) ||
                (territory == northWestTerritory && (source == alaska || source == alberta || source == ontario || source == greenLand)) ||
                (territory == greenLand && (source == quebec || source == ontario || source == northWestTerritory || source == iceland)) ||
                (territory == iceland && (source == scandinavia || source == greatBritain || source == greenLand)) ||
                (territory == scandinavia && (source == iceland || source == greatBritain || source == ukraine || source == northernEurope)) ||
                (territory == greatBritain && (source == northernEurope || source == westernEurope || source == scandinavia || source == iceland)) ||
                (territory == westernEurope && (source == northAfrica || source == northernEurope || source == greatBritain || source == southernEurope)) ||
                (territory == southernEurope && (source == westernEurope || source == northAfrica || source == egypt || source == ukraine || source == middleEast || source == northernEurope)) ||
                (territory == northernEurope && (source == southernEurope || source == westernEurope || source == greatBritain || source == scandinavia || source == ukraine)) ||
                (territory == ukraine && (source == scandinavia || source == northernEurope || source == southernEurope || source == middleEast || source == afghanistan || source == ural)) ||
                (territory == northAfrica && (source == egypt || source == eastAfrica || source == congo || source == brazil || source == southernEurope || source == westernEurope)) ||
                (territory == egypt && (source == northAfrica || source == southernEurope || source == middleEast || source == eastAfrica)) ||
                (territory == eastAfrica && (source == northAfrica || source == middleEast || source == egypt || source == congo || source == southAfrica || source == madagascar)) ||
                (territory == congo && (source == northAfrica || source == southAfrica || source == eastAfrica)) ||
                (territory == southAfrica && (source == congo || source == eastAfrica || source == madagascar)) ||
                (territory == madagascar && (source == southAfrica || source == eastAfrica)) ||
                (territory == easternAustralia && (source == westernAustralia || source == newGuinea)) ||
                (territory == westernAustralia && (source == easternAustralia || source == newGuinea)) ||
                (territory == newGuinea && (source == westernAustralia || source == indonesia || source == easternAustralia)) ||
                (territory == indonesia && (source == newGuinea || source == siam)) ||
                (territory == siam && (source == india || source == china || source == indonesia)) ||
                (territory == india && (source == siam || source == china || source == middleEast || source == afghanistan)) ||
                (territory == middleEast && (source == eastAfrica || source == northAfrica || source == southernEurope || source == ukraine || source == afghanistan || source == india)) ||
                (territory == afghanistan && (source == ukraine || source == middleEast || source == india || source == china || source == ural)) ||
                (territory == china && (source == siberia || source == ural || source == afghanistan || source == india || source == siam || source == mongolia)) ||
                (territory == ural && (source == ukraine || source == afghanistan || source == china || source == siberia)) ||
                (territory == siberia && (source == ural || source == china || source == mongolia || source == irkutsk || source == yakutsk)) ||
                (territory == mongolia && (source == japan || source == china || source == siberia || source == irkutsk || source == kamchatka)) ||
                (territory == irkutsk && (source == siberia || source == mongolia || source == kamchatka || source == yakutsk)) ||
                (territory == yakutsk && (source == irkutsk || source == siberia || source == kamchatka)) ||
                (territory == japan && (source == kamchatka || source == mongolia || source == venezuela)) ||
                (territory == kamchatka && (source == alaska || source == irkutsk || source == yakutsk || source == mongolia || source == japan))
                )
            {
                adjacent = true;
            }
            return adjacent;
        }
        private void finishAttacking(bool win)
        {
            int totalValue = int.Parse(attackingArmies.Text) - int.Parse(attackingArmiesText.Text);
            if (win == true)
            {
                diceBox.Visible = false;
                winTransferGroup.Visible = true;
                winTransferTrackBar.Maximum = int.Parse(attackingArmies.Text);
                winTransferTrackBar.Value = winTransferTrackBar.Maximum;
                deffendingArmies.Text = (winTransferTrackBar.Maximum).ToString();
                totalValue = - int.Parse(attackingArmiesText.Text);
                winTransferAmount.Text = (winTransferTrackBar.Value).ToString();
            }
            Label lbl = attackingTerritory as Label;
            lbl.Text = (int.Parse(lbl.Text) + totalValue).ToString(); originalTransferringValue = int.Parse(lbl.Text);

            lbl = defendingTerritory as Label;

            lbl.Text = deffendingArmies.Text;
            if (win == true)
            { setColorTerritory(lbl, senderdecryption(defendingTerritory)); }
        }
    }
}

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
        string color1, color2, color3, color4, color5, color6;
        string player1Name = "";
        string player2Name = "";
        string player3Name = "";
        string player4Name = "";
        string player5Name = "";
        string player6Name = "";
        string attackingTerritory;
        string defendingTerritory;
        string argentinaColor;
        string venezuelaColor;
        string peruColor;
        string brazilColor;
        string centralAmericaColor;
        string westernUnitedStatesColor;
        string easternUnitedStatesColor;
        string ontarioColor;
        string albertaColor;
        string quebecColor;
        string alaskaColor;
        string northWestTerritoryColor;
        string greenlandColor;
        string icelandColor;
        string scandinaviaColor;
        string greatBritainColor;
        string northernEuropeColor;
        string southernEuropeColor;
        string westernEuropeColor;
        string ukraineColor;
        string northAfricaColor;
        string egyptColor;
        string eastAfricaColor;
        string congoColor;
        string southAfricaColor;
        string madagascarColor;
        string middleEastColor;
        string afghanistanColor;
        string indiaColor;
        string chinaColor;
        string siamColor;
        string uralColor;
        string siberiaColor;
        string mongoliaColor;
        string irkutskColor;
        string yakutskColor;
        string kamchatkaColor;
        string japanColor;
        string indonesiaColor;
        string newGuineaColor;
        string westernAustraliaColor;
        string easternAustraliaColor;
        Boolean attacking = true;
        int turn;
        string turnColor, turnName;
        int turnPhase = 0;
        int players;
        int orderplayer1, orderplayer2, orderplayer3, orderplayer4, orderplayer5, orderplayer6;
        int armiesUsed, armiesTotal;
        int timup = 0;
        int commandTest = 0;
        string[] numberData = new string[42];
        public RiskBoard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            argentina.Visible = false;
            if (turnPhase == 3 && argentinaColor == turnColor && armiesUsed != armiesTotal)
            {
                argentina.Text = (int.Parse(argentina.Text) + 1).ToString();
                deployedTroop();
            }
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
                    argentinaColor = turnColor;
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
                        argentina.BackColor = System.Drawing.Color.Green;
                        argentina.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        argentina.BackColor = System.Drawing.Color.Tan;
                        argentina.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        argentina.BackColor = System.Drawing.Color.MediumPurple;
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
                if ((turnColor == "red" && argentina.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && argentina.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && argentina.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && argentina.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && argentina.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && argentina.BackColor == System.Drawing.Color.Pink))
                {
                    argentina.Text = (int.Parse(argentina.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            }
            argentina.Visible = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            madagascar.Visible = false;
            if (attacking == false)
            {
                attackingTerritory = "Madagascar";
                attackingmethod();
            }
            if (turnPhase == 1)
            {
                if (madagascar.BackColor == System.Drawing.Color.Transparent)
                {
                    madagascarColor = turnColor;
                    if (turnColor == "red")
                    {
                        madagascar.BackColor = System.Drawing.Color.Red;
                        madagascar.Text = "1";
                    }
                    if (turnColor == "blue")
                    {
                        madagascar.BackColor = System.Drawing.Color.LightBlue;
                        madagascar.Text = "1";
                    }

                    if (turnColor == "green")
                    {
                        madagascar.BackColor = System.Drawing.Color.Green;
                        madagascar.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        madagascar.BackColor = System.Drawing.Color.Tan;
                        madagascar.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        madagascar.BackColor = System.Drawing.Color.MediumPurple;
                        madagascar.Text = "1";
                    }

                    if (turnColor == "pink")
                    {
                        madagascar.BackColor = System.Drawing.Color.Pink;
                        madagascar.Text = "1";
                    }
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && madagascar.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && madagascar.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && madagascar.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && madagascar.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && madagascar.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && madagascar.BackColor == System.Drawing.Color.Pink))
                {
                    madagascar.Text = (int.Parse(madagascar.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            }
            madagascar.Visible = true;

        }

        private void label12_Click(object sender, EventArgs e)
        {
            westernUnitedStates.Visible = false;
            if (attacking == false)
            {
                attackingTerritory = "Western United States";
                attackingmethod();
            }
            if (turnPhase == 1)
            {
                if (westernUnitedStates.BackColor == System.Drawing.Color.Transparent)
                {
                    westernUnitedStatesColor = turnColor;
                    if (turnColor == "red")
                    {
                        westernUnitedStates.BackColor = System.Drawing.Color.Red;
                        westernUnitedStates.Text = "1";
                    }
                    if (turnColor == "blue")
                    {
                        westernUnitedStates.BackColor = System.Drawing.Color.LightBlue;
                        westernUnitedStates.Text = "1";
                    }

                    if (turnColor == "green")
                    {
                        westernUnitedStates.BackColor = System.Drawing.Color.Green;
                        westernUnitedStates.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        westernUnitedStates.BackColor = System.Drawing.Color.Tan;
                        westernUnitedStates.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        westernUnitedStates.BackColor = System.Drawing.Color.MediumPurple;
                        westernUnitedStates.Text = "1";
                    }

                    if (turnColor == "pink")
                    {
                        westernUnitedStates.BackColor = System.Drawing.Color.Pink;
                        westernUnitedStates.Text = "1";
                    }
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && westernUnitedStates.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && westernUnitedStates.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && westernUnitedStates.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && westernUnitedStates.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && westernUnitedStates.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && westernUnitedStates.BackColor == System.Drawing.Color.Pink))
                {
                    westernUnitedStates.Text = (int.Parse(westernUnitedStates.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            }
            westernUnitedStates.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            brazil.Visible = false;
            if (attacking == false)
            {
                attackingTerritory = "Brazil";
                attackingmethod();
            }
            if (turnPhase == 1)
            {
                if (brazil.BackColor == System.Drawing.Color.Transparent)
                {
                    brazilColor = turnColor;
                    if (turnColor == "red")
                    {
                        brazil.BackColor = System.Drawing.Color.Red;
                        brazil.Text = "1";
                    }
                    if (turnColor == "blue")
                    {
                        brazil.BackColor = System.Drawing.Color.LightBlue;
                        brazil.Text = "1";
                    }

                    if (turnColor == "green")
                    {
                        brazil.BackColor = System.Drawing.Color.Green;
                        brazil.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        brazil.BackColor = System.Drawing.Color.Tan;
                        brazil.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        brazil.BackColor = System.Drawing.Color.MediumPurple;
                        brazil.Text = "1";
                    }

                    if (turnColor == "pink")
                    {
                        brazil.BackColor = System.Drawing.Color.Pink;
                        brazil.Text = "1";
                    }
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && brazil.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && brazil.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && brazil.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && brazil.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && brazil.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && brazil.BackColor == System.Drawing.Color.Pink))
                {
                    brazil.Text = (int.Parse(brazil.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            }
            brazil.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            peru.Visible = false;
            if (attacking == false)
            {
                attackingTerritory = "Peru";
                attackingmethod();
            }
            if (turnPhase == 1)
            {
                if (peru.BackColor == System.Drawing.Color.Transparent)
                {
                    peruColor = turnColor;
                    if (turnColor == "red")
                    {
                        peru.BackColor = System.Drawing.Color.Red;
                        peru.Text = "1";
                    }
                    if (turnColor == "blue")
                    {
                        peru.BackColor = System.Drawing.Color.LightBlue;
                        peru.Text = "1";
                    }

                    if (turnColor == "green")
                    {
                        peru.BackColor = System.Drawing.Color.Green;
                        peru.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        peru.BackColor = System.Drawing.Color.Tan;
                        peru.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        peru.BackColor = System.Drawing.Color.MediumPurple;
                        peru.Text = "1";
                    }

                    if (turnColor == "pink")
                    {
                        peru.BackColor = System.Drawing.Color.Pink;
                        peru.Text = "1";
                    }
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && peru.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && peru.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && peru.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && peru.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && peru.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && peru.BackColor == System.Drawing.Color.Pink))
                {
                    peru.Text = (int.Parse(peru.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            }
            peru.Visible = true;

        }

        private void label4_Click(object sender, EventArgs e)
        {
            venezuela.Visible = false;
            if (attacking == false)
            {
                attackingTerritory = "Venezuela";
                attackingmethod();
            }
            if (turnPhase == 1)
            {
                if (venezuela.BackColor == System.Drawing.Color.Transparent)
                {
                    venezuelaColor = turnColor;
                    if (turnColor == "red")
                    {
                        venezuela.BackColor = System.Drawing.Color.Red;
                        venezuela.Text = "1";
                    }
                    if (turnColor == "blue")
                    {
                        venezuela.BackColor = System.Drawing.Color.LightBlue;
                        venezuela.Text = "1";
                    }

                    if (turnColor == "green")
                    {
                        venezuela.BackColor = System.Drawing.Color.Green;
                        venezuela.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        venezuela.BackColor = System.Drawing.Color.Tan;
                        venezuela.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        venezuela.BackColor = System.Drawing.Color.MediumPurple;
                        venezuela.Text = "1";
                    }

                    if (turnColor == "pink")
                    {
                        venezuela.BackColor = System.Drawing.Color.Pink;
                        venezuela.Text = "1";
                    }
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && venezuela.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && venezuela.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && venezuela.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && venezuela.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && venezuela.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && venezuela.BackColor == System.Drawing.Color.Pink))
                {
                    venezuela.Text = (int.Parse(venezuela.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            }
            venezuela.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            northAfrica.Visible = false;
            if (attacking == false)
            {
                attackingTerritory = "North Africa";
                attackingmethod();
            }
            if (turnPhase == 1)
            {
                if (northAfrica.BackColor == System.Drawing.Color.Transparent)
                {
                    northAfricaColor = turnColor;
                    if (turnColor == "red")
                    {
                        northAfrica.BackColor = System.Drawing.Color.Red;
                        northAfrica.Text = "1";
                    }
                    if (turnColor == "blue")
                    {
                        northAfrica.BackColor = System.Drawing.Color.LightBlue;
                        northAfrica.Text = "1";
                    }

                    if (turnColor == "green")
                    {
                        northAfrica.BackColor = System.Drawing.Color.Green;
                        northAfrica.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        northAfrica.BackColor = System.Drawing.Color.Tan;
                        northAfrica.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        northAfrica.BackColor = System.Drawing.Color.MediumPurple;
                        northAfrica.Text = "1";
                    }

                    if (turnColor == "pink")
                    {
                        northAfrica.BackColor = System.Drawing.Color.Pink;
                        northAfrica.Text = "1";
                    }
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && northAfrica.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && northAfrica.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && northAfrica.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && northAfrica.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && northAfrica.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && northAfrica.BackColor == System.Drawing.Color.Pink))
                {
                    northAfrica.Text = (int.Parse(northAfrica.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            }
            northAfrica.Visible = true;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            centralAmerica.Visible = false;
            if (attacking == false)
            {
                attackingTerritory = "Central America";
                attackingmethod();
            }
            if (turnPhase == 1)
            {
                if (centralAmerica.BackColor == System.Drawing.Color.Transparent)
                {
                    centralAmericaColor = turnColor;
                    if (turnColor == "red")
                    {
                        centralAmerica.BackColor = System.Drawing.Color.Red;
                        centralAmerica.Text = "1";
                    }
                    if (turnColor == "blue")
                    {
                        centralAmerica.BackColor = System.Drawing.Color.LightBlue;
                        centralAmerica.Text = "1";
                    }

                    if (turnColor == "green")
                    {
                        centralAmerica.BackColor = System.Drawing.Color.Green;
                        centralAmerica.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        centralAmerica.BackColor = System.Drawing.Color.Tan;
                        centralAmerica.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        centralAmerica.BackColor = System.Drawing.Color.MediumPurple;
                        centralAmerica.Text = "1";
                    }

                    if (turnColor == "pink")
                    {
                        centralAmerica.BackColor = System.Drawing.Color.Pink;
                        centralAmerica.Text = "1";
                    }
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && centralAmerica.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && centralAmerica.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && centralAmerica.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && centralAmerica.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && centralAmerica.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && centralAmerica.BackColor == System.Drawing.Color.Pink))
                {
                    centralAmerica.Text = (int.Parse(centralAmerica.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            }
            centralAmerica.Visible = true;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            easternUnitedStates.Visible = false;
            if (attacking == false)
            {
                attackingTerritory = "Eastern United States";
                attackingmethod();
            }
            if (turnPhase == 1)
            {
                if (easternUnitedStates.BackColor == System.Drawing.Color.Transparent)
                {
                    easternUnitedStatesColor = turnColor;
                    if (turnColor == "red")
                    {
                        easternUnitedStates.BackColor = System.Drawing.Color.Red;
                        easternUnitedStates.Text = "1";
                    }
                    if (turnColor == "blue")
                    {
                        easternUnitedStates.BackColor = System.Drawing.Color.LightBlue;
                        easternUnitedStates.Text = "1";
                    }

                    if (turnColor == "green")
                    {
                        easternUnitedStates.BackColor = System.Drawing.Color.Green;
                        easternUnitedStates.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        easternUnitedStates.BackColor = System.Drawing.Color.Tan;
                        easternUnitedStates.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        easternUnitedStates.BackColor = System.Drawing.Color.MediumPurple;
                        easternUnitedStates.Text = "1";
                    }

                    if (turnColor == "pink")
                    {
                        easternUnitedStates.BackColor = System.Drawing.Color.Pink;
                        easternUnitedStates.Text = "1";
                    }
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && easternUnitedStates.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && easternUnitedStates.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && easternUnitedStates.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && easternUnitedStates.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && easternUnitedStates.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && easternUnitedStates.BackColor == System.Drawing.Color.Pink))
                {
                    easternUnitedStates.Text = (int.Parse(easternUnitedStates.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            }
            easternUnitedStates.Visible = true;
        }

        private void label14_Click(object sender, EventArgs e)
        {
            alberta.Visible = false;
            if (attacking == false)
            {
                attackingTerritory = "Alberta";
                attackingmethod();
            }
            if (turnPhase == 1)
            {
                if (alberta.BackColor == System.Drawing.Color.Transparent)
                {
                    albertaColor = turnColor;
                    if (turnColor == "red")
                    {
                        alberta.BackColor = System.Drawing.Color.Red;
                        alberta.Text = "1";
                    }
                    if (turnColor == "blue")
                    {
                        alberta.BackColor = System.Drawing.Color.LightBlue;
                        alberta.Text = "1";
                    }

                    if (turnColor == "green")
                    {
                        alberta.BackColor = System.Drawing.Color.Green;
                        alberta.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        alberta.BackColor = System.Drawing.Color.Tan;
                        alberta.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        alberta.BackColor = System.Drawing.Color.MediumPurple;
                        alberta.Text = "1";
                    }

                    if (turnColor == "pink")
                    {
                        alberta.BackColor = System.Drawing.Color.Pink;
                        alberta.Text = "1";
                    }
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && alberta.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && alberta.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && alberta.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && alberta.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && alberta.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && alberta.BackColor == System.Drawing.Color.Pink))
                {
                    alberta.Text = (int.Parse(alberta.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            }
            alberta.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            beginGameGroup.Location = new Point(120, 66);
        }

        private void label16_Click(object sender, EventArgs e)
        {
            quebec.Visible = false;
            if (attacking == false)
            {
                attackingTerritory = "Quebec";
                attackingmethod();
            }
            if (turnPhase == 1)
            {
                if (quebec.BackColor == System.Drawing.Color.Transparent)
                {
                    quebecColor = turnColor;
                    if (turnColor == "red")
                    {
                        quebec.BackColor = System.Drawing.Color.Red;
                        quebec.Text = "1";
                    }
                    if (turnColor == "blue")
                    {
                        quebec.BackColor = System.Drawing.Color.LightBlue;
                        quebec.Text = "1";
                    }

                    if (turnColor == "green")
                    {
                        quebec.BackColor = System.Drawing.Color.Green;
                        quebec.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        quebec.BackColor = System.Drawing.Color.Tan;
                        quebec.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        quebec.BackColor = System.Drawing.Color.MediumPurple;
                        quebec.Text = "1";
                    }

                    if (turnColor == "pink")
                    {
                        quebec.BackColor = System.Drawing.Color.Pink;
                        quebec.Text = "1";
                    }
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && quebec.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && quebec.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && quebec.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && quebec.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && quebec.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && quebec.BackColor == System.Drawing.Color.Pink))
                {
                    quebec.Text = (int.Parse(quebec.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            }
            quebec.Visible = true;
        }

        private void label15_Click(object sender, EventArgs e)
        {
            ontario.Visible = false;
            if (attacking == false)
            {
                attackingTerritory = "Ontario";
                attackingmethod();
            }
            if (turnPhase == 1)
            {
                if (ontario.BackColor == System.Drawing.Color.Transparent)
                {
                    ontarioColor = turnColor;
                    if (turnColor == "red")
                    {
                        ontario.BackColor = System.Drawing.Color.Red;
                        ontario.Text = "1";
                    }
                    if (turnColor == "blue")
                    {
                        ontario.BackColor = System.Drawing.Color.LightBlue;
                        ontario.Text = "1";
                    }

                    if (turnColor == "green")
                    {
                        ontario.BackColor = System.Drawing.Color.Green;
                        ontario.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        ontario.BackColor = System.Drawing.Color.Tan;
                        ontario.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        ontario.BackColor = System.Drawing.Color.MediumPurple;
                        ontario.Text = "1";
                    }

                    if (turnColor == "pink")
                    {
                        ontario.BackColor = System.Drawing.Color.Pink;
                        ontario.Text = "1";
                    }
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && ontario.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && ontario.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && ontario.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && ontario.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && ontario.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && ontario.BackColor == System.Drawing.Color.Pink))
                {
                    ontario.Text = (int.Parse(ontario.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            }
            ontario.Visible = true;
        }

        private void label17_Click(object sender, EventArgs e)
        {
            alaska.Visible = false;
            if (attacking == false)
            {
                attackingTerritory = "Alaska";
                attackingmethod();
            }
            if (turnPhase == 1)
            {
                if (alaska.BackColor == System.Drawing.Color.Transparent)
                {
                    alaskaColor = turnColor;
                    if (turnColor == "red")
                    {
                        alaska.BackColor = System.Drawing.Color.Red;
                        alaska.Text = "1";
                    }
                    if (turnColor == "blue")
                    {
                        alaska.BackColor = System.Drawing.Color.LightBlue;
                        alaska.Text = "1";
                    }

                    if (turnColor == "green")
                    {
                        alaska.BackColor = System.Drawing.Color.Green;
                        alaska.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        alaska.BackColor = System.Drawing.Color.Tan;
                        alaska.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        alaska.BackColor = System.Drawing.Color.MediumPurple;
                        alaska.Text = "1";
                    }

                    if (turnColor == "pink")
                    {
                        alaska.BackColor = System.Drawing.Color.Pink;
                        alaska.Text = "1";
                    }
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && alaska.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && alaska.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && alaska.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && alaska.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && alaska.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && alaska.BackColor == System.Drawing.Color.Pink))
                {
                    alaska.Text = (int.Parse(alaska.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            }
            alaska.Visible = true;
        }

        private void label18_Click(object sender, EventArgs e)
        {
            northWestTerritory.Visible = false;
            if (attacking == false)
            {
                attackingTerritory = "Northwest Territory";
                attackingmethod();
            }
            if (turnPhase == 1)
            {
                if (northWestTerritory.BackColor == System.Drawing.Color.Transparent)
                {
                    northWestTerritoryColor = turnColor;
                    if (turnColor == "red")
                    {
                        northWestTerritory.BackColor = System.Drawing.Color.Red;
                        northWestTerritory.Text = "1";
                    }
                    if (turnColor == "blue")
                    {
                        northWestTerritory.BackColor = System.Drawing.Color.LightBlue;
                        northWestTerritory.Text = "1";
                    }

                    if (turnColor == "green")
                    {
                        northWestTerritory.BackColor = System.Drawing.Color.Green;
                        northWestTerritory.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        northWestTerritory.BackColor = System.Drawing.Color.Tan;
                        northWestTerritory.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        northWestTerritory.BackColor = System.Drawing.Color.MediumPurple;
                        northWestTerritory.Text = "1";
                    }

                    if (turnColor == "pink")
                    {
                        northWestTerritory.BackColor = System.Drawing.Color.Pink;
                        northWestTerritory.Text = "1";
                    }
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && northWestTerritory.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && northWestTerritory.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && northWestTerritory.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && northWestTerritory.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && northWestTerritory.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && northWestTerritory.BackColor == System.Drawing.Color.Pink))
                {
                    northWestTerritory.Text = (int.Parse(northWestTerritory.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            }
            northWestTerritory.Visible = true;
        }

        private void label19_Click(object sender, EventArgs e)
        {
            greenLand.Visible = false;
            if (attacking == false)
            {
                attackingTerritory = "Greenland";
                attackingmethod();
            }
            if (turnPhase == 1)
            {
                if (greenLand.BackColor == System.Drawing.Color.Transparent)
                {
                    greenlandColor = turnColor;
                    if (turnColor == "red")
                    {
                        greenLand.BackColor = System.Drawing.Color.Red;
                        greenLand.Text = "1";
                    }
                    if (turnColor == "blue")
                    {
                        greenLand.BackColor = System.Drawing.Color.LightBlue;
                        greenLand.Text = "1";
                    }

                    if (turnColor == "green")
                    {
                        greenLand.BackColor = System.Drawing.Color.Green;
                        greenLand.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        greenLand.BackColor = System.Drawing.Color.Tan;
                        greenLand.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        greenLand.BackColor = System.Drawing.Color.MediumPurple;
                        greenLand.Text = "1";
                    }

                    if (turnColor == "pink")
                    {
                        greenLand.BackColor = System.Drawing.Color.Pink;
                        greenLand.Text = "1";
                    }
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && greenLand.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && greenLand.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && greenLand.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && greenLand.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && greenLand.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && greenLand.BackColor == System.Drawing.Color.Pink))
                {
                    greenLand.Text = (int.Parse(greenLand.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            }
            greenLand.Visible = true;
        }

        private void label20_Click(object sender, EventArgs e)
        {
            iceland.Visible = false;
            if (attacking == false)
            {
                attackingTerritory = "Iceland";
                attackingmethod();
            }
            if (turnPhase == 1)
            {
                if (iceland.BackColor == System.Drawing.Color.Transparent)
                {
                    icelandColor = turnColor;
                    if (turnColor == "red")
                    {
                        iceland.BackColor = System.Drawing.Color.Red;
                        iceland.Text = "1";
                    }
                    if (turnColor == "blue")
                    {
                        iceland.BackColor = System.Drawing.Color.LightBlue;
                        iceland.Text = "1";
                    }

                    if (turnColor == "green")
                    {
                        iceland.BackColor = System.Drawing.Color.Green;
                        iceland.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        iceland.BackColor = System.Drawing.Color.Tan;
                        iceland.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        iceland.BackColor = System.Drawing.Color.MediumPurple;
                        iceland.Text = "1";
                    }

                    if (turnColor == "pink")
                    {
                        iceland.BackColor = System.Drawing.Color.Pink;
                        iceland.Text = "1";
                    }
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && iceland.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && iceland.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && iceland.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && iceland.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && iceland.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && iceland.BackColor == System.Drawing.Color.Pink))
                {
                    iceland.Text = (int.Parse(iceland.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            }
            iceland.Visible = true;
        }

        private void label21_Click(object sender, EventArgs e)
        {
            greatBritain.Visible = false;
            if (attacking == false)
            {
                attackingTerritory = "Great Britain";
                attackingmethod();
            }
            if (turnPhase == 1)
            {
                if (greatBritain.BackColor == System.Drawing.Color.Transparent)
                {
                    greatBritainColor = turnColor;
                    if (turnColor == "red")
                    {
                        greatBritain.BackColor = System.Drawing.Color.Red;
                        greatBritain.Text = "1";
                    }
                    if (turnColor == "blue")
                    {
                        greatBritain.BackColor = System.Drawing.Color.LightBlue;
                        greatBritain.Text = "1";
                    }

                    if (turnColor == "green")
                    {
                        greatBritain.BackColor = System.Drawing.Color.Green;
                        greatBritain.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        greatBritain.BackColor = System.Drawing.Color.Tan;
                        greatBritain.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        greatBritain.BackColor = System.Drawing.Color.MediumPurple;
                        greatBritain.Text = "1";
                    }

                    if (turnColor == "pink")
                    {
                        greatBritain.BackColor = System.Drawing.Color.Pink;
                        greatBritain.Text = "1";
                    }
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && greatBritain.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && greatBritain.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && greatBritain.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && greatBritain.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && greatBritain.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && greatBritain.BackColor == System.Drawing.Color.Pink))
                {
                    greatBritain.Text = (int.Parse(greatBritain.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            }
            greatBritain.Visible = true;
        }

        private void label22_Click(object sender, EventArgs e)
        {
            scandinavia.Visible = false;
            if (attacking == false)
            {
                attackingTerritory = "Scandinavia";
                attackingmethod();
            }
            if (turnPhase == 1)
            {
                if (scandinavia.BackColor == System.Drawing.Color.Transparent)
                {
                    scandinaviaColor = turnColor;
                    if (turnColor == "red")
                    {
                        scandinavia.BackColor = System.Drawing.Color.Red;
                        scandinavia.Text = "1";
                    }
                    if (turnColor == "blue")
                    {
                        scandinavia.BackColor = System.Drawing.Color.LightBlue;
                        scandinavia.Text = "1";
                    }

                    if (turnColor == "green")
                    {
                        scandinavia.BackColor = System.Drawing.Color.Green;
                        scandinavia.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        scandinavia.BackColor = System.Drawing.Color.Tan;
                        scandinavia.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        scandinavia.BackColor = System.Drawing.Color.MediumPurple;
                        scandinavia.Text = "1";
                    }

                    if (turnColor == "pink")
                    {
                        scandinavia.BackColor = System.Drawing.Color.Pink;
                        scandinavia.Text = "1";
                    }
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && scandinavia.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && scandinavia.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && scandinavia.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && scandinavia.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && scandinavia.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && scandinavia.BackColor == System.Drawing.Color.Pink))
                {
                    scandinavia.Text = (int.Parse(scandinavia.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            }
            scandinavia.Visible = true;
        }

        private void label25_Click(object sender, EventArgs e)
        {
            westernEurope.Visible = false;
            if (attacking == false)
            {
                attackingTerritory = "Western Europe";
                attackingmethod();
            }
            if (turnPhase == 1)
            {
                if (westernEurope.BackColor == System.Drawing.Color.Transparent)
                {
                    westernEuropeColor = turnColor;
                    if (turnColor == "red")
                    {
                        westernEurope.BackColor = System.Drawing.Color.Red;
                        westernEurope.Text = "1";
                    }
                    if (turnColor == "blue")
                    {
                        westernEurope.BackColor = System.Drawing.Color.LightBlue;
                        westernEurope.Text = "1";
                    }

                    if (turnColor == "green")
                    {
                        westernEurope.BackColor = System.Drawing.Color.Green;
                        westernEurope.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        westernEurope.BackColor = System.Drawing.Color.Tan;
                        westernEurope.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        westernEurope.BackColor = System.Drawing.Color.MediumPurple;
                        westernEurope.Text = "1";
                    }

                    if (turnColor == "pink")
                    {
                        westernEurope.BackColor = System.Drawing.Color.Pink;
                        westernEurope.Text = "1";
                    }
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && westernEurope.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && westernEurope.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && westernEurope.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && westernEurope.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && westernEurope.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && westernEurope.BackColor == System.Drawing.Color.Pink))
                {
                    westernEurope.Text = (int.Parse(westernEurope.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            }
            westernEurope.Visible = true;
        }

        private void label24_Click(object sender, EventArgs e)
        {
            northernEurope.Visible = false;
            if (attacking == false)
            {
                attackingTerritory = "Northern Europe";
                attackingmethod();
            }
            if (turnPhase == 1)
            {
                if (northernEurope.BackColor == System.Drawing.Color.Transparent)
                {
                    northernEuropeColor = turnColor;
                    if (turnColor == "red")
                    {
                        northernEurope.BackColor = System.Drawing.Color.Red;
                        northernEurope.Text = "1";
                    }
                    if (turnColor == "blue")
                    {
                        northernEurope.BackColor = System.Drawing.Color.LightBlue;
                        northernEurope.Text = "1";
                    }

                    if (turnColor == "green")
                    {
                        northernEurope.BackColor = System.Drawing.Color.Green;
                        northernEurope.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        northernEurope.BackColor = System.Drawing.Color.Tan;
                        northernEurope.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        northernEurope.BackColor = System.Drawing.Color.MediumPurple;
                        northernEurope.Text = "1";
                    }

                    if (turnColor == "pink")
                    {
                        northernEurope.BackColor = System.Drawing.Color.Pink;
                        northernEurope.Text = "1";
                    }
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && northernEurope.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && northernEurope.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && northernEurope.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && northernEurope.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && northernEurope.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && northernEurope.BackColor == System.Drawing.Color.Pink))
                {
                    northernEurope.Text = (int.Parse(northernEurope.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            }
            northernEurope.Visible = true;
        }

        private void label23_Click(object sender, EventArgs e)
        {
            ukraine.Visible = false;
            if (attacking == false)
            {
                attackingTerritory = "Ukraine";
                attackingmethod();
            }
            if (turnPhase == 1)
            {
                if (ukraine.BackColor == System.Drawing.Color.Transparent)
                {
                    ukraineColor = turnColor;
                    if (turnColor == "red")
                    {
                        ukraine.BackColor = System.Drawing.Color.Red;
                        ukraine.Text = "1";
                    }
                    if (turnColor == "blue")
                    {
                        ukraine.BackColor = System.Drawing.Color.LightBlue;
                        ukraine.Text = "1";
                    }

                    if (turnColor == "green")
                    {
                        ukraine.BackColor = System.Drawing.Color.Green;
                        ukraine.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        ukraine.BackColor = System.Drawing.Color.Tan;
                        ukraine.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        ukraine.BackColor = System.Drawing.Color.MediumPurple;
                        ukraine.Text = "1";
                    }

                    if (turnColor == "pink")
                    {
                        ukraine.BackColor = System.Drawing.Color.Pink;
                        ukraine.Text = "1";
                    }
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && ukraine.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && ukraine.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && ukraine.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && ukraine.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && ukraine.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && ukraine.BackColor == System.Drawing.Color.Pink))
                {
                    ukraine.Text = (int.Parse(ukraine.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            }
            ukraine.Visible = true;
        }

        private void label26_Click(object sender, EventArgs e)
        {
            southernEurope.Visible = false;
            if (attacking == false)
            {
                attackingTerritory = "Southern Europe";
                attackingmethod();
            }
            if (turnPhase == 1)
            {
                if (southernEurope.BackColor == System.Drawing.Color.Transparent)
                {
                    southernEuropeColor = turnColor;
                    if (turnColor == "red")
                    {
                        southernEurope.BackColor = System.Drawing.Color.Red;
                        southernEurope.Text = "1";
                    }
                    if (turnColor == "blue")
                    {
                        southernEurope.BackColor = System.Drawing.Color.LightBlue;
                        southernEurope.Text = "1";
                    }

                    if (turnColor == "green")
                    {
                        southernEurope.BackColor = System.Drawing.Color.Green;
                        southernEurope.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        southernEurope.BackColor = System.Drawing.Color.Tan;
                        southernEurope.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        southernEurope.BackColor = System.Drawing.Color.MediumPurple;
                        southernEurope.Text = "1";
                    }

                    if (turnColor == "pink")
                    {
                        southernEurope.BackColor = System.Drawing.Color.Pink;
                        southernEurope.Text = "1";
                    }
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && southernEurope.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && southernEurope.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && southernEurope.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && southernEurope.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && southernEurope.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && southernEurope.BackColor == System.Drawing.Color.Pink))
                {
                    southernEurope.Text = (int.Parse(southernEurope.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            }
            southernEurope.Visible = true;
        }

        private void label27_Click(object sender, EventArgs e)
        {
            middleEast.Visible = false;
            if (attacking == false)
            {
                attackingTerritory = "Middle East";
                attackingmethod();
            }
            if (turnPhase == 1)
            {
                if (middleEast.BackColor == System.Drawing.Color.Transparent)
                {
                    middleEastColor = turnColor;
                    if (turnColor == "red")
                    {
                        middleEast.BackColor = System.Drawing.Color.Red;
                        middleEast.Text = "1";
                    }
                    if (turnColor == "blue")
                    {
                        middleEast.BackColor = System.Drawing.Color.LightBlue;
                        middleEast.Text = "1";
                    }

                    if (turnColor == "green")
                    {
                        middleEast.BackColor = System.Drawing.Color.Green;
                        middleEast.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        middleEast.BackColor = System.Drawing.Color.Tan;
                        middleEast.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        middleEast.BackColor = System.Drawing.Color.MediumPurple;
                        middleEast.Text = "1";
                    }

                    if (turnColor == "pink")
                    {
                        middleEast.BackColor = System.Drawing.Color.Pink;
                        middleEast.Text = "1";
                    }
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && middleEast.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && middleEast.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && middleEast.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && middleEast.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && middleEast.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && middleEast.BackColor == System.Drawing.Color.Pink))
                {
                    middleEast.Text = (int.Parse(middleEast.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            }
            middleEast.Visible = true;
        }

        private void label28_Click(object sender, EventArgs e)
        {
            afghanistan.Visible = false;
            if (attacking == false)
            {
                attackingTerritory = "Afghanistan";
                attackingmethod();
            }
            if (turnPhase == 1)
            {
                if (afghanistan.BackColor == System.Drawing.Color.Transparent)
                {
                    afghanistanColor = turnColor;
                    if (turnColor == "red")
                    {
                        afghanistan.BackColor = System.Drawing.Color.Red;
                        afghanistan.Text = "1";
                    }
                    if (turnColor == "blue")
                    {
                        afghanistan.BackColor = System.Drawing.Color.LightBlue;
                        afghanistan.Text = "1";
                    }

                    if (turnColor == "green")
                    {
                        afghanistan.BackColor = System.Drawing.Color.Green;
                        afghanistan.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        afghanistan.BackColor = System.Drawing.Color.Tan;
                        afghanistan.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        afghanistan.BackColor = System.Drawing.Color.MediumPurple;
                        afghanistan.Text = "1";
                    }

                    if (turnColor == "pink")
                    {
                        afghanistan.BackColor = System.Drawing.Color.Pink;
                        afghanistan.Text = "1";
                    }
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && afghanistan.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && afghanistan.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && afghanistan.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && afghanistan.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && afghanistan.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && afghanistan.BackColor == System.Drawing.Color.Pink))
                {
                    afghanistan.Text = (int.Parse(afghanistan.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            }
            afghanistan.Visible = true;
        }

        private void label32_Click(object sender, EventArgs e)
        {
            ural.Visible = false;
            if (attacking == false)
            {
                attackingTerritory = "Ural";
                attackingmethod();
            }
            if (turnPhase == 1)
            {
                if (ural.BackColor == System.Drawing.Color.Transparent)
                {
                    uralColor = turnColor;
                    if (turnColor == "red")
                    {
                        ural.BackColor = System.Drawing.Color.Red;
                        ural.Text = "1";
                    }
                    if (turnColor == "blue")
                    {
                        ural.BackColor = System.Drawing.Color.LightBlue;
                        ural.Text = "1";
                    }

                    if (turnColor == "green")
                    {
                        ural.BackColor = System.Drawing.Color.Green;
                        ural.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        ural.BackColor = System.Drawing.Color.Tan;
                        ural.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        ural.BackColor = System.Drawing.Color.MediumPurple;
                        ural.Text = "1";
                    }

                    if (turnColor == "pink")
                    {
                        ural.BackColor = System.Drawing.Color.Pink;
                        ural.Text = "1";
                    }
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && ural.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && ural.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && ural.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && ural.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && ural.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && ural.BackColor == System.Drawing.Color.Pink))
                {
                    ural.Text = (int.Parse(ural.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            }
            ural.Visible = true;
        }

        private void label33_Click(object sender, EventArgs e)
        {
            siberia.Visible = false;
            if (attacking == false)
            {
                attackingTerritory = "Siberia";
                attackingmethod();
            }
            if (turnPhase == 1)
            {
                if (siberia.BackColor == System.Drawing.Color.Transparent)
                {
                    siberiaColor = turnColor;
                    if (turnColor == "red")
                    {
                        siberia.BackColor = System.Drawing.Color.Red;
                        siberia.Text = "1";
                    }
                    if (turnColor == "blue")
                    {
                        siberia.BackColor = System.Drawing.Color.LightBlue;
                        siberia.Text = "1";
                    }

                    if (turnColor == "green")
                    {
                        siberia.BackColor = System.Drawing.Color.Green;
                        siberia.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        siberia.BackColor = System.Drawing.Color.Tan;
                        siberia.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        siberia.BackColor = System.Drawing.Color.MediumPurple;
                        siberia.Text = "1";
                    }

                    if (turnColor == "pink")
                    {
                        siberia.BackColor = System.Drawing.Color.Pink;
                        siberia.Text = "1";
                    }
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && siberia.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && siberia.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && siberia.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && siberia.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && siberia.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && siberia.BackColor == System.Drawing.Color.Pink))
                {
                    siberia.Text = (int.Parse(siberia.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            }
            siberia.Visible = true;
        }

        private void label31_Click(object sender, EventArgs e)
        {
            china.Visible = false;
            if (attacking == false)
            {
                attackingTerritory = "China";
                attackingmethod();
            }
            if (turnPhase == 1)
            {
                if (china.BackColor == System.Drawing.Color.Transparent)
                {
                    chinaColor = turnColor;
                    if (turnColor == "red")
                    {
                        china.BackColor = System.Drawing.Color.Red;
                        china.Text = "1";
                    }
                    if (turnColor == "blue")
                    {
                        china.BackColor = System.Drawing.Color.LightBlue;
                        china.Text = "1";
                    }

                    if (turnColor == "green")
                    {
                        china.BackColor = System.Drawing.Color.Green;
                        china.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        china.BackColor = System.Drawing.Color.Tan;
                        china.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        china.BackColor = System.Drawing.Color.MediumPurple;
                        china.Text = "1";
                    }

                    if (turnColor == "pink")
                    {
                        china.BackColor = System.Drawing.Color.Pink;
                        china.Text = "1";
                    }
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && china.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && china.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && china.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && china.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && china.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && china.BackColor == System.Drawing.Color.Pink))
                {
                    china.Text = (int.Parse(china.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            }
            china.Visible = true;
        }

        private void label29_Click(object sender, EventArgs e)
        {
            india.Visible = false;
            if (attacking == false)
            {
                attackingTerritory = "India";
                attackingmethod();
            }
            if (turnPhase == 1)
            {
                if (india.BackColor == System.Drawing.Color.Transparent)
                {
                    indiaColor = turnColor;
                    if (turnColor == "red")
                    {
                        india.BackColor = System.Drawing.Color.Red;
                        india.Text = "1";
                    }
                    if (turnColor == "blue")
                    {
                        india.BackColor = System.Drawing.Color.LightBlue;
                        india.Text = "1";
                    }

                    if (turnColor == "green")
                    {
                        india.BackColor = System.Drawing.Color.Green;
                        india.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        india.BackColor = System.Drawing.Color.Tan;
                        india.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        india.BackColor = System.Drawing.Color.MediumPurple;
                        india.Text = "1";
                    }

                    if (turnColor == "pink")
                    {
                        india.BackColor = System.Drawing.Color.Pink;
                        india.Text = "1";
                    }
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && india.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && india.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && india.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && india.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && india.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && india.BackColor == System.Drawing.Color.Pink))
                {
                    india.Text = (int.Parse(india.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            }
            india.Visible = true;
        }

        private void label30_Click(object sender, EventArgs e)
        {
            siam.Visible = false;
            if (attacking == false)
            {
                attackingTerritory = "Siam";
                attackingmethod();
            }
            if (turnPhase == 1)
            {
                if (siam.BackColor == System.Drawing.Color.Transparent)
                {
                    siamColor = turnColor;
                    if (turnColor == "red")
                    {
                        siam.BackColor = System.Drawing.Color.Red;
                        siam.Text = "1";
                    }
                    if (turnColor == "blue")
                    {
                        siam.BackColor = System.Drawing.Color.LightBlue;
                        siam.Text = "1";
                    }

                    if (turnColor == "green")
                    {
                        siam.BackColor = System.Drawing.Color.Green;
                        siam.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        siam.BackColor = System.Drawing.Color.Tan;
                        siam.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        siam.BackColor = System.Drawing.Color.MediumPurple;
                        siam.Text = "1";
                    }

                    if (turnColor == "pink")
                    {
                        siam.BackColor = System.Drawing.Color.Pink;
                        siam.Text = "1";
                    }
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && siam.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && siam.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && siam.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && siam.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && siam.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && siam.BackColor == System.Drawing.Color.Pink))
                {
                    siam.Text = (int.Parse(siam.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            }
            siam.Visible = true;
        }

        private void label36_Click(object sender, EventArgs e)
        {
            mongolia.Visible = false;
            if (attacking == false)
            {
                attackingTerritory = "Mongolia";
                attackingmethod();
            }
            if (turnPhase == 1)
            {
                if (mongolia.BackColor == System.Drawing.Color.Transparent)
                {
                    mongoliaColor = turnColor;
                    if (turnColor == "red")
                    {
                        mongolia.BackColor = System.Drawing.Color.Red;
                        mongolia.Text = "1";
                    }
                    if (turnColor == "blue")
                    {
                        mongolia.BackColor = System.Drawing.Color.LightBlue;
                        mongolia.Text = "1";
                    }

                    if (turnColor == "green")
                    {
                        mongolia.BackColor = System.Drawing.Color.Green;
                        mongolia.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        mongolia.BackColor = System.Drawing.Color.Tan;
                        mongolia.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        mongolia.BackColor = System.Drawing.Color.MediumPurple;
                        mongolia.Text = "1";
                    }

                    if (turnColor == "pink")
                    {
                        mongolia.BackColor = System.Drawing.Color.Pink;
                        mongolia.Text = "1";
                    }
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && mongolia.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && mongolia.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && mongolia.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && mongolia.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && mongolia.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && mongolia.BackColor == System.Drawing.Color.Pink))
                {
                    mongolia.Text = (int.Parse(mongolia.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            }
            mongolia.Visible = true;
        }

        private void label35_Click(object sender, EventArgs e)
        {
            irkutsk.Visible = false;
            if (attacking == false)
            {
                attackingTerritory = "Irkutsk";
                attackingmethod();
            }
            if (turnPhase == 1)
            {
                if (irkutsk.BackColor == System.Drawing.Color.Transparent)
                {
                    irkutskColor = turnColor;
                    if (turnColor == "red")
                    {
                        irkutsk.BackColor = System.Drawing.Color.Red;
                        irkutsk.Text = "1";
                    }
                    if (turnColor == "blue")
                    {
                        irkutsk.BackColor = System.Drawing.Color.LightBlue;
                        irkutsk.Text = "1";
                    }

                    if (turnColor == "green")
                    {
                        irkutsk.BackColor = System.Drawing.Color.Green;
                        irkutsk.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        irkutsk.BackColor = System.Drawing.Color.Tan;
                        irkutsk.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        irkutsk.BackColor = System.Drawing.Color.MediumPurple;
                        irkutsk.Text = "1";
                    }

                    if (turnColor == "pink")
                    {
                        irkutsk.BackColor = System.Drawing.Color.Pink;
                        irkutsk.Text = "1";
                    }
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && irkutsk.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && irkutsk.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && irkutsk.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && irkutsk.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && irkutsk.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && irkutsk.BackColor == System.Drawing.Color.Pink))
                {
                    irkutsk.Text = (int.Parse(irkutsk.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            }
            irkutsk.Visible = true;
        }

        private void label34_Click(object sender, EventArgs e)
        {
            yakutsk.Visible = false;
            if (attacking == false)
            {
                attackingTerritory = "Yakutsk";
                attackingmethod();
            }
            if (turnPhase == 1)
            {
                if (yakutsk.BackColor == System.Drawing.Color.Transparent)
                {
                    yakutskColor = turnColor;
                    if (turnColor == "red")
                    {
                        yakutsk.BackColor = System.Drawing.Color.Red;
                        yakutsk.Text = "1";
                    }
                    if (turnColor == "blue")
                    {
                        yakutsk.BackColor = System.Drawing.Color.LightBlue;
                        yakutsk.Text = "1";
                    }

                    if (turnColor == "green")
                    {
                        yakutsk.BackColor = System.Drawing.Color.Green;
                        yakutsk.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        yakutsk.BackColor = System.Drawing.Color.Tan;
                        yakutsk.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        yakutsk.BackColor = System.Drawing.Color.MediumPurple;
                        yakutsk.Text = "1";
                    }

                    if (turnColor == "pink")
                    {
                        yakutsk.BackColor = System.Drawing.Color.Pink;
                        yakutsk.Text = "1";
                    }
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && yakutsk.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && yakutsk.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && yakutsk.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && yakutsk.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && yakutsk.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && yakutsk.BackColor == System.Drawing.Color.Pink))
                {
                    yakutsk.Text = (int.Parse(yakutsk.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            }
            yakutsk.Visible = true;
        }

        private void label37_Click(object sender, EventArgs e)
        {
            kamchatka.Visible = false;
            if (attacking == false)
            {
                attackingTerritory = "Kamchatka";
                attackingmethod();
            }
            if (turnPhase == 1)
            {
                if (kamchatka.BackColor == System.Drawing.Color.Transparent)
                {
                    kamchatkaColor = turnColor;
                    if (turnColor == "red")
                    {
                        kamchatka.BackColor = System.Drawing.Color.Red;
                        kamchatka.Text = "1";
                    }
                    if (turnColor == "blue")
                    {
                        kamchatka.BackColor = System.Drawing.Color.LightBlue;
                        kamchatka.Text = "1";
                    }

                    if (turnColor == "green")
                    {
                        kamchatka.BackColor = System.Drawing.Color.Green;
                        kamchatka.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        kamchatka.BackColor = System.Drawing.Color.Tan;
                        kamchatka.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        kamchatka.BackColor = System.Drawing.Color.MediumPurple;
                        kamchatka.Text = "1";
                    }

                    if (turnColor == "pink")
                    {
                        kamchatka.BackColor = System.Drawing.Color.Pink;
                        kamchatka.Text = "1";
                    }
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && kamchatka.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && kamchatka.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && kamchatka.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && kamchatka.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && kamchatka.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && kamchatka.BackColor == System.Drawing.Color.Pink))
                {
                    kamchatka.Text = (int.Parse(kamchatka.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            }
            kamchatka.Visible = true;
        }

        private void label38_Click(object sender, EventArgs e)
        {
            japan.Visible = false;
            if (attacking == false)
            {
                attackingTerritory = "Japan";
                attackingmethod();
            }
            if (turnPhase == 1)
            {
                if (japan.BackColor == System.Drawing.Color.Transparent)
                {
                    japanColor = turnColor;
                    if (turnColor == "red")
                    {
                        japan.BackColor = System.Drawing.Color.Red;
                        japan.Text = "1";
                    }
                    if (turnColor == "blue")
                    {
                        japan.BackColor = System.Drawing.Color.LightBlue;
                        japan.Text = "1";
                    }

                    if (turnColor == "green")
                    {
                        japan.BackColor = System.Drawing.Color.Green;
                        japan.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        japan.BackColor = System.Drawing.Color.Tan;
                        japan.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        japan.BackColor = System.Drawing.Color.MediumPurple;
                        japan.Text = "1";
                    }

                    if (turnColor == "pink")
                    {
                        japan.BackColor = System.Drawing.Color.Pink;
                        japan.Text = "1";
                    }
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && japan.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && japan.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && japan.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && japan.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && japan.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && japan.BackColor == System.Drawing.Color.Pink))
                {
                    japan.Text = (int.Parse(japan.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            }
            japan.Visible = true;
        }

        private void label40_Click(object sender, EventArgs e)
        {
            indonesia.Visible = false;
            if (attacking == false)
            {
                attackingTerritory = "Indonesia";
                attackingmethod();
            }
            if (turnPhase == 1)
            {
                if (indonesia.BackColor == System.Drawing.Color.Transparent)
                {
                    indonesiaColor = turnColor;
                    if (turnColor == "red")
                    {
                        indonesia.BackColor = System.Drawing.Color.Red;
                        indonesia.Text = "1";
                    }
                    if (turnColor == "blue")
                    {
                        indonesia.BackColor = System.Drawing.Color.LightBlue;
                        indonesia.Text = "1";
                    }

                    if (turnColor == "green")
                    {
                        indonesia.BackColor = System.Drawing.Color.Green;
                        indonesia.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        indonesia.BackColor = System.Drawing.Color.Tan;
                        indonesia.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        indonesia.BackColor = System.Drawing.Color.MediumPurple;
                        indonesia.Text = "1";
                    }

                    if (turnColor == "pink")
                    {
                        indonesia.BackColor = System.Drawing.Color.Pink;
                        indonesia.Text = "1";
                    }
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && indonesia.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && indonesia.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && indonesia.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && indonesia.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && indonesia.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && indonesia.BackColor == System.Drawing.Color.Pink))
                {
                    indonesia.Text = (int.Parse(indonesia.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            }
            indonesia.Visible = true;
        }

        private void label41_Click(object sender, EventArgs e)
        {
            newGuinea.Visible = false;
            if (attacking == false)
            {
                attackingTerritory = "New Guinea";
                attackingmethod();
            }
            if (turnPhase == 1)
            {
                if (newGuinea.BackColor == System.Drawing.Color.Transparent)
                {
                    newGuineaColor = turnColor;
                    if (turnColor == "red")
                    {
                        newGuinea.BackColor = System.Drawing.Color.Red;
                        newGuinea.Text = "1";
                    }
                    if (turnColor == "blue")
                    {
                        newGuinea.BackColor = System.Drawing.Color.LightBlue;
                        newGuinea.Text = "1";
                    }

                    if (turnColor == "green")
                    {
                        newGuinea.BackColor = System.Drawing.Color.Green;
                        newGuinea.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        newGuinea.BackColor = System.Drawing.Color.Tan;
                        newGuinea.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        newGuinea.BackColor = System.Drawing.Color.MediumPurple;
                        newGuinea.Text = "1";
                    }

                    if (turnColor == "pink")
                    {
                        newGuinea.BackColor = System.Drawing.Color.Pink;
                        newGuinea.Text = "1";
                    }
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && newGuinea.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && newGuinea.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && newGuinea.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && newGuinea.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && newGuinea.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && newGuinea.BackColor == System.Drawing.Color.Pink))
                {
                    newGuinea.Text = (int.Parse(newGuinea.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            }
            newGuinea.Visible = true;
        }

        private void label42_Click(object sender, EventArgs e)
        {
            easternAustralia.Visible = false;
            if (attacking == false)
            {
                attackingTerritory = "Eastern Australia";
                attackingmethod();
            }
            if (turnPhase == 1)
            {
                if (easternAustralia.BackColor == System.Drawing.Color.Transparent)
                {
                    easternAustraliaColor = turnColor;
                    if (turnColor == "red")
                    {
                        easternAustralia.BackColor = System.Drawing.Color.Red;
                        easternAustralia.Text = "1";
                    }
                    if (turnColor == "blue")
                    {
                        easternAustralia.BackColor = System.Drawing.Color.LightBlue;
                        easternAustralia.Text = "1";
                    }

                    if (turnColor == "green")
                    {
                        easternAustralia.BackColor = System.Drawing.Color.Green;
                        easternAustralia.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        easternAustralia.BackColor = System.Drawing.Color.Tan;
                        easternAustralia.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        easternAustralia.BackColor = System.Drawing.Color.MediumPurple;
                        easternAustralia.Text = "1";
                    }

                    if (turnColor == "pink")
                    {
                        easternAustralia.BackColor = System.Drawing.Color.Pink;
                        easternAustralia.Text = "1";
                    }
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && easternAustralia.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && easternAustralia.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && easternAustralia.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && easternAustralia.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && easternAustralia.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && easternAustralia.BackColor == System.Drawing.Color.Pink))
                {
                    easternAustralia.Text = (int.Parse(easternAustralia.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            }
            easternAustralia.Visible = true;
        }

        private void label39_Click(object sender, EventArgs e)
        {
            westernAustralia.Visible = false;
            if (attacking == false)
            {
                attackingTerritory = "Western Australia";
                attackingmethod();
            }
            if (turnPhase == 1)
            {
                if (westernAustralia.BackColor == System.Drawing.Color.Transparent)
                {
                    westernAustraliaColor = turnColor;
                    if (turnColor == "red")
                    {
                        westernAustralia.BackColor = System.Drawing.Color.Red;
                        westernAustralia.Text = "1";
                    }
                    if (turnColor == "blue")
                    {
                        westernAustralia.BackColor = System.Drawing.Color.LightBlue;
                        westernAustralia.Text = "1";
                    }

                    if (turnColor == "green")
                    {
                        westernAustralia.BackColor = System.Drawing.Color.Green;
                        westernAustralia.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        westernAustralia.BackColor = System.Drawing.Color.Tan;
                        westernAustralia.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        westernAustralia.BackColor = System.Drawing.Color.MediumPurple;
                        westernAustralia.Text = "1";
                    }

                    if (turnColor == "pink")
                    {
                        westernAustralia.BackColor = System.Drawing.Color.Pink;
                        westernAustralia.Text = "1";
                    }
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && westernAustralia.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && westernAustralia.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && westernAustralia.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && westernAustralia.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && westernAustralia.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && westernAustralia.BackColor == System.Drawing.Color.Pink))
                {
                    westernAustralia.Text = (int.Parse(westernAustralia.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            }
            westernAustralia.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            southAfrica.Visible = false;
            if (attacking == false)
            {
                attackingTerritory = "South Africa";
                attackingmethod();
            }
            if (turnPhase == 1)
            {
                if (southAfrica.BackColor == System.Drawing.Color.Transparent)
                {
                    southAfricaColor = turnColor;
                    if (turnColor == "red")
                    {
                        southAfrica.BackColor = System.Drawing.Color.Red;
                        southAfrica.Text = "1";
                    }
                    if (turnColor == "blue")
                    {
                        southAfrica.BackColor = System.Drawing.Color.LightBlue;
                        southAfrica.Text = "1";
                    }

                    if (turnColor == "green")
                    {
                        southAfrica.BackColor = System.Drawing.Color.Green;
                        southAfrica.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        southAfrica.BackColor = System.Drawing.Color.Tan;
                        southAfrica.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        southAfrica.BackColor = System.Drawing.Color.MediumPurple;
                        southAfrica.Text = "1";
                    }

                    if (turnColor == "pink")
                    {
                        southAfrica.BackColor = System.Drawing.Color.Pink;
                        southAfrica.Text = "1";
                    }
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && southAfrica.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && southAfrica.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && southAfrica.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && southAfrica.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && southAfrica.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && southAfrica.BackColor == System.Drawing.Color.Pink))
                {
                    southAfrica.Text = (int.Parse(southAfrica.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            }
            southAfrica.Visible = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            congo.Visible = false;
            if (attacking == false)
            {
                attackingTerritory = "Congo";
                attackingmethod();
            }
            if (turnPhase == 1)
            {
                if (congo.BackColor == System.Drawing.Color.Transparent)
                {
                    congoColor = turnColor;
                    if (turnColor == "red")
                    {
                        congo.BackColor = System.Drawing.Color.Red;
                        congo.Text = "1";
                    }
                    if (turnColor == "blue")
                    {
                        congo.BackColor = System.Drawing.Color.LightBlue;
                        congo.Text = "1";
                    }

                    if (turnColor == "green")
                    {
                        congo.BackColor = System.Drawing.Color.Green;
                        congo.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        congo.BackColor = System.Drawing.Color.Tan;
                        congo.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        congo.BackColor = System.Drawing.Color.MediumPurple;
                        congo.Text = "1";
                    }

                    if (turnColor == "pink")
                    {
                        congo.BackColor = System.Drawing.Color.Pink;
                        congo.Text = "1";
                    }
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && congo.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && congo.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && congo.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && congo.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && congo.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && congo.BackColor == System.Drawing.Color.Pink))
                {
                    congo.Text = (int.Parse(congo.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            }
            congo.Visible = true;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            eastAfrica.Visible = false;
            if (attacking == false)
            {
                attackingTerritory = "East Africa";
                attackingmethod();
            }
            if (turnPhase == 1)
            {
                if (eastAfrica.BackColor == System.Drawing.Color.Transparent)
                {
                    eastAfricaColor = turnColor;
                    if (turnColor == "red")
                    {
                        eastAfrica.BackColor = System.Drawing.Color.Red;
                        eastAfrica.Text = "1";
                    }
                    if (turnColor == "blue")
                    {
                        eastAfrica.BackColor = System.Drawing.Color.LightBlue;
                        eastAfrica.Text = "1";
                    }

                    if (turnColor == "green")
                    {
                        eastAfrica.BackColor = System.Drawing.Color.Green;
                        eastAfrica.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        eastAfrica.BackColor = System.Drawing.Color.Tan;
                        eastAfrica.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        eastAfrica.BackColor = System.Drawing.Color.MediumPurple;
                        eastAfrica.Text = "1";
                    }

                    if (turnColor == "pink")
                    {
                        eastAfrica.BackColor = System.Drawing.Color.Pink;
                        eastAfrica.Text = "1";
                    }
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && eastAfrica.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && eastAfrica.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && eastAfrica.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && eastAfrica.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && eastAfrica.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && eastAfrica.BackColor == System.Drawing.Color.Pink))
                {
                    eastAfrica.Text = (int.Parse(eastAfrica.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            }
            eastAfrica.Visible = true;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            egypt.Visible = false;
            if (attacking == false)
            {
                attackingTerritory = "Egypt";
                attackingmethod();
            }
            if (turnPhase == 1)
            {
                if (egypt.BackColor == System.Drawing.Color.Transparent)
                {
                    egyptColor = turnColor;
                    if (turnColor == "red")
                    {
                        egypt.BackColor = System.Drawing.Color.Red;
                        egypt.Text = "1";
                    }
                    if (turnColor == "blue")
                    {
                        egypt.BackColor = System.Drawing.Color.LightBlue;
                        egypt.Text = "1";
                    }

                    if (turnColor == "green")
                    {
                        egypt.BackColor = System.Drawing.Color.Green;
                        egypt.Text = "1";
                    }

                    if (turnColor == "brown")
                    {
                        egypt.BackColor = System.Drawing.Color.Tan;
                        egypt.Text = "1";
                    }

                    if (turnColor == "purple")
                    {
                        egypt.BackColor = System.Drawing.Color.MediumPurple;
                        egypt.Text = "1";
                    }

                    if (turnColor == "pink")
                    {
                        egypt.BackColor = System.Drawing.Color.Pink;
                        egypt.Text = "1";
                    }
                    checkTurn();
                    initialdeployTroops();
                }
                if ((turnColor == "red" && egypt.BackColor == System.Drawing.Color.Red) || (turnColor == "blue" && egypt.BackColor == System.Drawing.Color.LightBlue) || (turnColor == "green" && egypt.BackColor == System.Drawing.Color.Green) || (turnColor == "brown" && egypt.BackColor == System.Drawing.Color.Tan) || (turnColor == "purple" && egypt.BackColor == System.Drawing.Color.MediumPurple) || (turnColor == "pink" && egypt.BackColor == System.Drawing.Color.Pink))
                {
                    egypt.Text = (int.Parse(egypt.Text) + 1).ToString();
                    checkTurn();
                    initialdeployTroops();
                }
            }
            egypt.Visible = true;
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
            if (commandText.Text == "phase 2 please") { armiesUsed = 0; armiesTotal = 0; initialdeployTroops(); }
            commandCenterGroup.Visible = false;
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
            ResetText();
            armiesUsed = 0;
            troopsDeployedText.Text = "(" + armiesUsed + "/" + armiesTotal + ")";
        }

        private void useCardButton_Click(object sender, EventArgs e)
        {

        }

        private void beginTurnButton_Click(object sender, EventArgs e)
        {
            turnPhase = 3;
            armiesTotal = 0;
            armiesUsed = 0;
            newTurnBox.Visible = false;
            runGame();
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
                if (turn == players)
                {
                    armiesUsed++;
                    turn = 1;
                }
                else
                {
                    turn++;
                }
            }
        }
        private void deployedTroop()
        {
            armiesUsed++;
            troopsDeployedText.Text = "(" + armiesUsed + "/" + armiesTotal + ")";
        }
        private void runGame()
        {
            if (turnPhase == 2)
            {
                checkTurn();
                newTurnBox.Visible = true;
                newTurnBox.Location = new Point(268, 199);
            }
            if (turnPhase == 3)
            {
                checkArmyGain();
                recordPresentArmyData();
                timup = 1;
                deployAlert.Visible = true;
                deployAlert.Location = new Point(317, 202);
                deployBox.Visible = true;
                deployBox.Text = "Deploy Troops: " + turnName;
                troopsDeployedText.Text ="(" + armiesUsed + "/" + armiesTotal + ")";
                alertTimer();
            }
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
        private void checkArmyGain()
        {
            int x = 0;
            if (argentinaColor == turnColor) { x++; }
            if (venezuelaColor == turnColor) { x++; }
            if (brazilColor == turnColor) { x++; }
            if (peruColor == turnColor) { x++; }
            if (centralAmericaColor == turnColor) { x++; }
            if (easternUnitedStatesColor == turnColor) { x++; }
            if (quebecColor == turnColor) { x++; }
            if (westernUnitedStatesColor == turnColor) { x++; }
            if (ontarioColor == turnColor) { x++; }
            if (albertaColor == turnColor) { x++; }
            if (alaskaColor == turnColor) { x++; }
            if (northWestTerritoryColor == turnColor) { x++; }
            if (greenlandColor == turnColor) { x++; }
            if (northAfricaColor == turnColor) { x++; }
            if (egyptColor == turnColor) { x++; }
            if (eastAfricaColor == turnColor) { x++; }
            if (congoColor == turnColor) { x++; }
            if (southAfricaColor == turnColor) { x++; }
            if (madagascarColor == turnColor) { x++; }
            if (westernEuropeColor == turnColor) { x++; }
            if (southernEuropeColor == turnColor) { x++; }
            if (northernEuropeColor == turnColor) { x++; }
            if (greatBritainColor == turnColor) { x++; }
            if (ukraineColor == turnColor) { x++; }
            if (scandinaviaColor == turnColor) { x++; }
            if (icelandColor == turnColor) { x++; }
            if (middleEastColor == turnColor) { x++; }
            if (afghanistanColor == turnColor) { x++; }
            if (indiaColor == turnColor) { x++; }
            if (siamColor == turnColor) { x++; }
            if (chinaColor == turnColor) { x++; }
            if (uralColor == turnColor) { x++; }
            if (mongoliaColor == turnColor) { x++; }
            if (siberiaColor == turnColor) { x++; }
            if (yakutskColor == turnColor) { x++; }
            if (irkutskColor == turnColor) { x++; }
            if (japanColor == turnColor) { x++; }
            if (kamchatkaColor == turnColor) { x++; }
            if (indonesiaColor == turnColor) { x++; }
            if (newGuineaColor == turnColor) { x++; }
            if (westernAustraliaColor == turnColor) { x++; }
            if (easternAustraliaColor == turnColor) { x++; }
            armiesTotal += x / 3;
            if (armiesTotal < 1) { armiesTotal = 1; }
            if (argentinaColor == turnColor && brazilColor == turnColor && venezuelaColor == turnColor && peruColor == turnColor)
            {
                armiesTotal += 2;
            }
            if (indonesiaColor == turnColor && newGuineaColor == turnColor && westernAustraliaColor == turnColor && easternAustraliaColor == turnColor)
            {
                armiesTotal += 2;
            }
            if (northAfricaColor == turnColor && congoColor == turnColor && eastAfricaColor == turnColor && egyptColor == turnColor && southAfricaColor == turnColor && madagascarColor == turnColor)
            {
                armiesTotal += 3;
            }
            if (centralAmericaColor == turnColor && westernUnitedStatesColor == turnColor && easternUnitedStatesColor == turnColor && quebecColor == turnColor && ontarioColor == turnColor && albertaColor == turnColor && alaskaColor == turnColor && northWestTerritoryColor == turnColor && greenlandColor == turnColor)
            {
                armiesTotal += 5;
            }
            if (icelandColor == turnColor && scandinaviaColor == turnColor && greatBritainColor == turnColor && northernEuropeColor == turnColor && westernEuropeColor == turnColor && southernEuropeColor == turnColor && ukraineColor == turnColor)
            {
                armiesTotal += 5;
            }
            if (middleEastColor == turnColor && afghanistanColor == turnColor && indiaColor == turnColor && chinaColor == turnColor && siamColor == turnColor && mongoliaColor == turnColor && uralColor == turnColor && siberiaColor == turnColor && irkutskColor == turnColor && yakutskColor == turnColor && kamchatkaColor == turnColor && japanColor == turnColor)
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
            venezuela.Text = numberData[1]
            brazil.Text = numberData[2]
            peru.Text = numberData[3]
            centralAmerica.Text = numberData[4]
            easternUnitedStates.Text = numberData[5]
            quebec.Text = numberData[6]
            westernUnitedStates.Text = numberData[7]
            ontario.Text = numberData[8]
            alberta.Text = numberData[9]
            alaska.Text = numberData[10]
            northWestTerritory.Text = numberData[0]
            greenLand.Text = numberData[0]
            northAfrica.Text = numberData[0]
            egypt.Text = numberData[0]
            eastAfrica.Text = numberData[0]
            congo.Text = numberData[0]
            southAfrica.Text = numberData[0]
            madagascar.Text = numberData[0]
            westernEurope.Text = numberData[0]
            southernEurope.Text = numberData[0]
            northernEurope.Text = numberData[0]
            greatBritain.Text = numberData[0]
            ukraine.Text = numberData[0]
            scandinavia.Text = numberData[0]
            niceland.Text = numberData[0]
            middleEast.Text = numberData[0]
            afghanistan.Text = numberData[0]
            india.Text = numberData[0]
            siam.Text = numberData[0]
            china.Text = numberData[0]
            ural.Text = numberData[0]
            mongolia.Text = numberData[0]
            siberia.Text = numberData[0]
            yakutsk.Text = numberData[0]
            irkutsk.Text = numberData[0]
            japan.Text = numberData[0]
            kamchatka.Text = numberData[0]
            indonesia.Text = numberData[0]
            newGuinea.Text = numberData[0]
            westernAustralia.Text = numberData[0]
            easternAustralia.Text = numberData[0]
        }
    }
}

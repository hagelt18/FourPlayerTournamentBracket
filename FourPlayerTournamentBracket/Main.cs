using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FourPlayerTournamentBracket

{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                //decimal Total = 15M;
                txtResults.Text = "";
                txtStartingPlayerGroups.Text = "";

                decimal CurrentPlayersInRound = Convert.ToDecimal(txtTotal.Text);

                if (CurrentPlayersInRound < 4)
                {
                    MessageBox.Show("At least four people are required for a four player tournament.");
                    return;
                }
                string result = "";



                int Round = 1;
                while (CurrentPlayersInRound > 1)
                {
                    GetRoundResults(ref result, ref CurrentPlayersInRound, Round);
                    if (txtResults.Text != "") txtResults.Text += Environment.NewLine;
                    txtResults.Text += "ROUND " + Round + ":  " + result;
                    txtResults.Text += Environment.NewLine;
                    Round++;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occured: " + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void GetRoundResults(ref string Result, ref decimal CurrentPlayersInRound, int Round)
        {

            decimal GroupsOfFour = Math.Floor(CurrentPlayersInRound / 4M);
            decimal GroupsOfThree = 0M;
            decimal GroupsOfTwo = 0M;
            decimal NumberOfByes = 0M;
            decimal Remains = CurrentPlayersInRound % 4M;

            if (Remains > 0)
            {
                if (Remains == 1)
                {
                    if (cb3PMatches.Checked && GroupsOfFour >= 2)
                    {
                        //Two groups of four plus one remainder become three groups of three.
                        GroupsOfFour -= 2M;
                        GroupsOfThree += 3M;
                    }
                    else
                    {
                        NumberOfByes = 1M;
                    }
                }

                if (Remains == 2M)
                {
                    if (Remains == CurrentPlayersInRound)
                    {
                        //If this is all that is left, you have to have a group of two.
                        GroupsOfTwo++;
                    }
                    else 
                    {
                        if (cb3PMatches.Checked && GroupsOfFour > 0M)
                        {
                            //If 3 player matches are allowed they are preferred over having a two player match. So we would take a group of four plus the remaining two players and make two groups of three.
                            GroupsOfFour--;
                            GroupsOfThree += 2M;
                        }
                        else
                        {
                            if (cb2PMatches.Checked)
                            {
                                GroupsOfTwo++;
                            }
                            else
                            {
                                NumberOfByes = 2M;
                            }
                        }
                    }


                }
                if (Remains == 3)
                {
                    if (Remains == CurrentPlayersInRound)
                    {
                        //If this is all that is left, you have to have a group of three. Maybe do a round robin here.
                        GroupsOfThree++;
                    }
                    else
                    {
                        if (cb3PMatches.Checked)
                        {
                            GroupsOfThree++; //A remaining group of three is acceptable.
                        }
                        else
                        {

                            if (cb2PMatches.Checked) //If a group of two is allowed, break this into one group of two with one by.
                            {
                                GroupsOfTwo++;
                                NumberOfByes = 1M;
                            }
                            else
                            {
                                //If no smaller groups are allowed, all remaining players get bys.
                                NumberOfByes = 3M;
                            }
                        }
                    }
                }

                Remains = 0M; //Remains should be handled in all cases.
            }

            Result = "";
            if (GroupsOfFour > 0)
            {
                Result += Environment.NewLine + "   ";
                Result += GroupsOfFour + " group" + (GroupsOfFour != 1 ? "s" : "") + " of four.";
            }
            
            if (GroupsOfThree > 0)
            {
                Result += Environment.NewLine + "   ";
                Result += GroupsOfThree + " group" + (GroupsOfThree != 1 ? "s" : "") + " of three.";
            }

            if (GroupsOfTwo > 0)
            {
                Result += Environment.NewLine + "   ";
                Result += GroupsOfTwo + " group" + (GroupsOfTwo !=1 ? "s" : "") + " of two.";
            }


            if (NumberOfByes > 0)
            {
                Result += Environment.NewLine + "   ";
                Result += NumberOfByes + " bye" + (NumberOfByes !=1 ? "s" : "");
                
            }

            if (Round == 1 && !String.IsNullOrWhiteSpace(txtPlayers.Text))
            {
                string[] PlayersArray = txtPlayers.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                List<string> Players = Randomize(PlayersArray).ToList();

                for (int i = 0; i < GroupsOfFour; i++)
                {
                    int UnsortedPlayers = Players.Count;
                    for (int p = UnsortedPlayers - 1; p >= UnsortedPlayers - 4; p--)
                    {
                        if (txtStartingPlayerGroups.Text != "") txtStartingPlayerGroups.Text += Environment.NewLine;
                        txtStartingPlayerGroups.Text += Players[p];
                        Players.RemoveAt(p);
                    }
                    txtStartingPlayerGroups.Text += Environment.NewLine;
                }

                for (int i = 0; i < GroupsOfThree; i++)
                {
                    int UnsortedPlayers = Players.Count;
                    for (int p = UnsortedPlayers - 1; p >= UnsortedPlayers - 3; p--)
                    {
                        if (txtStartingPlayerGroups.Text != "") txtStartingPlayerGroups.Text += Environment.NewLine;
                        txtStartingPlayerGroups.Text += Players[p];
                        Players.RemoveAt(p);
                    }
                    txtStartingPlayerGroups.Text += Environment.NewLine;
                }

                for (int i = 0; i < GroupsOfTwo; i++)
                {
                    int UnsortedPlayers = Players.Count;
                    for (int p = UnsortedPlayers - 1; p >= UnsortedPlayers - 2; p--)
                    {
                        if (txtStartingPlayerGroups.Text != "") txtStartingPlayerGroups.Text += Environment.NewLine;
                        txtStartingPlayerGroups.Text += Players[p];
                        Players.RemoveAt(p);
                    }
                    txtStartingPlayerGroups.Text += Environment.NewLine;
                }

                if (NumberOfByes > 0)
                {
                    int UnsortedPlayers = Players.Count;
                    for (int p = UnsortedPlayers - 1; p >= UnsortedPlayers - NumberOfByes; p--)
                    {
                        if (txtStartingPlayerGroups.Text != "") txtStartingPlayerGroups.Text += Environment.NewLine;
                        txtStartingPlayerGroups.Text += Players[p];
                        Players.RemoveAt(p);
                    }
                    txtStartingPlayerGroups.Text += Environment.NewLine;
                }

            }

            CurrentPlayersInRound = (GroupsOfFour * (Convert.ToDecimal(txt4PVictors.Text))) + (GroupsOfThree * Convert.ToDecimal(txt3PVictors.Text)) + GroupsOfTwo + NumberOfByes;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPlayers_TextChanged(object sender, EventArgs e)
        {
            txtTotal.Enabled = !String.IsNullOrWhiteSpace(txtPlayers.Text);
            txtTotal.Text = txtPlayers.Text.Split(new string[]{ Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries).Length.ToString();
        }

        private string[] Randomize(string[] values)
        {
            Random rnd = new Random();
            string[] MyRandomArray = values.OrderBy(x => rnd.Next()).ToArray();
            return MyRandomArray;
        }
    }

}


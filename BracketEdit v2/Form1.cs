namespace BracketEdit_v2
{
    public partial class BracketEditv2 : Form
    {
        public BracketEditv2()
        {
            InitializeComponent();
        }
        //Defining things for later use.
        string Old_Name = ""; //Edit button placeholder for playerlist
        string Folder_Name = ""; //folder defining stuff
        int Score1 = 0; //group score placeholders
        int Score2 = 0;
        int Score3 = 0;
        int Score4 = 0;
        int Score5 = 0;
        int Score6 = 0;
        int Score7 = 0;
        int Score8 = 0;
        int SBP1Score = 0; //scoreboard score placeholders
        int SBP2Score = 0;
        int SBPlaceholder = 0; //scoreboard switch placeholder
        int GroupIdentifier = 0; //identifies which group is the active match for autosave functionality
        string SBPlaceholderName = "";
        string SBPlayer1N = "";
        string SBPlayer2N = "";

        private void SetGroups2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox4.Hide();
            groupBox5.Hide();
            ScoreboardGroup.Location = new Point(12, 312);
            if (ScoreboardGroup.Visible)
            {
                Top8Bracket.Location = new Point(12, 540);
            }
            else
            {
                Top8Bracket.Location = new Point(12, 312);
            }
        }
        private void SetGroups4_CheckedChanged(object sender, EventArgs e)
        {
            groupBox4.Show();
            groupBox5.Show();
            ScoreboardGroup.Location = new Point(12, 512);
            if (ScoreboardGroup.Visible)
            {
                Top8Bracket.Location = new Point(12, 737);
            }
            else
            {
                Top8Bracket.Location = new Point(12, 512);
            }
        }
        //All of the right side of the window functionalities here.
        private void PlayerListAddBox_KeyPress(object sender, KeyPressEventArgs e) //convenience thing to press enter and add a player
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (PlayerListAddBox.Text != "")
                    PlayerListAdd.PerformClick();
                else
                    return;
            }
        }
        private void PlayerListAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PlayerListAddBox.Text))
                return;
            G1P1NAME.AutoCompleteCustomSource.Add(PlayerListAddBox.Text);
            G1P2NAME.AutoCompleteCustomSource.Add(PlayerListAddBox.Text);
            G2P1NAME.AutoCompleteCustomSource.Add(PlayerListAddBox.Text);
            G2P2NAME.AutoCompleteCustomSource.Add(PlayerListAddBox.Text);
            G3P1NAME.AutoCompleteCustomSource.Add(PlayerListAddBox.Text);
            G3P2NAME.AutoCompleteCustomSource.Add(PlayerListAddBox.Text);
            G4P1NAME.AutoCompleteCustomSource.Add(PlayerListAddBox.Text);
            G4P2NAME.AutoCompleteCustomSource.Add(PlayerListAddBox.Text);
            SBPlayer1Name.AutoCompleteCustomSource.Add(PlayerListAddBox.Text);
            SBPlayer2Name.AutoCompleteCustomSource.Add(PlayerListAddBox.Text);
            PlayerList.Items.Add(PlayerListAddBox.Text);
            PlayerListAddBox.Text = "";
        }
        private void Scoreboard_Click(object sender, EventArgs e)
        {
            if (ScoreboardGroup.Visible == false)
            {
                ScoreboardGroup.Show();
            }
            else if (ScoreboardGroup.Visible == true)
            {
                ScoreboardGroup.Hide();
            };
            if (ScoreboardGroup.Visible == false && SetGroups2.Checked)
            {
                Top8Bracket.Location = new Point(12, 335);
            }
            if (ScoreboardGroup.Visible == false && SetGroups4.Checked)
            {
                Top8Bracket.Location = new Point(12, 512);
            }
            if (ScoreboardGroup.Visible == true && SetGroups2.Checked)
            {
                Top8Bracket.Location = new Point(12, 540);
            }
            if (ScoreboardGroup.Visible == true && SetGroups4.Checked)
            {
                Top8Bracket.Location = new Point(12, 737);
            }
        }
        private void RemovePlayerButton_Click(object sender, EventArgs e)
        {
            if (PlayerList.SelectedItem == null)
            {
                MessageBox.Show("No player name selected.");
                return;
            };
            G1P1NAME.AutoCompleteCustomSource.Remove(PlayerList.SelectedItem.ToString());
            G1P2NAME.AutoCompleteCustomSource.Remove(PlayerList.SelectedItem.ToString());
            G2P1NAME.AutoCompleteCustomSource.Remove(PlayerList.SelectedItem.ToString());
            G2P2NAME.AutoCompleteCustomSource.Remove(PlayerList.SelectedItem.ToString());
            G3P1NAME.AutoCompleteCustomSource.Remove(PlayerList.SelectedItem.ToString());
            G3P2NAME.AutoCompleteCustomSource.Remove(PlayerList.SelectedItem.ToString());
            G4P1NAME.AutoCompleteCustomSource.Remove(PlayerList.SelectedItem.ToString());
            G4P2NAME.AutoCompleteCustomSource.Remove(PlayerList.SelectedItem.ToString());
            SBPlayer1Name.AutoCompleteCustomSource.Remove(PlayerList.SelectedItem.ToString());
            SBPlayer2Name.AutoCompleteCustomSource.Remove(PlayerList.SelectedItem.ToString());
            PlayerList.Items.Remove(PlayerList.SelectedItem.ToString());
        }
        private void EditPlayerButton_Click(object sender, EventArgs e)
        {
            if (PlayerList.SelectedItem == null)
            {
                MessageBox.Show("No player name selected.");
                return;
            };
            Old_Name = (PlayerList.SelectedItem.ToString());
            G1P1NAME.AutoCompleteCustomSource.Remove(PlayerList.SelectedItem.ToString());
            G1P2NAME.AutoCompleteCustomSource.Remove(PlayerList.SelectedItem.ToString());
            G2P1NAME.AutoCompleteCustomSource.Remove(PlayerList.SelectedItem.ToString());
            G2P2NAME.AutoCompleteCustomSource.Remove(PlayerList.SelectedItem.ToString());
            G3P1NAME.AutoCompleteCustomSource.Remove(PlayerList.SelectedItem.ToString());
            G3P2NAME.AutoCompleteCustomSource.Remove(PlayerList.SelectedItem.ToString());
            G4P1NAME.AutoCompleteCustomSource.Remove(PlayerList.SelectedItem.ToString());
            G4P2NAME.AutoCompleteCustomSource.Remove(PlayerList.SelectedItem.ToString());
            SBPlayer1Name.AutoCompleteCustomSource.Remove(PlayerList.SelectedItem.ToString());
            SBPlayer2Name.AutoCompleteCustomSource.Remove(PlayerList.SelectedItem.ToString());
            PlayerList.Items.Remove(PlayerList.SelectedItem.ToString());
            PlayerListAddBox.Text = Old_Name;
            Old_Name = "";
            PlayerListAddBox.Select();

        }
        private void ClearPlayerButton_Click(object sender, EventArgs e)
        {
            PlayerList.Items.Clear();
            G1P1NAME.AutoCompleteCustomSource.Clear();
            G1P2NAME.AutoCompleteCustomSource.Clear();
            G2P1NAME.AutoCompleteCustomSource.Clear();
            G2P2NAME.AutoCompleteCustomSource.Clear();
            G3P1NAME.AutoCompleteCustomSource.Clear();
            G3P2NAME.AutoCompleteCustomSource.Clear();
            G4P1NAME.AutoCompleteCustomSource.Clear();
            G4P2NAME.AutoCompleteCustomSource.Clear();
            SBPlayer1Name.AutoCompleteCustomSource.Clear();
            SBPlayer2Name.AutoCompleteCustomSource.Clear();
            G1P1NAME.Text = "";
            G1P2NAME.Text = "";
            G2P1NAME.Text = "";
            G2P2NAME.Text = "";
            G3P1NAME.Text = "";
            G3P2NAME.Text = "";
            G4P1NAME.Text = "";
            G4P2NAME.Text = "";
        }
        //Create all 11 folders with 4 txt files in each, or recreate the whole folder using Main Folder Location textbox OR dialogbox with default name "bracket"
        private void CreateFilesButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you need a base folder for your Bracket?", "Folder Check", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory); //Creates folder on desktop named Bracket
                System.IO.Directory.CreateDirectory(desktopPath + "\\Bracket");
                MainFolderLocationBox.Text = desktopPath + "\\" + "Bracket";
                Folder_Name = MainFolderLocationBox.Text;
                System.IO.Directory.CreateDirectory(MainFolderLocationBox.Text + "\\" + "Winners Semis 1");
                System.IO.Directory.CreateDirectory(MainFolderLocationBox.Text + "\\" + "Winners Semis 2");
                System.IO.Directory.CreateDirectory(MainFolderLocationBox.Text + "\\" + "Winners Finals");
                System.IO.Directory.CreateDirectory(MainFolderLocationBox.Text + "\\" + "Grand Finals");
                System.IO.Directory.CreateDirectory(MainFolderLocationBox.Text + "\\" + "Grand Finals Reset");
                System.IO.Directory.CreateDirectory(MainFolderLocationBox.Text + "\\" + "Losers Eighths 1");
                System.IO.Directory.CreateDirectory(MainFolderLocationBox.Text + "\\" + "Losers Eighths 2");
                System.IO.Directory.CreateDirectory(MainFolderLocationBox.Text + "\\" + "Losers Quarters 1");
                System.IO.Directory.CreateDirectory(MainFolderLocationBox.Text + "\\" + "Losers Quarters 2");
                System.IO.Directory.CreateDirectory(MainFolderLocationBox.Text + "\\" + "Losers Semis");
                System.IO.Directory.CreateDirectory(MainFolderLocationBox.Text + "\\" + "Losers Finals");

                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Winners Semis 1" + "\\" + "Player 1.txt", "");
                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Winners Semis 1" + "\\" + "Player 2.txt", "");
                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Winners Semis 1" + "\\" + "Score 1.txt", "");
                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Winners Semis 1" + "\\" + "Score 2.txt", "");

                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Winners Semis 2" + "\\" + "Player 1.txt", "");
                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Winners Semis 2" + "\\" + "Player 2.txt", "");
                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Winners Semis 2" + "\\" + "Score 1.txt", "");
                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Winners Semis 2" + "\\" + "Score 2.txt", "");

                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Winners Finals" + "\\" + "Player 1.txt", "");
                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Winners Finals" + "\\" + "Player 2.txt", "");
                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Winners Finals" + "\\" + "Score 1.txt", "");
                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Winners Finals" + "\\" + "Score 2.txt", "");

                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Grand Finals" + "\\" + "Player 1.txt", "");
                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Grand Finals" + "\\" + "Player 2.txt", "");
                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Grand Finals" + "\\" + "Score 1.txt", "");
                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Grand Finals" + "\\" + "Score 2.txt", "");

                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Grand Finals Reset" + "\\" + "Player 1.txt", "");
                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Grand Finals Reset" + "\\" + "Player 2.txt", "");
                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Grand Finals Reset" + "\\" + "Score 1.txt", "");
                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Grand Finals Reset" + "\\" + "Score 2.txt", "");

                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Eighths 1" + "\\" + "Player 1.txt", "");
                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Eighths 1" + "\\" + "Player 2.txt", "");
                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Eighths 1" + "\\" + "Score 1.txt", "");
                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Eighths 1" + "\\" + "Score 2.txt", "");

                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Eighths 2" + "\\" + "Player 1.txt", "");
                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Eighths 2" + "\\" + "Player 2.txt", "");
                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Eighths 2" + "\\" + "Score 1.txt", "");
                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Eighths 2" + "\\" + "Score 2.txt", "");

                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Quarters 1" + "\\" + "Player 1.txt", "");
                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Quarters 1" + "\\" + "Player 2.txt", "");
                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Quarters 1" + "\\" + "Score 1.txt", "");
                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Quarters 1" + "\\" + "Score 2.txt", "");

                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Quarters 2" + "\\" + "Player 1.txt", "");
                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Quarters 2" + "\\" + "Player 2.txt", "");
                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Quarters 2" + "\\" + "Score 1.txt", "");
                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Quarters 2" + "\\" + "Score 2.txt", "");

                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Semis" + "\\" + "Player 1.txt", "");
                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Semis" + "\\" + "Player 2.txt", "");
                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Semis" + "\\" + "Score 1.txt", "");
                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Semis" + "\\" + "Score 2.txt", "");

                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Finals" + "\\" + "Player 1.txt", "");
                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Finals" + "\\" + "Player 2.txt", "");
                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Finals" + "\\" + "Score 1.txt", "");
                System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Finals" + "\\" + "Score 2.txt", "");
            }
            else if (dialogResult != DialogResult.Yes)
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    MainFolderLocationBox.Text = dialog.SelectedPath;
                    Folder_Name = MainFolderLocationBox.Text;

                    System.IO.Directory.CreateDirectory(MainFolderLocationBox.Text + "\\" + "Winners Semis 1");
                    System.IO.Directory.CreateDirectory(MainFolderLocationBox.Text + "\\" + "Winners Semis 2");
                    System.IO.Directory.CreateDirectory(MainFolderLocationBox.Text + "\\" + "Winners Finals");
                    System.IO.Directory.CreateDirectory(MainFolderLocationBox.Text + "\\" + "Grand Finals");
                    System.IO.Directory.CreateDirectory(MainFolderLocationBox.Text + "\\" + "Grand Finals Reset");
                    System.IO.Directory.CreateDirectory(MainFolderLocationBox.Text + "\\" + "Losers Eighths 1");
                    System.IO.Directory.CreateDirectory(MainFolderLocationBox.Text + "\\" + "Losers Eighths 2");
                    System.IO.Directory.CreateDirectory(MainFolderLocationBox.Text + "\\" + "Losers Quarters 1");
                    System.IO.Directory.CreateDirectory(MainFolderLocationBox.Text + "\\" + "Losers Quarters 2");
                    System.IO.Directory.CreateDirectory(MainFolderLocationBox.Text + "\\" + "Losers Semis");
                    System.IO.Directory.CreateDirectory(MainFolderLocationBox.Text + "\\" + "Losers Finals");

                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Winners Semis 1" + "\\" + "Player 1.txt", "");
                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Winners Semis 1" + "\\" + "Player 2.txt", "");
                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Winners Semis 1" + "\\" + "Score 1.txt", "");
                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Winners Semis 1" + "\\" + "Score 2.txt", "");

                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Winners Semis 2" + "\\" + "Player 1.txt", "");
                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Winners Semis 2" + "\\" + "Player 2.txt", "");
                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Winners Semis 2" + "\\" + "Score 1.txt", "");
                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Winners Semis 2" + "\\" + "Score 2.txt", "");

                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Winners Finals" + "\\" + "Player 1.txt", "");
                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Winners Finals" + "\\" + "Player 2.txt", "");
                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Winners Finals" + "\\" + "Score 1.txt", "");
                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Winners Finals" + "\\" + "Score 2.txt", "");

                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Grand Finals" + "\\" + "Player 1.txt", "");
                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Grand Finals" + "\\" + "Player 2.txt", "");
                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Grand Finals" + "\\" + "Score 1.txt", "");
                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Grand Finals" + "\\" + "Score 2.txt", "");

                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Grand Finals Reset" + "\\" + "Player 1.txt", "");
                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Grand Finals Reset" + "\\" + "Player 2.txt", "");
                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Grand Finals Reset" + "\\" + "Score 1.txt", "");
                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Grand Finals Reset" + "\\" + "Score 2.txt", "");

                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Eighths 1" + "\\" + "Player 1.txt", "");
                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Eighths 1" + "\\" + "Player 2.txt", "");
                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Eighths 1" + "\\" + "Score 1.txt", "");
                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Eighths 1" + "\\" + "Score 2.txt", "");

                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Eighths 2" + "\\" + "Player 1.txt", "");
                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Eighths 2" + "\\" + "Player 2.txt", "");
                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Eighths 2" + "\\" + "Score 1.txt", "");
                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Eighths 2" + "\\" + "Score 2.txt", "");

                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Quarters 1" + "\\" + "Player 1.txt", "");
                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Quarters 1" + "\\" + "Player 2.txt", "");
                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Quarters 1" + "\\" + "Score 1.txt", "");
                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Quarters 1" + "\\" + "Score 2.txt", "");

                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Quarters 2" + "\\" + "Player 1.txt", "");
                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Quarters 2" + "\\" + "Player 2.txt", "");
                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Quarters 2" + "\\" + "Score 1.txt", "");
                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Quarters 2" + "\\" + "Score 2.txt", "");

                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Semis" + "\\" + "Player 1.txt", "");
                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Semis" + "\\" + "Player 2.txt", "");
                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Semis" + "\\" + "Score 1.txt", "");
                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Semis" + "\\" + "Score 2.txt", "");

                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Finals" + "\\" + "Player 1.txt", "");
                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Finals" + "\\" + "Player 2.txt", "");
                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Finals" + "\\" + "Score 1.txt", "");
                    System.IO.File.WriteAllText(MainFolderLocationBox.Text + "\\" + "Losers Finals" + "\\" + "Score 2.txt", "");
                }
            }
        }
        //All of the + and - button functionality here
        private void G1S1DECREMENT_Click(object sender, EventArgs e)
        {
            Score1--;
            G1P1Score.Text = Score1.ToString();
            if (Score1 < 0)
            {
                Score1 = 0;
                G1P1Score.Text = "0";
            }
        }
        private void G1S2DECREMENT_Click(object sender, EventArgs e)
        {
            Score2--;
            G1P2Score.Text = Score2.ToString();
            if (Score2 < 0)
            {
                Score2 = 0;
                G1P2Score.Text = "0";
            }
        }
        private void G2S1DECREMENT_Click(object sender, EventArgs e)
        {
            Score3--;
            G2P1Score.Text = Score3.ToString();
            if (Score3 < 0)
            {
                Score3 = 0;
                G2P1Score.Text = "0";
            }
        }
        private void G2S2DECREMENT_Click(object sender, EventArgs e)
        {
            Score4--;
            G2P2Score.Text = Score4.ToString();
            if (Score4 < 0)
            {
                Score4 = 0;
                G2P2Score.Text = "0";
            }
        }
        private void G3S1DECREMENT_Click(object sender, EventArgs e)
        {
            Score5--;
            G3P1Score.Text = Score5.ToString();
            if (Score5 < 0)
            {
                Score5 = 0;
                G3P1Score.Text = "0";
            }
        }
        private void G3S2DECREMENT_Click(object sender, EventArgs e)
        {
            Score6--;
            G3P2Score.Text = Score6.ToString();
            if (Score6 < 0)
            {
                Score6 = 0;
                G3P2Score.Text = "0";
            }
        }
        private void G4S1DECREMENT_Click(object sender, EventArgs e)
        {
            Score7--;
            G4P1Score.Text = Score7.ToString();
            if (Score7 < 0)
            {
                Score7 = 0;
                G4P1Score.Text = "0";
            }
        }
        private void G4S2DECREMENT_Click(object sender, EventArgs e)
        {
            Score8--;
            G4P2Score.Text = Score8.ToString();
            if (Score8 < 0)
            {
                Score8 = 0;
                G4P2Score.Text = "0";
            }
        }
        private void G1S1INCREMENT_Click(object sender, EventArgs e)
        {
            Score1++;
            G1P1Score.Text = Score1.ToString();
        }
        private void G1S2INCREMENT_Click(object sender, EventArgs e)
        {
            Score2++;
            G1P2Score.Text = Score2.ToString();
        }
        private void G2S1INCREMENT_Click(object sender, EventArgs e)
        {
            Score3++;
            G2P1Score.Text = Score3.ToString();
        }
        private void G2S2INCREMENT_Click(object sender, EventArgs e)
        {
            Score4++;
            G2P2Score.Text = Score4.ToString();
        }
        private void G3S1INCREMENT_Click(object sender, EventArgs e)
        {
            Score5++;
            G3P1Score.Text = Score5.ToString();
        }
        private void G3S2INCREMENT_Click(object sender, EventArgs e)
        {
            Score6++;
            G3P2Score.Text = Score6.ToString();
        }
        private void G4S1INCREMENT_Click(object sender, EventArgs e)
        {
            Score7++;
            G4P1Score.Text = Score7.ToString();
        }
        private void G4S2INCREMENT_Click(object sender, EventArgs e)
        {
            Score8++;
            G4P2Score.Text = Score8.ToString();
        }
        //Save Buttons
        private void SaveG1_Click(object sender, EventArgs e)
        {
            if (MainFolderLocationBox.Text == "")
            {
                MessageBox.Show("You have not set a location for the MAIN FOLDER.");
                return;
            }
            else
            {
                File.WriteAllText(Folder_Name + "\\" + G1BracketAreaBox.Text + "\\" + "Player 1.txt", G1P1NAME.Text);
                File.WriteAllText(Folder_Name + "\\" + G1BracketAreaBox.Text + "\\" + "Player 2.txt", G1P2NAME.Text);
                File.WriteAllText(Folder_Name + "\\" + G1BracketAreaBox.Text + "\\" + "Score 1.txt", G1P1Score.Text);
                File.WriteAllText(Folder_Name + "\\" + G1BracketAreaBox.Text + "\\" + "Score 2.txt", G1P2Score.Text);
            }
        }
        private void SaveG2_Click(object sender, EventArgs e)
        {
            if (MainFolderLocationBox.Text == "")
            {
                MessageBox.Show("You have not set a location for the MAIN FOLDER.");
                return;
            }
            else
            {
                File.WriteAllText(Folder_Name + "\\" + G2BracketAreaBox.Text + "\\" + "Player 1.txt", G2P1NAME.Text);
                File.WriteAllText(Folder_Name + "\\" + G2BracketAreaBox.Text + "\\" + "Player 2.txt", G2P2NAME.Text);
                File.WriteAllText(Folder_Name + "\\" + G2BracketAreaBox.Text + "\\" + "Score 1.txt", G2P1Score.Text);
                File.WriteAllText(Folder_Name + "\\" + G2BracketAreaBox.Text + "\\" + "Score 2.txt", G2P2Score.Text);
            }
        }
        private void SaveG3_Click(object sender, EventArgs e)
        {
            if (MainFolderLocationBox.Text == "")
            {
                MessageBox.Show("You have not set a location for the MAIN FOLDER.");
                return;
            }
            else
            {
                File.WriteAllText(Folder_Name + "\\" + G3BracketAreaBox.Text + "\\" + "Player 1.txt", G3P1NAME.Text);
                File.WriteAllText(Folder_Name + "\\" + G3BracketAreaBox.Text + "\\" + "Player 2.txt", G3P2NAME.Text);
                File.WriteAllText(Folder_Name + "\\" + G3BracketAreaBox.Text + "\\" + "Score 1.txt", G3P1Score.Text);
                File.WriteAllText(Folder_Name + "\\" + G3BracketAreaBox.Text + "\\" + "Score 2.txt", G3P2Score.Text);
            }
        }
        private void SaveG4_Click(object sender, EventArgs e)
        {
            if (MainFolderLocationBox.Text == "")
            {
                MessageBox.Show("You have not set a location for the MAIN FOLDER.");
                return;
            }
            else
            {
                File.WriteAllText(Folder_Name + "\\" + G4BracketAreaBox.Text + "\\" + "Player 1.txt", G4P1NAME.Text);
                File.WriteAllText(Folder_Name + "\\" + G4BracketAreaBox.Text + "\\" + "Player 2.txt", G4P2NAME.Text);
                File.WriteAllText(Folder_Name + "\\" + G4BracketAreaBox.Text + "\\" + "Score 1.txt", G4P1Score.Text);
                File.WriteAllText(Folder_Name + "\\" + G4BracketAreaBox.Text + "\\" + "Score 2.txt", G4P2Score.Text);
            }
        }
        //Load Buttons
        private void LoadG1_Click(object sender, EventArgs e)
        {
            {
                if (MainFolderLocationBox.Text == "")
                {
                    MessageBox.Show("You have not set a location for the MAIN FOLDER.");
                    return;
                }
                else
                {
                    G1P1NAME.Text = File.ReadAllText(Folder_Name + "\\" + G1BracketAreaBox.Text + "\\" + "Player 1.txt");
                    G1P2NAME.Text = File.ReadAllText(Folder_Name + "\\" + G1BracketAreaBox.Text + "\\" + "Player 2.txt");
                    G1P1Score.Text = File.ReadAllText(Folder_Name + "\\" + G1BracketAreaBox.Text + "\\" + "Score 1.txt");
                    G1P2Score.Text = File.ReadAllText(Folder_Name + "\\" + G1BracketAreaBox.Text + "\\" + "Score 2.txt");

                }
            }
        }
        private void LoadG2_Click(object sender, EventArgs e)
        {
            if (MainFolderLocationBox.Text == "")
            {
                MessageBox.Show("You have not set a location for the MAIN FOLDER.");
                return;
            }
            else
            {
                G2P1NAME.Text = File.ReadAllText(Folder_Name + "\\" + G2BracketAreaBox.Text + "\\" + "Player 1.txt");
                G2P2NAME.Text = File.ReadAllText(Folder_Name + "\\" + G2BracketAreaBox.Text + "\\" + "Player 2.txt");
                G2P1Score.Text = File.ReadAllText(Folder_Name + "\\" + G2BracketAreaBox.Text + "\\" + "Score 1.txt");
                G2P2Score.Text = File.ReadAllText(Folder_Name + "\\" + G2BracketAreaBox.Text + "\\" + "Score 2.txt");

            }
        }
        private void LoadG3_Click(object sender, EventArgs e)
        {
            if (MainFolderLocationBox.Text == "")
            {
                MessageBox.Show("You have not set a location for the MAIN FOLDER.");
                return;
            }
            else
            {
                G3P1NAME.Text = File.ReadAllText(Folder_Name + "\\" + G3BracketAreaBox.Text + "\\" + "Player 1.txt");
                G3P2NAME.Text = File.ReadAllText(Folder_Name + "\\" + G3BracketAreaBox.Text + "\\" + "Player 2.txt");
                G3P1Score.Text = File.ReadAllText(Folder_Name + "\\" + G3BracketAreaBox.Text + "\\" + "Score 1.txt");
                G3P2Score.Text = File.ReadAllText(Folder_Name + "\\" + G3BracketAreaBox.Text + "\\" + "Score 2.txt");

            }
        }
        private void LoadG4_Click(object sender, EventArgs e)
        {
            if (MainFolderLocationBox.Text == "")
            {
                MessageBox.Show("You have not set a location for the MAIN FOLDER.");
                return;
            }
            else
            {
                G4P1NAME.Text = File.ReadAllText(Folder_Name + "\\" + G4BracketAreaBox.Text + "\\" + "Player 1.txt");
                G4P2NAME.Text = File.ReadAllText(Folder_Name + "\\" + G4BracketAreaBox.Text + "\\" + "Player 2.txt");
                G4P1Score.Text = File.ReadAllText(Folder_Name + "\\" + G4BracketAreaBox.Text + "\\" + "Score 1.txt");
                G4P2Score.Text = File.ReadAllText(Folder_Name + "\\" + G4BracketAreaBox.Text + "\\" + "Score 2.txt");

            }
        }
        //Clear Buttons
        private void ClearG1_Click(object sender, EventArgs e)
        {
            G1P1NAME.Text = "";
            G1P2NAME.Text = "";
            G1P1Score.Text = "0";
            G1P2Score.Text = "0";
            Score1 = 0;
            Score2 = 0;

        }
        private void ClearG2_Click(object sender, EventArgs e)
        {
            G2P1NAME.Text = "";
            G2P2NAME.Text = "";
            G2P1Score.Text = "0";
            G2P2Score.Text = "0";
            Score3 = 0;
            Score4 = 0;
        }
        private void ClearG3_Click(object sender, EventArgs e)
        {
            G3P1NAME.Text = "";
            G3P2NAME.Text = "";
            G3P1Score.Text = "0";
            G3P2Score.Text = "0";
            Score5 = 0;
            Score6 = 0;
        }
        private void ClearG4_Click(object sender, EventArgs e)
        {
            G4P1NAME.Text = "";
            G4P2NAME.Text = "";
            G4P1Score.Text = "0";
            G4P2Score.Text = "0";
            Score7 = 0;
            Score8 = 0;
        }
        //Load functionality given to Bracket Area textboxes when they match the folder structure
        private void G1BracketAreaBox_TextChanged(object sender, EventArgs e)
        {
            if (G1BracketAreaBox.Text == "Winners Semis 1" || G1BracketAreaBox.Text == "Winners Semis 2" || G1BracketAreaBox.Text == "Winners Finals"
               || G1BracketAreaBox.Text == "Grand Finals Reset" || G1BracketAreaBox.Text == "Grand Finals" || G1BracketAreaBox.Text == "Losers Eighths 1"
               || G1BracketAreaBox.Text == "Losers Eighths 2" || G1BracketAreaBox.Text == "Losers Quarters 1" || G1BracketAreaBox.Text == "Losers Quarters 2"
               || G1BracketAreaBox.Text == "Losers Semis" || G1BracketAreaBox.Text == "Losers Finals")
            {
                G1P1NAME.Text = File.ReadAllText(Folder_Name + "\\" + G1BracketAreaBox.Text + "\\" + "Player 1.txt");
                G1P2NAME.Text = File.ReadAllText(Folder_Name + "\\" + G1BracketAreaBox.Text + "\\" + "Player 2.txt");
                G1P1Score.Text = File.ReadAllText(Folder_Name + "\\" + G1BracketAreaBox.Text + "\\" + "Score 1.txt");
                G1P2Score.Text = File.ReadAllText(Folder_Name + "\\" + G1BracketAreaBox.Text + "\\" + "Score 2.txt");
                Score1 = 0;
                Score2 = 0;
            }
            else
            {
                return;
            }
        }
        private void G2BracketAreaBox_TextChanged(object sender, EventArgs e)
        {
            if (G2BracketAreaBox.Text == "Winners Semis 1" || G2BracketAreaBox.Text == "Winners Semis 2" || G2BracketAreaBox.Text == "Winners Finals"
               || G2BracketAreaBox.Text == "Grand Finals Reset" || G2BracketAreaBox.Text == "Grand Finals" || G2BracketAreaBox.Text == "Losers Eighths 1"
               || G2BracketAreaBox.Text == "Losers Eighths 2" || G2BracketAreaBox.Text == "Losers Quarters 1" || G2BracketAreaBox.Text == "Losers Quarters 2"
               || G2BracketAreaBox.Text == "Losers Semis" || G2BracketAreaBox.Text == "Losers Finals")
            {
                G2P1NAME.Text = File.ReadAllText(Folder_Name + "\\" + G2BracketAreaBox.Text + "\\" + "Player 1.txt");
                G2P2NAME.Text = File.ReadAllText(Folder_Name + "\\" + G2BracketAreaBox.Text + "\\" + "Player 2.txt");
                G2P1Score.Text = File.ReadAllText(Folder_Name + "\\" + G2BracketAreaBox.Text + "\\" + "Score 1.txt");
                G2P2Score.Text = File.ReadAllText(Folder_Name + "\\" + G2BracketAreaBox.Text + "\\" + "Score 2.txt");
                Score3 = 0;
                Score4 = 0;
            }
            else
            {
                return;
            }
        }
        private void G3BracketAreaBox_TextChanged(object sender, EventArgs e)
        {
            if (G3BracketAreaBox.Text == "Winners Semis 1" || G3BracketAreaBox.Text == "Winners Semis 2" || G3BracketAreaBox.Text == "Winners Finals"
               || G3BracketAreaBox.Text == "Grand Finals Reset" || G3BracketAreaBox.Text == "Grand Finals" || G3BracketAreaBox.Text == "Losers Eighths 1"
               || G3BracketAreaBox.Text == "Losers Eighths 2" || G3BracketAreaBox.Text == "Losers Quarters 1" || G3BracketAreaBox.Text == "Losers Quarters 2"
               || G3BracketAreaBox.Text == "Losers Semis" || G3BracketAreaBox.Text == "Losers Finals")
            {
                G3P1NAME.Text = File.ReadAllText(Folder_Name + "\\" + G3BracketAreaBox.Text + "\\" + "Player 1.txt");
                G3P2NAME.Text = File.ReadAllText(Folder_Name + "\\" + G3BracketAreaBox.Text + "\\" + "Player 2.txt");
                G3P1Score.Text = File.ReadAllText(Folder_Name + "\\" + G3BracketAreaBox.Text + "\\" + "Score 1.txt");
                G3P2Score.Text = File.ReadAllText(Folder_Name + "\\" + G3BracketAreaBox.Text + "\\" + "Score 2.txt");
                Score5 = 0;
                Score6 = 0;
            }
            else
            {
                return;
            }
        }
        private void G4BracketAreaBox_TextChanged(object sender, EventArgs e)
        {
            if (G4BracketAreaBox.Text == "Winners Semis 1" || G4BracketAreaBox.Text == "Winners Semis 2" || G4BracketAreaBox.Text == "Winners Finals"
               || G4BracketAreaBox.Text == "Grand Finals Reset" || G4BracketAreaBox.Text == "Grand Finals" || G4BracketAreaBox.Text == "Losers Eighths 1"
               || G4BracketAreaBox.Text == "Losers Eighths 2" || G4BracketAreaBox.Text == "Losers Quarters 1" || G4BracketAreaBox.Text == "Losers Quarters 2"
               || G4BracketAreaBox.Text == "Losers Semis" || G4BracketAreaBox.Text == "Losers Finals")
            {
                G4P1NAME.Text = File.ReadAllText(Folder_Name + "\\" + G4BracketAreaBox.Text + "\\" + "Player 1.txt");
                G4P2NAME.Text = File.ReadAllText(Folder_Name + "\\" + G4BracketAreaBox.Text + "\\" + "Player 2.txt");
                G4P1Score.Text = File.ReadAllText(Folder_Name + "\\" + G4BracketAreaBox.Text + "\\" + "Score 1.txt");
                G4P2Score.Text = File.ReadAllText(Folder_Name + "\\" + G4BracketAreaBox.Text + "\\" + "Score 2.txt");
                Score7 = 0;
                Score8 = 0;
            }
            else
            {
                return;
            }
        }
        //Restrict Scoreboxes to ONLY number input
        private void G1P1Score_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        private void G1P2Score_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        private void G2P1Score_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        private void G2P2Score_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        private void G3P1Score_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        private void G3P2Score_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        private void G4P1Score_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        private void G4P2Score_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        private void MainBracketLocationButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                MainFolderLocationBox.Text = dialog.SelectedPath;
                Folder_Name = dialog.SelectedPath;
            }
        }
        private void ScoreboardLocationButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ScoreboardLocation.Text = dialog.SelectedPath;
            }
        }
        //Active Match Buttons
        private void G1ActiveMatchButton_Click(object sender, EventArgs e)
        {
            if (BracketSize1.Checked==false & BracketSize2.Checked==false & BracketSize3.Checked==false & BracketSize4.Checked==false)
            {
                MessageBox.Show("Please set the size of your bracket.");
                return;
            }
            SBBracketArea.Text = G1BracketAreaBox.Text;
            SBPlayer1N = G1P1NAME.Text;
            SBPlayer2N = G1P2NAME.Text;
            SBPlayer1Name.Text = SBPlayer1N;
            SBPlayer2Name.Text = SBPlayer2N;
            SBP1Score = 0;
            SBP2Score = 0;
            SBPlayer1Score.Text = "0";
            SBPlayer2Score.Text = "0";
            PlayerSwitchBox.Checked = false;
            if (ScoreboardGroup.Visible == false)
            {
                ScoreboardGroup.Show();
            }
            if (Top8Bracket.Visible == true && SetGroups2.Checked == true)
            {
                Top8Bracket.Location = new Point(12, 565);
            }
            else if (Top8Bracket.Visible == true && SetGroups4.Checked == true)
            {
                Top8Bracket.Location = new Point(12, 737);
            }
            SBSaveAllButton.PerformClick();
            GroupIdentifier = 1;

        }
        private void G2ActiveMatchButton_Click(object sender, EventArgs e)
        {
            if (BracketSize1.Checked == false & BracketSize2.Checked == false & BracketSize3.Checked == false & BracketSize4.Checked == false)
            {
                MessageBox.Show("Please set the size of your bracket.");
                return;
            }
            SBBracketArea.Text = G2BracketAreaBox.Text;
            SBPlayer1N = G2P1NAME.Text;
            SBPlayer2N = G2P2NAME.Text;
            SBP1Score = 0;
            SBP2Score = 0;
            SBPlayer1Name.Text = G2P1NAME.Text;
            SBPlayer2Name.Text = G2P2NAME.Text;
            SBPlayer1Score.Text = "0";
            SBPlayer2Score.Text = "0";
            PlayerSwitchBox.Checked = false;
            if (ScoreboardGroup.Visible == false)
            {
                ScoreboardGroup.Show();
            }
            if (Top8Bracket.Visible == true && SetGroups2.Checked == true)
            {
                Top8Bracket.Location = new Point(12, 565);
            }
            else if (Top8Bracket.Visible == true && SetGroups4.Checked == true)
            {
                Top8Bracket.Location = new Point(12, 737);
            }
            SBSaveAllButton.PerformClick();
            GroupIdentifier = 2;
        }
        private void G3ActiveMatchButton_Click(object sender, EventArgs e)
        {
            if (BracketSize1.Checked == false & BracketSize2.Checked == false & BracketSize3.Checked == false & BracketSize4.Checked == false)
            {
                MessageBox.Show("Please set the size of your bracket.");
                return;
            }
            SBBracketArea.Text = G3BracketAreaBox.Text;
            SBPlayer1N = G3P1NAME.Text;
            SBPlayer2N = G3P2NAME.Text;
            SBP1Score = 0;
            SBP2Score = 0;
            SBPlayer1Name.Text = G3P1NAME.Text;
            SBPlayer2Name.Text = G3P2NAME.Text;
            SBPlayer1Score.Text = "0";
            SBPlayer2Score.Text = "0";
            PlayerSwitchBox.Checked = false;
            if (ScoreboardGroup.Visible == false)
            {
                ScoreboardGroup.Show();
            }
            if (Top8Bracket.Visible == true && SetGroups2.Checked == true)
            {
                Top8Bracket.Location = new Point(12, 565);
            }
            else if (Top8Bracket.Visible == true && SetGroups4.Checked == true)
            {
                Top8Bracket.Location = new Point(12, 737);
            }
            SBSaveAllButton.PerformClick();
            GroupIdentifier = 3;
        }
        private void G4ActiveMatchButton_Click(object sender, EventArgs e)
        {
            if (BracketSize1.Checked == false & BracketSize2.Checked == false & BracketSize3.Checked == false & BracketSize4.Checked == false)
            {
                MessageBox.Show("Please set the size of your bracket.");
                return;
            }
            SBBracketArea.Text = G4BracketAreaBox.Text;
            SBPlayer1N = G4P1NAME.Text;
            SBPlayer2N = G4P2NAME.Text;
            SBP1Score = 0;
            SBP2Score = 0;
            SBPlayer1Name.Text = G4P1NAME.Text;
            SBPlayer2Name.Text = G4P2NAME.Text;
            SBPlayer1Score.Text = "0";
            SBPlayer2Score.Text = "0";
            PlayerSwitchBox.Checked = false;
            if (ScoreboardGroup.Visible == false)
            {
                ScoreboardGroup.Show();
            }
            if (Top8Bracket.Visible == true && SetGroups2.Checked == true)
            {
                Top8Bracket.Location = new Point(12, 565);
            }
            else if (Top8Bracket.Visible == true && SetGroups4.Checked == true)
            {
                Top8Bracket.Location = new Point(12, 737);
            }
            SBSaveAllButton.PerformClick();
            GroupIdentifier = 4;
        }

        //Scoreboard Specific stuff
        private void SBPlayer1Decrement_Click(object sender, EventArgs e)
        {
            SBP1Score--;
            SBPlayer1Score.Text = SBP1Score.ToString();
            if (SBP1Score < 0)
            {
                SBP1Score = 0;
                SBPlayer1Score.Text = "0";
            }
        }
        private void SBPlayer1Increment_Click(object sender, EventArgs e)
        {
            SBP1Score++;
            SBPlayer1Score.Text = SBP1Score.ToString();
        }
        private void SBPlayer2Decrement_Click(object sender, EventArgs e)
        {
            SBP2Score--;
            SBPlayer2Score.Text = SBP2Score.ToString();
            if (SBP2Score < 0)
            {
                SBP2Score = 0;
                SBPlayer2Score.Text = "0";
            }
        }
        private void SBPlayer2Increment_Click(object sender, EventArgs e)
        {
            SBP2Score++;
            SBPlayer2Score.Text = SBP2Score.ToString();
        }
        private void SBPlayer1Score_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        private void SBPlayer2Score_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        //Checkboxes to identify who's in losers bracket, will automatically check both boxes in reset finals
        private void SBBracketArea_TextChanged(object sender, EventArgs e)

        {
            //Winners Side
            if (SBBracketArea.Text == "Winners Semis 1" && BracketSize1.Checked==true | BracketSize3.Checked==true)
            {
                SBWinnerLocation.Text = "Winners Finals" + "\\" + "Player 1";
                SBLoserLocation.Text = "Losers Quarters 2" + "\\" + "Player 1";
                SBBracketArea.Text = "Winners Semis";
            }
            else if (SBBracketArea.Text == "Winners Semis 1" && BracketSize2.Checked == true | BracketSize4.Checked == true)
            {
                SBWinnerLocation.Text = "Winners Finals" + "\\" + "Player 1";
                SBLoserLocation.Text = "Losers Quarters 1" + "\\" + "Player 1";
                SBBracketArea.Text = "Winners Semis";
            }
            if (SBBracketArea.Text == "Winners Semis 2" && BracketSize1.Checked == true | BracketSize3.Checked == true)
            {
                SBWinnerLocation.Text = "Winners Finals" + "\\" + "Player 2";
                SBLoserLocation.Text = "Losers Quarters 1" + "\\" + "Player 1";
                SBBracketArea.Text = "Winners Semis";
            }
            else if (SBBracketArea.Text == "Winners Semis 2" && BracketSize2.Checked == true | BracketSize4.Checked == true)
            {
                SBWinnerLocation.Text = "Winners Finals" + "\\" + "Player 2";
                SBLoserLocation.Text = "Losers Quarters 2" + "\\" + "Player 1";
                SBBracketArea.Text = "Winners Semis";
            }
            if (SBBracketArea.Text == "Winners Finals")
            {
                SBWinnerLocation.Text = "Grand Finals" + "\\" + "Player 1";
                SBLoserLocation.Text = "Losers Finals" + "\\" + "Player 1";
                SBBracketArea.Text = "Winners Finals";
            }
            //Losers Side
            if (SBBracketArea.Text == "Losers Eighths 1")
            {
                SBWinnerLocation.Text = "Losers Quarters 1" + "\\" + "Player 2";
                SBLoserLocation.Text = "";
                SBBracketArea.Text = "Losers Eighths";
            }
            if (SBBracketArea.Text == "Losers Eighths 2")
            {
                SBWinnerLocation.Text = "Losers Quarters 2" + "\\" + "Player 2";
                SBLoserLocation.Text = "";
                SBBracketArea.Text = "Losers Eighths";
            }
            if (SBBracketArea.Text == "Losers Quarters 1")
            {
                SBWinnerLocation.Text = "Losers Semis" + "\\" + "Player 1";
                SBLoserLocation.Text = "";
                SBBracketArea.Text = "Losers Quarters";
            }
            if (SBBracketArea.Text == "Losers Quarters 2")
            {
                SBWinnerLocation.Text = "Losers Semis" + "\\" + "Player 2";
                SBLoserLocation.Text = "";
                SBBracketArea.Text = "Losers Quarters";
            }
            if (SBBracketArea.Text == "Losers Semis")
            {
                SBWinnerLocation.Text = "Losers Finals" + "\\" + "Player 2";
                SBLoserLocation.Text = "";
                SBBracketArea.Text = "Losers Semis";
            }
            if (SBBracketArea.Text == "Losers Finals")
            {
                SBWinnerLocation.Text = "Grand Finals" + "\\" + "Player 2";
                SBLoserLocation.Text = "";
                SBBracketArea.Text = "Losers Finals";
            }
            //End of Bracket stuff
            if (SBBracketArea.Text == "Grand Finals")
            {
                P1LosersChk.Show();
                P2LosersChk.Show();
            }
            if (SBBracketArea.Text != "Grand Finals")
            {
                P1LosersChk.Hide();
                P2LosersChk.Hide();
            }
            if (SBBracketArea.Text == "Grand Finals Reset")
            {
                P1LosersChk.Show();
                P2LosersChk.Show();
                P1LosersChk.Checked = true;
                P2LosersChk.Checked = true;
            }
        }
        private void SBSwitchButton_Click(object sender, EventArgs e)
        {
            SBPlaceholder = SBP1Score;
            SBPlaceholderName = SBPlayer1N; //Placeholders get P1 Name and Score
            SBPlayer1N = SBPlayer2N;
            SBP1Score = SBP2Score; //P1 gets P2 Name and Score
            SBPlayer2N = SBPlaceholderName;
            SBP2Score = SBPlaceholder; //P2 gets Placeholder Name and Score
            SBPlayer1Name.Text = SBPlayer1N;
            SBPlayer2Name.Text = SBPlayer2N;
            SBPlayer1Score.Text = SBP1Score.ToString();
            SBPlayer2Score.Text = SBP2Score.ToString();
            if (PlayerSwitchBox.Checked == true)
                PlayerSwitchBox.Checked = false;
            else if (PlayerSwitchBox.Checked == false)
                PlayerSwitchBox.Checked = true;
        }
        private void SBSaveAllButton_Click(object sender, EventArgs e)
        {
            {
                if
                    (ScoreboardLocation.Text == "")
                {
                    MessageBox.Show("Specify the location of your scoreboard folder.");
                    return;
                }
                if
                    (ScoreboardLocation.Text != "")
                {
                    File.WriteAllText(ScoreboardLocation.Text + "\\Player 1 Name.txt", SBPlayer1Name.Text);
                    File.WriteAllText(ScoreboardLocation.Text + "\\Player 1 Score.txt", SBPlayer1Score.Text);
                    File.WriteAllText(ScoreboardLocation.Text + "\\Player 2 Name.txt", SBPlayer2Name.Text);
                    File.WriteAllText(ScoreboardLocation.Text + "\\Player 2 Score.txt", SBPlayer2Score.Text);
                    File.WriteAllText(ScoreboardLocation.Text + "\\Bracket Placement.txt", SBBracketArea.Text);
                    if (P1LosersChk.Visible == true && P1LosersChk.Checked == true)
                    {
                        File.WriteAllText(ScoreboardLocation.Text + "\\Player 1 Name.txt", SBPlayer1Name.Text + "[L]");
                    }
                    if (P2LosersChk.Visible == true && P2LosersChk.Checked == true)
                    {
                        File.WriteAllText(ScoreboardLocation.Text + "\\Player 2 Name.txt", SBPlayer2Name.Text + "[L]");
                    }
                }
                else
                {
                    MessageBox.Show("Specify locations for all of your files.");
                }
            }
        }
        private void FinishMatchButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(SBP1Score.ToString(), SBP2Score.ToString());
            if (ScoreboardLocation.Text == "")
            {
                MessageBox.Show("Specify the location of your scoreboard folder.");
                return;
            }
            if (PlayerSwitchBox.Checked == false)
            {
                if (SBP1Score > SBP2Score)
                {
                    File.WriteAllText(MainFolderLocationBox.Text + "//" + SBWinnerLocation.Text + ".txt", SBPlayer1N);
                    if (SBLoserLocation.Text != "")
                    {
                        File.WriteAllText(MainFolderLocationBox.Text + "//" + SBLoserLocation.Text + ".txt", SBPlayer2N);
                    }
                }
                else if (SBP1Score < SBP2Score)
                {
                    File.WriteAllText(MainFolderLocationBox.Text + "//" + SBWinnerLocation.Text + ".txt", SBPlayer2N);
                    if (SBLoserLocation.Text != "")
                    {
                        File.WriteAllText(MainFolderLocationBox.Text + "//" + SBLoserLocation.Text + ".txt", SBPlayer1N);
                    }
                }
                else if (SBP1Score == SBP2Score)
                {
                    MessageBox.Show("A winner has not been determined.");
                    return;
                }
                if (GroupIdentifier == 1)
                {
                    G1P1Score.Text = SBP1Score.ToString();
                    G1P2Score.Text = SBP2Score.ToString();
                    if (AutoSaveResults.Checked == true)
                    {
                        SaveG1.PerformClick();
                    }
                }
                else if (GroupIdentifier == 2)
                {
                    G2P1Score.Text = SBP1Score.ToString();
                    G2P2Score.Text = SBP2Score.ToString();
                    if (AutoSaveResults.Checked == true)
                    {
                        SaveG2.PerformClick();
                    }
                }
                else if (GroupIdentifier == 3)
                {
                    G3P1Score.Text = SBP1Score.ToString();
                    G3P2Score.Text = SBP2Score.ToString();
                    if (AutoSaveResults.Checked == true)
                    {
                        SaveG3.PerformClick();
                    }
                }
                else if (GroupIdentifier == 4)
                {
                    G4P1Score.Text = SBP1Score.ToString();
                    G4P2Score.Text = SBP2Score.ToString();
                    if (AutoSaveResults.Checked == true)
                    {
                        SaveG4.PerformClick();
                    }
                }
                SBBracketArea.Text = "";
                SBPlayer1Score.Text = "0";
                SBPlayer2Score.Text = "0";
                SBPlayer1Name.Text = "";
                SBPlayer2Name.Text = "";
                SBP1Score = 0;
                SBP2Score = 0;
                PlayerSwitchBox.Checked = false;
                GroupIdentifier = 0;
            }
            else if (PlayerSwitchBox.Checked == true)
            {
                if (SBP1Score > SBP2Score)
                {
                    File.WriteAllText(MainFolderLocationBox.Text + "//" + SBWinnerLocation.Text + ".txt", SBPlayer1N);
                    if (SBLoserLocation.Text != "")
                    {
                        File.WriteAllText(MainFolderLocationBox.Text + "//" + SBLoserLocation.Text + ".txt", SBPlayer2N);
                    }
                }
                else if (SBP1Score < SBP2Score)
                {
                    File.WriteAllText(MainFolderLocationBox.Text + "//" + SBWinnerLocation.Text + ".txt", SBPlayer2N);
                    if (SBLoserLocation.Text != "")
                    {
                        File.WriteAllText(MainFolderLocationBox.Text + "//" + SBLoserLocation.Text + ".txt", SBPlayer1N);
                    }
                }
                else if (SBP1Score == SBP2Score)
                {
                    MessageBox.Show("A winner has not been determined.");
                    return;
                }
                if (GroupIdentifier == 1)
                {
                    G1P1Score.Text = SBP2Score.ToString();
                    G1P2Score.Text = SBP1Score.ToString();
                    if (AutoSaveResults.Checked == true)
                    {
                        SaveG1.PerformClick();
                    }
                }
                else if (GroupIdentifier == 2)
                {
                    G2P1Score.Text = SBP2Score.ToString();
                    G2P2Score.Text = SBP1Score.ToString();
                    if (AutoSaveResults.Checked == true)
                    {
                        SaveG2.PerformClick();
                    }
                }
                else if (GroupIdentifier == 3)
                {
                    G3P1Score.Text = SBP2Score.ToString();
                    G3P2Score.Text = SBP1Score.ToString();
                    if (AutoSaveResults.Checked == true)
                    {
                        SaveG3.PerformClick();
                    }
                }
                else if (GroupIdentifier == 4)
                {
                    G4P1Score.Text = SBP2Score.ToString();
                    G4P2Score.Text = SBP1Score.ToString();
                    if (AutoSaveResults.Checked == true)
                    {
                        SaveG4.PerformClick();
                    }
                }
                SBBracketArea.Text = "";
                SBPlayer1Score.Text = "0";
                SBPlayer2Score.Text = "0";
                SBPlayer1Name.Text = "";
                SBPlayer2Name.Text = "";
                SBP1Score = 0;
                SBP2Score = 0;
                PlayerSwitchBox.Checked = false;
                GroupIdentifier = 0;
            }
        }
        //All Bracket Group Functionality here
        private void ViewBracketButton_Click(object sender, EventArgs e)
        {
            if (Top8Bracket.Visible == false)
            {
                Top8Bracket.Show();
            }
            else if (Top8Bracket.Visible == true)
            {
                Top8Bracket.Hide();
            };
            if (ScoreboardGroup.Visible == true && SetGroups2.Checked == true)
            {
                Top8Bracket.Location = new Point(12, 565);
            }
            else if (ScoreboardGroup.Visible == false && SetGroups4.Checked == true)
            {
                Top8Bracket.Location = new Point(12, 512);
            }
            else if (ScoreboardGroup.Visible == true && SetGroups4.Checked == true)
            {
                Top8Bracket.Location = new Point(12, 737);
            }
        }
        private void LoadBracket_Click(object sender, EventArgs e)
        {
            if (MainFolderLocationBox.Text == "")
            {
                MessageBox.Show("Specify the location of your MAIN folder.");
                AutoLoadCheck.Checked = false;
            }
            else
            {
                //Winners Side + Finals
                WS1N1.Text = File.ReadAllText(Folder_Name + "\\" + "Winners Semis 1" + "\\" + "Player 1.txt");
                WS1N2.Text = File.ReadAllText(Folder_Name + "\\" + "Winners Semis 1" + "\\" + "Player 2.txt");
                WS1S1.Text = File.ReadAllText(Folder_Name + "\\" + "Winners Semis 1" + "\\" + "Score 1.txt");
                WS1S2.Text = File.ReadAllText(Folder_Name + "\\" + "Winners Semis 1" + "\\" + "Score 2.txt");

                WS2N1.Text = File.ReadAllText(Folder_Name + "\\" + "Winners Semis 2" + "\\" + "Player 1.txt");
                WS2N2.Text = File.ReadAllText(Folder_Name + "\\" + "Winners Semis 2" + "\\" + "Player 2.txt");
                WS2S1.Text = File.ReadAllText(Folder_Name + "\\" + "Winners Semis 2" + "\\" + "Score 1.txt");
                WS2S2.Text = File.ReadAllText(Folder_Name + "\\" + "Winners Semis 2" + "\\" + "Score 2.txt");

                WFN1.Text = File.ReadAllText(Folder_Name + "\\" + "Winners Finals" + "\\" + "Player 1.txt");
                WFN2.Text = File.ReadAllText(Folder_Name + "\\" + "Winners Finals" + "\\" + "Player 2.txt");
                WFS1.Text = File.ReadAllText(Folder_Name + "\\" + "Winners Finals" + "\\" + "Score 1.txt");
                WFS2.Text = File.ReadAllText(Folder_Name + "\\" + "Winners Finals" + "\\" + "Score 2.txt");

                GFN1.Text = File.ReadAllText(Folder_Name + "\\" + "Grand Finals" + "\\" + "Player 1.txt");
                GFN2.Text = File.ReadAllText(Folder_Name + "\\" + "Grand Finals" + "\\" + "Player 2.txt");
                GFS1.Text = File.ReadAllText(Folder_Name + "\\" + "Grand Finals" + "\\" + "Score 1.txt");
                GFS2.Text = File.ReadAllText(Folder_Name + "\\" + "Grand Finals" + "\\" + "Score 2.txt");

                RFN1.Text = File.ReadAllText(Folder_Name + "\\" + "Grand Finals Reset" + "\\" + "Player 1.txt");
                RFN2.Text = File.ReadAllText(Folder_Name + "\\" + "Grand Finals Reset" + "\\" + "Player 2.txt");
                RFS1.Text = File.ReadAllText(Folder_Name + "\\" + "Grand Finals Reset" + "\\" + "Score 1.txt");
                RFS2.Text = File.ReadAllText(Folder_Name + "\\" + "Grand Finals Reset" + "\\" + "Score 2.txt");

                //Losers Side
                LE1N1.Text = File.ReadAllText(Folder_Name + "\\" + "Losers Eighths 1" + "\\" + "Player 1.txt");
                LE1N2.Text = File.ReadAllText(Folder_Name + "\\" + "Losers Eighths 1" + "\\" + "Player 2.txt");
                LE1S1.Text = File.ReadAllText(Folder_Name + "\\" + "Losers Eighths 1" + "\\" + "Score 1.txt");
                LE1S2.Text = File.ReadAllText(Folder_Name + "\\" + "Losers Eighths 1" + "\\" + "Score 2.txt");

                LE2N1.Text = File.ReadAllText(Folder_Name + "\\" + "Losers Eighths 2" + "\\" + "Player 1.txt");
                LE2N2.Text = File.ReadAllText(Folder_Name + "\\" + "Losers Eighths 2" + "\\" + "Player 2.txt");
                LE2S1.Text = File.ReadAllText(Folder_Name + "\\" + "Losers Eighths 2" + "\\" + "Score 1.txt");
                LE2S2.Text = File.ReadAllText(Folder_Name + "\\" + "Losers Eighths 2" + "\\" + "Score 2.txt");

                LQ1N1.Text = File.ReadAllText(Folder_Name + "\\" + "Losers Quarters 1" + "\\" + "Player 1.txt");
                LQ1N2.Text = File.ReadAllText(Folder_Name + "\\" + "Losers Quarters 1" + "\\" + "Player 2.txt");
                LQ1S1.Text = File.ReadAllText(Folder_Name + "\\" + "Losers Quarters 1" + "\\" + "Score 1.txt");
                LQ1S2.Text = File.ReadAllText(Folder_Name + "\\" + "Losers Quarters 1" + "\\" + "Score 2.txt");

                LQ2N1.Text = File.ReadAllText(Folder_Name + "\\" + "Losers Quarters 2" + "\\" + "Player 1.txt");
                LQ2N2.Text = File.ReadAllText(Folder_Name + "\\" + "Losers Quarters 2" + "\\" + "Player 2.txt");
                LQ2S1.Text = File.ReadAllText(Folder_Name + "\\" + "Losers Quarters 2" + "\\" + "Score 1.txt");
                LQ2S2.Text = File.ReadAllText(Folder_Name + "\\" + "Losers Quarters 2" + "\\" + "Score 2.txt");

                LSN1.Text = File.ReadAllText(Folder_Name + "\\" + "Losers Semis" + "\\" + "Player 1.txt");
                LSN2.Text = File.ReadAllText(Folder_Name + "\\" + "Losers Semis" + "\\" + "Player 2.txt");
                LSS1.Text = File.ReadAllText(Folder_Name + "\\" + "Losers Semis" + "\\" + "Score 1.txt");
                LSS2.Text = File.ReadAllText(Folder_Name + "\\" + "Losers Semis" + "\\" + "Score 2.txt");

                LFN1.Text = File.ReadAllText(Folder_Name + "\\" + "Losers Finals" + "\\" + "Player 1.txt");
                LFN2.Text = File.ReadAllText(Folder_Name + "\\" + "Losers Finals" + "\\" + "Player 2.txt");
                LFS1.Text = File.ReadAllText(Folder_Name + "\\" + "Losers Finals" + "\\" + "Score 1.txt");
                LFS2.Text = File.ReadAllText(Folder_Name + "\\" + "Losers Finals" + "\\" + "Score 2.txt");
            }
        }
        private void AutoLoadCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoLoadCheck.Checked)
            {
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                LoadBracket.PerformClick();
            }
        }

        private void BracketSize1_CheckedChanged(object sender, EventArgs e)
        {
            if (BracketSize1.Checked == true || BracketSize3.Checked == true)
            WFN1.PlaceholderText = "Winner of WS1";
            WFN2.PlaceholderText = "Winner of WS2";
            LQ1N1.PlaceholderText = "Loser of WS2";
            LQ1N2.PlaceholderText = "Winner of LE1";
            LQ2N1.PlaceholderText = "Loser of WS1";
            LQ2N2.PlaceholderText = "Winner of LE2";
            LSN1.PlaceholderText = "Winner of LQ1";
            LSN2.PlaceholderText = "Winner of LQ2";
            LFN1.PlaceholderText = "Loser of WF";
            LFN2.PlaceholderText = "Winner of LS";
            GFN1.PlaceholderText = "Winner of WF";
            GFN2.PlaceholderText = "Winner of LF";
        }

        private void BracketSize3_CheckedChanged(object sender, EventArgs e)
        {
            if (BracketSize1.Checked == true || BracketSize3.Checked == true)
            WFN1.PlaceholderText = "Winner of WS1";
            WFN2.PlaceholderText = "Winner of WS2";
            LQ1N1.PlaceholderText = "Loser of WS2";
            LQ1N2.PlaceholderText = "Winner of LE1";
            LQ2N1.PlaceholderText = "Loser of WS1";
            LQ2N2.PlaceholderText = "Winner of LE2";
            LSN1.PlaceholderText = "Winner of LQ1";
            LSN2.PlaceholderText = "Winner of LQ2";
            LFN1.PlaceholderText = "Loser of WF";
            LFN2.PlaceholderText = "Winner of LS";
            GFN1.PlaceholderText = "Winner of WF";
            GFN2.PlaceholderText = "Winner of LF";
        }

        private void BracketSize2_CheckedChanged(object sender, EventArgs e)
        {
            if (BracketSize2.Checked == true || BracketSize4.Checked == true)
            WFN1.PlaceholderText = "Winner of WS1";
            WFN2.PlaceholderText = "Winner of WS2";
            LQ1N1.PlaceholderText = "Loser of WS1";
            LQ1N2.PlaceholderText = "Winner of LE1";
            LQ2N1.PlaceholderText = "Loser of WS2";
            LQ2N2.PlaceholderText = "Winner of LE2";
            LSN1.PlaceholderText = "Winner of LQ1";
            LSN2.PlaceholderText = "Winner of LQ2";
            LFN1.PlaceholderText = "Loser of WF";
            LFN2.PlaceholderText = "Winner of LS";
            GFN1.PlaceholderText = "Winner of WF";
            GFN2.PlaceholderText = "Winner of LF";
        }

        private void BracketSize4_CheckedChanged(object sender, EventArgs e)
        {
            if (BracketSize2.Checked == true || BracketSize4.Checked == true)
                WFN1.PlaceholderText = "Winner of WS1";
            WFN2.PlaceholderText = "Winner of WS2";
            LQ1N1.PlaceholderText = "Loser of WS1";
            LQ1N2.PlaceholderText = "Winner of LE1";
            LQ2N1.PlaceholderText = "Loser of WS2";
            LQ2N2.PlaceholderText = "Winner of LE2";
            LSN1.PlaceholderText = "Winner of LQ1";
            LSN2.PlaceholderText = "Winner of LQ2";
            LFN1.PlaceholderText = "Loser of WF";
            LFN2.PlaceholderText = "Winner of LS";
            GFN1.PlaceholderText = "Winner of WF";
            GFN2.PlaceholderText = "Winner of LF";
        }
    }
}
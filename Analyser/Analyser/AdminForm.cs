﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using AnalyserLibrary;

namespace Analyser
{
    public partial class AdminForm : Form
    {
        int matchGameType = 1; //references the "match" game type in database

        public AdminForm()
        {
            InitializeComponent();

            //Pre-populate all list and combo boxes with db data.
            PopulatePlayersLstBox();
            PopulatePitchLstBox();
            PopulateOppLstBox();
            PopulateGameLstBox();
            PopulateGameOppCombo();
            PopulateGamePitchCombo();
            PopulatelineupPlayerCombo();
            PopulateLineupPositionCombo();
        }

        /// <summary>
        /// Event handler to create a new player record in the Players db table
        /// </summary>
        private void createPlayerBtn_Click(object sender, EventArgs e)
        {
            string fname = forenameTxt.Text;
            string sname = surnameTxt.Text;
            DateTime dt = dobDtp.Value;

            DateTime checkDate = DateTime.Now.AddYears(-3); //minimum age considered 3

            if (string.IsNullOrEmpty(fname) || string.IsNullOrEmpty(sname))
            {
                MessageBox.Show("Please enter the correct details");
            }
            else if (!fname.All(Char.IsLetter) || !sname.All(Char.IsLetter))
            {
                MessageBox.Show("Only a-z can be used in names");
            }
            else if (dt > DateTime.Now) 
            {
                MessageBox.Show("DOB cannot be in the future");
            }
            else if (dt > checkDate)
            {
                MessageBox.Show("Invalid DOB selected");
            }
            else
            {
                using (DataClassesDataContext dbContext = new DataClassesDataContext())
                {
                    Player player = new Player
                    {
                        Forename = fname,
                        Surname = sname,
                        Dob = dobDtp.Value
                    };
                    dbContext.Players.InsertOnSubmit(player);
                    dbContext.SubmitChanges();
                }
                PopulatePlayersLstBox();
            }
        }

        /// <summary>
        /// Event handler to update a player record in the Players db table
        /// </summary>
        private void updatePlayerBtn_Click(object sender, EventArgs e)
        {
            string fname = forenameTxt.Text;
            string sname = surnameTxt.Text;
            DateTime dt = dobDtp.Value;

            DateTime checkDate = DateTime.Now.AddYears(-3); //minimum age considered 3

            if (string.IsNullOrEmpty(fname) || string.IsNullOrEmpty(sname))
            {
                MessageBox.Show("Please enter the correct details");
            }
            else if (!fname.All(Char.IsLetter) || !sname.All(Char.IsLetter))
            {
                MessageBox.Show("Only a-z can be used in names");
            }
            else if (dt > DateTime.Now)
            {
                MessageBox.Show("DOB cannot be in the future");
            }
            else if (dt > checkDate)
            {
                MessageBox.Show("Invalid DOB selected");
            }
            else
            {
                int selectedPlayerID = Convert.ToInt32(playersLstBox.SelectedValue.ToString());
                using (DataClassesDataContext dbContext = new DataClassesDataContext())
                {
                    //find player in players table
                    Player player = dbContext.Players.Where(p => p.PlayerID.Equals(selectedPlayerID)).SingleOrDefault();
                    //write values
                    player.Forename = forenameTxt.Text;
                    player.Surname = surnameTxt.Text;
                    player.Dob = dobDtp.Value;
                    //update database
                    dbContext.SubmitChanges();
                }
                PopulatePlayersLstBox();
            }
        }

        /// <summary>
        /// Event handler to update player textbox values when selected in the player listbox
        /// </summary>
        private void playersLstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedPlayerID = Convert.ToInt32(playersLstBox.SelectedValue.ToString());
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                //find player in players table
                Player player = dbContext.Players.Where(p => p.PlayerID.Equals(selectedPlayerID)).SingleOrDefault();
                //update textbox values
                forenameTxt.Text = player.Forename;
                surnameTxt.Text = player.Surname;
                dobDtp.Value = player.Dob;
            }
        }

        /// <summary>
        /// Event handler to create a new pitch record in the Pitches db table.
        /// </summary>
        private void createPitchBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pitchNameTxt.Text))
            {
                MessageBox.Show("Please enter the pitch name");
            }
            else
            {
                using (DataClassesDataContext dbContext = new DataClassesDataContext())
                {
                    Pitch pitch = new Pitch()
                    {
                        PitchName = pitchNameTxt.Text,
                    };
                    dbContext.Pitches.InsertOnSubmit(pitch);
                    dbContext.SubmitChanges();
                }
                PopulatePitchLstBox();
            }
        }

        /// <summary>
        /// Event handler to update a pitch record in the Pitches db table
        /// </summary>
        private void updatePitchBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pitchNameTxt.Text))
            {
                MessageBox.Show("Please enter the pitch name");
            }
            else
            {
                int selectedPitchID = Convert.ToInt32(pitchLstBox.SelectedValue.ToString());
                using (DataClassesDataContext dbContext = new DataClassesDataContext())
                {
                    //find pitch in pitches table
                    Pitch pitch = dbContext.Pitches.Where(p => p.PitchID.Equals(selectedPitchID)).SingleOrDefault();
                    //write values
                    pitch.PitchName = pitchNameTxt.Text;
                    //update database
                    dbContext.SubmitChanges();
                }
                PopulatePitchLstBox();
            }
        }

        /// <summary>
        /// Event handler to update pitch textbox values when selected in the pitch listbox
        /// </summary>
        private void pitchLstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedPitchID = Convert.ToInt32(pitchLstBox.SelectedValue.ToString());
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                //find pitch in pitches table
                Pitch pitch = dbContext.Pitches.Where(p => p.PitchID.Equals(selectedPitchID)).SingleOrDefault();
                //update textbox values
                pitchNameTxt.Text = pitch.PitchName;
            }
        }

        /// <summary>
        /// Event handler to create a new opposition record in the Opposition db table.
        /// </summary>
        private void createOppBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(oppNameTxt.Text))
            {
                MessageBox.Show("Please enter the correct details");
            }
            else
            {
                using (DataClassesDataContext dbContext = new DataClassesDataContext())
                {
                    Opponent opponent = new Opponent()
                    {
                        OpponentName = oppNameTxt.Text
                    };
                    dbContext.Opponents.InsertOnSubmit(opponent);
                    dbContext.SubmitChanges();
                }
                PopulateOppLstBox();
            }
        }

        /// <summary>
        /// Event handler to update an opponent record in the Opponents db table
        /// </summary>
        private void updateOppBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(oppNameTxt.Text))
            {
                MessageBox.Show("Please enter the correct details");
            }
            else
            {
                int selectedOpponentID = Convert.ToInt32(oppLstBox.SelectedValue.ToString());
                using (DataClassesDataContext dbContext = new DataClassesDataContext())
                {
                    //find opponent in opponents table
                    Opponent opponent = dbContext.Opponents.Where(o => o.OpponentID.Equals(selectedOpponentID)).SingleOrDefault();
                    //write values
                    opponent.OpponentName = oppNameTxt.Text;
                    //update database
                    dbContext.SubmitChanges();
                }
                PopulateOppLstBox();
            }
        }

        /// <summary>
        /// Event handler to update opponent textbox values when selected in the opponent listbox
        /// </summary>
        private void oppLstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedOpponentID = Convert.ToInt32(oppLstBox.SelectedValue.ToString());
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                //find opponent in opponents table
                Opponent opponent = dbContext.Opponents.Where(o => o.OpponentID.Equals(selectedOpponentID)).SingleOrDefault();
                //update textbox values
                oppNameTxt.Text = opponent.OpponentName;
            }
        }

        /// <summary>
        /// Event handler to update the opponents combo box on click.
        /// </summary>
        private void selectOppComboClick(object sender, EventArgs e)
        {
            PopulateGameOppCombo();
        }

        /// <summary>
        /// Event handler to update the pitch combo box on click.
        /// </summary>
        private void selectPitchComboClick(object sender, EventArgs e)
        {
            PopulateGamePitchCombo();
        }

        /// <summary>
        /// Event handler to create a new game record in the Games db table.
        /// </summary>
        private void createGameBtn_Click(object sender, EventArgs e)
        {
            //Get pitch ID from pitch combo box.
            int pitchID = Convert.ToInt16(gamePitchCombo.GetItemText(gamePitchCombo.SelectedValue));

            //Get opponent ID from opponent combo box.
            int opponentID = Convert.ToInt16(gameOppCombo.GetItemText(gameOppCombo.SelectedValue));

            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                Game game = new Game()
                {
                    GameDate = gameDtp.Value,
                    PitchID = pitchID,
                    OpponentID = opponentID,
                    GameTypeID = matchGameType //global variable delared at start of file
                };
                dbContext.Games.InsertOnSubmit(game);
                dbContext.SubmitChanges();
            }
            PopulateGameLstBox();
        }

        /// <summary>
        /// Event handler to update a new game record in the Games db table.
        /// </summary>
        private void updateGameBtn_Click(object sender, EventArgs e)
        {
            //Get pitch ID from pitch combo box.
            int pitchID = Convert.ToInt16(gamePitchCombo.GetItemText(gamePitchCombo.SelectedValue));

            //Get opponent ID from opponent combo box.
            int opponentID = Convert.ToInt16(gameOppCombo.GetItemText(gameOppCombo.SelectedValue));

            int selectedGameID = Convert.ToInt32(gameLstBox.SelectedValue.ToString());
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                //find game in games table
                Game game = dbContext.Games.Where(g => g.GameID.Equals(selectedGameID)).SingleOrDefault();
                //write values
                game.GameDate = gameDtp.Value;
                game.OpponentID = opponentID;
                game.PitchID = pitchID;
                //update database
                dbContext.SubmitChanges();
            }
            PopulateGameLstBox();
        }

        /// <summary>
        /// Event handler to update game textbox values when selected in the game listbox
        /// </summary>
        private void gameLstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedGameID = Convert.ToInt32(gameLstBox.SelectedValue.ToString());
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                //find game in games table
                Game game = dbContext.Games.Where(g => g.GameID.Equals(selectedGameID)).SingleOrDefault();
                //update textbox values
                gameDtp.Value = game.GameDate;
                gameOppCombo.SelectedValue = game.OpponentID;
                gamePitchCombo.SelectedValue = game.PitchID;
            }
        }

        /// <summary>
        /// Event handler to search for game details and update gameSearchLstBox with results
        /// </summary>
        private void lineupSearchTxtChanged(object sender, EventArgs e)
        {
            //capture entered details
            string searchType = lineupGameSearchCombo.Text;
            string searchString = lineupGameSearchTxt.Text;

            //ensure searchstring hasn't been completely deleted
            if (string.IsNullOrEmpty(searchString))
            {
                lineupSearchResultsLstBox.DataSource = null;
            }
            //populate list box
            else
            {
                PopulateLineupSearchLstBox(searchType, searchString);
            }
        }

        /// <summary>
        /// Event handler to update the lineupPlayersLstBox based on a selected game.
        /// </summary>
        private void gameSearchLstBoxIndexChanged(object sender, EventArgs e)
        {
            string searchString = lineupGameSearchTxt.Text;
            if (string.IsNullOrEmpty(searchString))
            {
                lineupPlayersLstBox.DataSource = null;
            }
            else
            {
                int gameID = Convert.ToInt16(lineupSearchResultsLstBox.GetItemText(lineupSearchResultsLstBox.SelectedValue));
                PopulateLineupPlayersLstBox(gameID);
            }
        }

        /// <summary>
        /// Event handler to update the player combo box on click.
        /// </summary>
        private void selectPlayerComboClick(object sender, EventArgs e)
        {
            PopulatelineupPlayerCombo();
        }

        /// <summary>
        /// Event handler to update the position combo box on click.
        /// </summary>
        private void selectPositionComboClick(object sender, EventArgs e)
        {
            PopulateLineupPositionCombo();
        }

        /// <summary>
        /// Event handler to create a new lineup record in the Lineups db table.
        /// </summary>
        private void addPlayerToLineupBtn_Click(object sender, EventArgs e)
        {
            if (lineupSearchResultsLstBox.SelectedIndex != -1)
            {
                int gameID = Convert.ToInt16(lineupSearchResultsLstBox.GetItemText(lineupSearchResultsLstBox.SelectedValue));

                int playerID = Convert.ToInt16(lineupPlayerCombo.GetItemText(lineupPlayerCombo.SelectedValue));

                int positionID = Convert.ToInt16(lineupPositionCombo.GetItemText(lineupPositionCombo.SelectedValue));

                using (DataClassesDataContext dbContext = new DataClassesDataContext())
                {
                    Lineup lineup = new Lineup
                    {
                        GameID = gameID,
                        PlayerID = playerID,
                        PositionID = positionID
                    };
                    dbContext.Lineups.InsertOnSubmit(lineup);
                    dbContext.SubmitChanges();
                }
                PopulateLineupPlayersLstBox(gameID);
            }
            else
            {
                MessageBox.Show("Please enter all details");
            }
        }

        /// <summary>
        /// Event handler to remove a lineup record in the Lineups db table.
        /// </summary>
        private void removeLineupItemBtn_Click(object sender, EventArgs e)
        {
            if (lineupPlayersLstBox.SelectedIndex != -1)
            {
                int gameID = Convert.ToInt16(lineupSearchResultsLstBox.GetItemText(lineupSearchResultsLstBox.SelectedValue));

                int lineupID = Convert.ToInt16(lineupPlayersLstBox.GetItemText(lineupPlayersLstBox.SelectedValue)); ;

                using (DataClassesDataContext dbContext = new DataClassesDataContext())
                {
                    Lineup lineup = dbContext.Lineups.Single(l => l.LineupID == lineupID);
                    dbContext.Lineups.DeleteOnSubmit(lineup);
                    dbContext.SubmitChanges();
                }
                PopulateLineupPlayersLstBox(gameID);
            }
            else
            {
                MessageBox.Show("Please select a player");
            }
        }

        //Methods to populate form elements with database data

        private void PopulatePlayersLstBox()
        {
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                playersLstBox.DisplayMember = "FullName";
                playersLstBox.ValueMember = "PlayerID";
                playersLstBox.DataSource = dbContext.PlayerFullNameProc();
            }
        }

        private void PopulatePitchLstBox()
        {
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                pitchLstBox.DisplayMember = "PitchName";
                pitchLstBox.ValueMember = "PitchID";
                pitchLstBox.DataSource = dbContext.Pitches;
            }
        }

        private void PopulateOppLstBox()
        {
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                oppLstBox.DisplayMember = "OpponentName";
                oppLstBox.ValueMember = "OpponentID";
                oppLstBox.DataSource = dbContext.SelectOpponentsBarTraining();
            }
        }

        private void PopulateGameOppCombo()
        {
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                gameOppCombo.DisplayMember = "OpponentName";
                gameOppCombo.ValueMember = "OpponentID";
                gameOppCombo.DataSource = dbContext.SelectOpponentsBarTraining();
            }
        }

        private void PopulateGamePitchCombo()
        {
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                gamePitchCombo.DisplayMember = "PitchName";
                gamePitchCombo.ValueMember = "PitchID";
                gamePitchCombo.DataSource = dbContext.Pitches;
            }
        }

        private void PopulateGameLstBox()
        {
            if (string.IsNullOrEmpty(gameFilterTxt.Text))
            {
                using (DataClassesDataContext dbContext = new DataClassesDataContext())
                {
                    gameLstBox.DisplayMember = "GameDetails";
                    gameLstBox.ValueMember = "GameID";
                    gameLstBox.DataSource = dbContext.GameDetailsProc();
                }
            }
            else
            {
                string searchString = gameFilterTxt.Text;
                using (DataClassesDataContext dbContext = new DataClassesDataContext())
                {
                    gameLstBox.DisplayMember = "GameDetails";
                    gameLstBox.ValueMember = "GameID";
                    gameLstBox.DataSource = dbContext.GameDetailsByOppProc(searchString);
                }
            }
        }

        private void PopulatelineupPlayerCombo()
        {
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                lineupPlayerCombo.DisplayMember = "FullName";
                lineupPlayerCombo.ValueMember = "PlayerID";
                lineupPlayerCombo.DataSource = dbContext.PlayerFullNameProc();
            }
        }

        private void PopulateLineupPositionCombo()
        {
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                lineupPositionCombo.DisplayMember = "Position1";
                lineupPositionCombo.ValueMember = "PositionID";
                lineupPositionCombo.DataSource = dbContext.Positions;
            }
        }

        private void PopulateLineupSearchLstBox(string searchType, string searchString)
        {
            try
            {
                //check that search type is date and the search string is integer 
                if (searchType == "Date" && Int32.TryParse(searchString, out int temp))
                {
                    using (DataClassesDataContext dbContext = new DataClassesDataContext())
                    {
                        lineupSearchResultsLstBox.ValueMember = "GameID";
                        lineupSearchResultsLstBox.DisplayMember = "LineupDetails";
                        lineupSearchResultsLstBox.DataSource = dbContext.GameSearchByDateProc(Convert.ToInt32(searchString));
                    }
                }
                else if (searchType == "Opposition")
                {
                    using (DataClassesDataContext dbContext = new DataClassesDataContext())
                    {
                        lineupSearchResultsLstBox.ValueMember = "GameID";
                        lineupSearchResultsLstBox.DisplayMember = "LineupDetails";
                        lineupSearchResultsLstBox.DataSource = dbContext.GameSearchByOpponentProc(searchString);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void PopulateLineupPlayersLstBox(int gameID)
        {
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                lineupPlayersLstBox.DisplayMember = "LineupDetails";
                lineupPlayersLstBox.ValueMember = "LineupID";
                lineupPlayersLstBox.DataSource = dbContext.PlayerLineupDetailsProc(gameID);
            }
        }

        private void gameFilterTxt_TextChanged(object sender, EventArgs e)
        {
            PopulateGameLstBox();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using AnalyserLibrary;

namespace Analyser
{
    public partial class AdminForm : Form
    {
        int matchGameType = 1; //references the match game type in database

        public AdminForm()
        {
            InitializeComponent();
            DataClassesDataContext dbContext = new DataClassesDataContext();
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
        private void registerPlayerBtn_Click(object sender, EventArgs e)
        {
            if (forenameTxt.Text == "" || surnameTxt.Text == "")
            {
                MessageBox.Show("Please enter the correct details");
            }
            else
            {
                using (DataClassesDataContext dbContext = new DataClassesDataContext())
                {
                    Player player = new Player
                    {
                        Forename = forenameTxt.Text,
                        Surname = surnameTxt.Text,
                        Dob = dobDtp.Value
                    };
                    dbContext.Players.InsertOnSubmit(player);
                    dbContext.SubmitChanges();
                }
                PopulatePlayersLstBox();
            }
        }

        /// <summary>
        /// Event handler to create a new pitch record in the Pitches db table.
        /// </summary>
        private void createPitchBtn_Click(object sender, EventArgs e)
        {
            //Data entry validation carried out in separate method.
            if (ArePitchDetailsValid() == false)
            {
                MessageBox.Show("Please enter the correct details");
            }
            else
            {
                using (DataClassesDataContext dbContext = new DataClassesDataContext())
                {
                    Pitch pitch = new Pitch()
                    {
                        PitchName = pitchNameTxt.Text,
                        NPointLat = Convert.ToDouble(pitchNLatTxt.Text),
                        NPointLon = Convert.ToDouble(pitchNLonTxt.Text),
                        EPointLat = Convert.ToDouble(pitchELatTxt.Text),
                        EPointLon = Convert.ToDouble(pitchELonTxt.Text),
                        SPoingLat = Convert.ToDouble(pitchSLatTxt.Text),
                        SPointLon = Convert.ToDouble(pitchSLonTxt.Text),
                        WPointLat = Convert.ToDouble(pitchWLatTxt.Text),
                        WPointLon = Convert.ToDouble(pitchWLonTxt.Text),
                    };
                    dbContext.Pitches.InsertOnSubmit(pitch);
                    dbContext.SubmitChanges();
                }
                PopulatePitchLstBox();
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
            if (gameOppCombo.Text == "" || gamePitchCombo.Text == "")
            {
                MessageBox.Show("Please enter the correct details");
            }
            else
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
                        GameTypeID = matchGameType
                    };
                    dbContext.Games.InsertOnSubmit(game);
                    dbContext.SubmitChanges();
                }
                PopulateGameLstBox();
            }
        }

        /// <summary>
        /// Event handler to search for game details and update gameSearchLstBox with results
        /// </summary>
        private void lineupSearchTxtChanged(object sender, EventArgs e)
        {
            string searchType = lineupGameSearchCombo.Text;
            string searchString = lineupGameSearchTxt.Text;
            PopulateLineupSearchLstBox(searchType, searchString);
        }

        /// <summary>
        /// Event handler to update the lineupPlayersLstBox based on a selected game.
        /// </summary>
        private void gameSearchLstBoxIndexChanged(object sender, EventArgs e)
        {
            int gameID = Convert.ToInt16(lineupSearchResultsLstBox.GetItemText(lineupSearchResultsLstBox.SelectedValue));
            PopulateLineupPlayersLstBox(gameID);
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
        /// Event handler to update the pitch combo box on click.
        /// </summary>
        private void SelectPitchComboIndexChanged(object sender, EventArgs e)
        {
            PopulateGamePitchCombo();
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

        //Methods to populate form elements with DB data

        private void PopulatePlayersLstBox()
        {
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                playersLstBox.DisplayMember = "Forename";
                playersLstBox.ValueMember = "PlayerID";
                playersLstBox.DataSource = dbContext.Players;
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
                oppLstBox.DataSource = dbContext.Opponents;
            }
        }

        private void PopulateGameOppCombo()
        {
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                gameOppCombo.DisplayMember = "OpponentName";
                gameOppCombo.ValueMember = "OpponentID";
                gameOppCombo.DataSource = dbContext.Opponents;
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
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                gameLstBox.DisplayMember = "GameID";
                gameLstBox.ValueMember = "GameID";
                gameLstBox.DataSource = dbContext.Games;
            }
        }

        private void PopulatelineupPlayerCombo()
        {
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                lineupPlayerCombo.DisplayMember = "FullDetails";
                lineupPlayerCombo.ValueMember = "PlayerID";
                lineupPlayerCombo.DataSource = dbContext.Players;
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
            List<Game> gameList = new List<Game>();
            try
            {
                if (searchType == "Date")
                {
                    using (DataClassesDataContext dbContext = new DataClassesDataContext())
                    {
                        foreach (var game in dbContext.Games)
                        {
                            if (game.GameDate.ToString().Contains(searchString) && searchString != "")
                            {
                                gameList.Add(game);
                            }
                        }
                    }
                }
                else if (searchType == "Opposition")
                {
                    using (DataClassesDataContext dbContext = new DataClassesDataContext())
                    {
                        foreach (var game in dbContext.Games)
                        {
                            string oppName = game.Opponent.OpponentName.ToUpper();
                            if (oppName.Contains(searchString.ToUpper()) && searchString != "")
                            {
                                gameList.Add(game);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            lineupSearchResultsLstBox.ValueMember = "GameID";
            lineupSearchResultsLstBox.DisplayMember = "GameDate";
            lineupSearchResultsLstBox.DataSource = gameList;
        }

        private void PopulateLineupPlayersLstBox(int gameID)
        {
            List<Lineup> lineupList = new List<Lineup>();
            try
            {
                using (DataClassesDataContext dbContext = new DataClassesDataContext())
                {
                    foreach (var lineup in dbContext.Lineups)
                    {
                        if (lineup.GameID == gameID)
                        {
                            lineupList.Add(lineup);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            lineupPlayersLstBox.DisplayMember = "PlayerID";
            lineupPlayersLstBox.ValueMember = "LineupID";
            lineupPlayersLstBox.DataSource = lineupList;
        }

        //Validation methods

        /// <summary>
        /// Presence and type check for pitch details text boxes
        /// </summary>
        /// <returns>bool</returns>
        private bool ArePitchDetailsValid()
        {
            bool detailsCorrect = false;
            if (
                string.IsNullOrEmpty(pitchNameTxt.Text) ||
                string.IsNullOrEmpty(pitchELatTxt.Text) ||
                string.IsNullOrEmpty(pitchELonTxt.Text) ||
                string.IsNullOrEmpty(pitchWLatTxt.Text) ||
                string.IsNullOrEmpty(pitchWLonTxt.Text) ||
                string.IsNullOrEmpty(pitchNLatTxt.Text) ||
                string.IsNullOrEmpty(pitchNLonTxt.Text) ||
                string.IsNullOrEmpty(pitchSLatTxt.Text) ||
                string.IsNullOrEmpty(pitchSLonTxt.Text)
                )
            {
                detailsCorrect = false;
            }
            else
            {
                if (
                    double.TryParse(pitchELatTxt.Text, out double ELat) &&
                    double.TryParse(pitchELonTxt.Text, out double ELon) &&
                    double.TryParse(pitchWLatTxt.Text, out double WLat) &&
                    double.TryParse(pitchWLonTxt.Text, out double WLon) &&
                    double.TryParse(pitchNLatTxt.Text, out double NLat) &&
                    double.TryParse(pitchNLonTxt.Text, out double NLon) &&
                    double.TryParse(pitchSLatTxt.Text, out double SLat) &&
                    double.TryParse(pitchSLonTxt.Text, out double SLon)
                    )
                {
                    detailsCorrect = true;
                }
            }
            return detailsCorrect;
        }

        //Methods to format string output of form elements

        private void FormatGameString(object sender, ListControlConvertEventArgs e)
        {
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                string date = ((Game)e.ListItem).GameDate.ToShortDateString();
                string oppName = (dbContext.Opponents.Where(o => o.OpponentID == ((Game)e.ListItem).OpponentID)).Single().OpponentName;
                e.Value = string.Format("Date: {0} - Opponent: {1}", date, oppName);
            }
        }

        private void FormatPlayersString(object sender, ListControlConvertEventArgs e)
        {
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                string forename = ((Player)e.ListItem).Forename;
                string surname = ((Player)e.ListItem).Surname;
                e.Value = string.Format("{0} {1}", forename, surname);
            }
        }

        private void FormatLineupPlayersString(object sender, ListControlConvertEventArgs e)
        {
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                string forename = (dbContext.Players.Where(p => p.PlayerID == ((Lineup)e.ListItem).PlayerID)).Single().Forename;
                string surname = (dbContext.Players.Where(p => p.PlayerID == ((Lineup)e.ListItem).PlayerID)).Single().Surname;
                string position = (dbContext.Positions.Where(p => p.PositionID == ((Lineup)e.ListItem).PositionID)).Single().Position1;
                e.Value = string.Format("{0} {1} - {2}", forename, surname, position);
            }
        }

        private void FormatLineupSearchResultsString(object sender, ListControlConvertEventArgs e)
        {
            //using (DataClassesDataContext dbContext = new DataClassesDataContext())
            //{
            //    string date = ((Game)e.ListItem).GameDate.ToShortDateString();
            //    int oppID = (int)((Game)e.ListItem).OpponentID;

            //    //use opponentID to access opponent fields and get opponentName
            //    string oppName = (dbContext.Opponents.Where(o => o.OpponentID == oppID)).Single().OpponentName;

            //    e.Value = string.Format("Date: {0} - Opponent: {1}", date, oppName);
            //}
        }
    }
}

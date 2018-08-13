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
            if (string.IsNullOrEmpty(searchString))
            {
                lineupSearchResultsLstBox.DataSource = null;
            }
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
                gameLstBox.DisplayMember = "GameDetails";
                gameLstBox.ValueMember = "GameID";
                gameLstBox.DataSource = dbContext.GameDetailsProc();
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
    }
}

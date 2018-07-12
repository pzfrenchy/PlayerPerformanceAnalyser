using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using AnalyserLibrary;

namespace Analyser
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();

            //Pre-populate all list and combo boxes with db data.
            PopulatePlayersLstBox();
            PopulatePitchLstBox();
            PopulateOppLstBox();
            PopulateMatchOppCombo();
            PopulateMatchPitchCombo();
            PopulateMatchLstBox();
            PopulateLineupPlayerCombo();
            PopulateLineupPositionCombo();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OptionsForm options = new OptionsForm();
            options.Show();
        }

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

        private void selectOppComboClick(object sender, EventArgs e)
        {
            PopulateMatchOppCombo();
        }

        private void selectPitchComboClick(object sender, EventArgs e)
        {
            PopulateMatchPitchCombo();
        }

        private void createMatchBtn_Click(object sender, EventArgs e)
        {
            if (selectOppCombo.Text == "" || selectPitchCombo.Text == "")
            {
                MessageBox.Show("Please enter the correct details");
            }
            else
            {
                //Get pitch ID from pitch combo box.
                string[] selectedPitch = selectPitchCombo.Text.Split(' ');
                int pitchID = Convert.ToInt16(selectedPitch[1]);

                //Get opponent ID from opponent combo box.
                string[] selectedOpponent = selectOppCombo.Text.Split(' ');
                int opponentID = Convert.ToInt16(selectedOpponent[1]);

                using (DataClassesDataContext dbContext = new DataClassesDataContext())
                {
                    Game game = new Game()
                    {
                        GameDate = matchDtp.Value,
                        PitchID = pitchID,
                        OpponentID = opponentID
                    };
                    dbContext.Games.InsertOnSubmit(game);
                    dbContext.SubmitChanges();
                }
                PopulateMatchLstBox();
            }
        }

        private void lineupSearchTxtChanged(object sender, EventArgs e)
        {
            if (matchSearchCombo.Text == "ID")
            {
                using (DataClassesDataContext dbContext = new DataClassesDataContext())
                {
                    matchSearchResultsLstBox.Items.Clear();
                    foreach (var game in dbContext.Games)
                    {
                        if (game.GameID.ToString().Contains(matchSearchTxt.Text) && matchSearchTxt.Text != "")
                        {
                            matchSearchResultsLstBox.Items.Add(string.Format("ID: {0} - Date: {1} Opposition: {2}", game.GameID, game.GameDate, game.Opponent.OpponentName));
                        }
                    }
                }
            }
            else if (matchSearchCombo.Text == "Date")
            {
                using (DataClassesDataContext dbContext = new DataClassesDataContext())
                {
                    matchSearchResultsLstBox.Items.Clear();
                    foreach (var game in dbContext.Games)
                    {
                        if (game.GameDate.ToString().Contains(matchSearchTxt.Text) && matchSearchTxt.Text != "")
                        {
                            matchSearchResultsLstBox.Items.Add(string.Format("ID: {0} - Date: {1} Opposition: {2}", game.GameID, game.GameDate, game.Opponent.OpponentName));
                        }
                    }
                }
            }
            else if (matchSearchCombo.Text == "Opposition")
            {
                using (DataClassesDataContext dbContext = new DataClassesDataContext())
                {
                    matchSearchResultsLstBox.Items.Clear();
                    foreach (var game in dbContext.Games)
                    {
                        string oppName = game.Opponent.OpponentName.ToUpper();
                        if (oppName.Contains(matchSearchTxt.Text.ToUpper()) && matchSearchTxt.Text != "")
                        {
                            matchSearchResultsLstBox.Items.Add(string.Format("ID: {0} - Date: {1} Opposition: {2}", game.GameID, game.GameDate, game.Opponent.OpponentName));
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select your search type");
            }
        }

        private void matchSearchLstBoxIndexChanged(object sender, EventArgs e)
        {
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                PopulateLineupLstBox();
            }
        }

        private void selectPlayerComboClick(object sender, EventArgs e)
        {
            PopulateLineupPlayerCombo();
        }

        private void selectPositionComboClick(object sender, EventArgs e)
        {
            PopulateLineupPositionCombo();
        }

        private void addPlayerToLineupBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string[] selectedMatch = matchSearchResultsLstBox.Text.Split(' ');
                int matchID = Convert.ToInt16(selectedMatch[1]);

                string[] selectedPlayer = selectPlayerCombo.Text.Split(' ');
                int playerID = Convert.ToInt16(selectedPlayer[1]);

                string[] selectedPosition = selectPositionCombo.Text.Split(' ');
                int positionID = Convert.ToInt16(selectedPosition[1]);

                using (DataClassesDataContext dbContext = new DataClassesDataContext())
                {
                    Lineup lineup = new Lineup
                    {
                        GameID = matchID,
                        PlayerID = playerID,
                        PositionID = positionID
                    };
                    dbContext.Lineups.InsertOnSubmit(lineup);
                    dbContext.SubmitChanges();
                }
                PopulateLineupLstBox();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Please enter all details");
            }
        }

        private void removeLineupItemBtn_Click(object sender, EventArgs e)
        {
            if (lineupPlayersLstBox.Text == "")
            {
                MessageBox.Show("Please select a player");
            }
            else
            {
                //string[] selectedLineupPlayerID = 
            }
        }

        //The following methods are for populating form controls with data.

        private void PopulatePlayersLstBox()
        {
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                playersLstBox.Items.Clear();
                foreach (var player in dbContext.Players)
                {
                    playersLstBox.Items.Add(string.Format("{0} {1} DOB: {2}", player.Forename, player.Surname, player.Dob.ToShortDateString()));
                }
            }
        }

        private void PopulatePitchLstBox()
        {
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                pitchLstBox.Items.Clear();
                foreach (var pitch in dbContext.Pitches)
                {
                    pitchLstBox.Items.Add(pitch.PitchName);
                }
            }
        }

        private void PopulateOppLstBox()
        {
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                oppLstBox.Items.Clear();
                foreach (var opponents in dbContext.Opponents)
                {
                    oppLstBox.Items.Add(string.Format("ID: {0} - {1}", opponents.OpponentID, opponents.OpponentName));
                }
            }
        }

        private void PopulateMatchOppCombo()
        {
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                selectOppCombo.Items.Clear();
                foreach (var opponents in dbContext.Opponents)
                {
                    selectOppCombo.Items.Add(string.Format("ID: {0} - {1}", opponents.OpponentID, opponents.OpponentName));
                }
            }
        }

        private void PopulateMatchPitchCombo()
        {
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                selectPitchCombo.Items.Clear();
                foreach (var pitch in dbContext.Pitches)
                {
                    selectPitchCombo.Items.Add(string.Format("ID: {0} - {1}", pitch.PitchID, pitch.PitchName));
                }
            }
        }

        private void PopulateMatchLstBox()
        {
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                matchLstBox.Items.Clear();
                foreach (var game in dbContext.Games)
                {
                    matchLstBox.Items.Add(string.Format("{0} {1} {2}", game.GameDate.Value.ToShortDateString(), game.Opponent.OpponentName, game.Pitch.PitchName));
                }
            }
        }

        private void PopulateLineupPlayerCombo()
        {
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                selectPlayerCombo.Items.Clear();
                foreach (var player in dbContext.Players)
                {
                    selectPlayerCombo.Items.Add(string.Format("ID: {0} - {1} {2}", player.PlayerID, player.Forename, player.Surname));
                }
            }
        }

        private void PopulateLineupPositionCombo()
        {
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                selectPositionCombo.Items.Clear();
                foreach (var position in dbContext.Positions)
                {
                    selectPositionCombo.Items.Add(string.Format("ID: {0} - {1}", position.PositionID, position.Position1));
                }
            }
        }

        private void PopulateLineupLstBox()
        {
            lineupPlayersLstBox.Items.Clear();

            string[] selectedMatch = matchSearchResultsLstBox.Text.Split(' ');
            int matchID = Convert.ToInt16(selectedMatch[1]);

            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                foreach (var lineup in dbContext.Lineups)
                {
                    if (lineup.GameID == matchID)
                    {
                        lineupPlayersLstBox.Items.Add(string.Format("{0} {1} {2}: {3}", lineup.Game.GameID, lineup.Player.Forename, lineup.Player.Surname, lineup.Position.Position1));
                    }
                }
            }
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
    }
}

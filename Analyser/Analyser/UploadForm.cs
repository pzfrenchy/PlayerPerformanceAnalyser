using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnalyserLibrary;

namespace Analyser
{
    public partial class UploadForm : Form
    {
        int trainingGameTypeID = 2; //reference training gametype ID in database.
        int trainingOppositionID = 1; //reference training opposition ID in database.
        int trainingPositionID = 9; //reference training position ID in database.

        public UploadForm()
        {
            InitializeComponent();
        }

        private void uploadSearchTxtChanged(object sender, EventArgs e)
        {
            string searchType = uploadSearchCombo.Text;
            string searchString = uploadSearchTxt.Text;
            SearchForGame(searchType, searchString);
        }

        private void uploadSeachIndexChanged(object sender, EventArgs e)
        {
            int selectedGame = Convert.ToInt16(uploadSearchResultsLstBox.SelectedValue.ToString());
            SearchForLineup(selectedGame);
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            string selectedFile = "";

            //Open file dialog screen to allow user to browse for gpx file
            OpenFileDialog op = new OpenFileDialog();
            op.InitialDirectory = "C:\\";
            op.Title = "Select file";
            if (op.ShowDialog() == DialogResult.OK)
            {
                //save file path for use in GPX reader
                selectedFile = op.FileName;
            }

            try
            {
                using (DataClassesDataContext dbContext = new DataClassesDataContext())
                {
                    int playerID = Convert.ToInt16(uploadLineupLstBox.SelectedValue.ToString());
                    int lineupID = 0;

                    //check if training item is being uploaded as position and game ID's not required.
                    if (trainingCBox.Checked == true)
                    {
                        //training, so no previous game would be set, need to make new game object
                        Game game = new Game
                        {
                            //temp date, real training date is pulled from GPX file
                            GameDate = DateTime.Now,
                            OpponentID = trainingOppositionID,
                            PitchID = OptionSettings.Instance.TrainingPitchID,
                            GameTypeID = trainingGameTypeID
                        };
                        dbContext.Games.InsertOnSubmit(game);
                        dbContext.SubmitChanges();

                        //create new lineup object
                        Lineup lineup = new Lineup
                        {
                            PositionID = trainingPositionID,
                            PlayerID = playerID,
                            GameID = game.GameID //gameID direct from new game record
                        };
                        //write object to database
                        dbContext.Lineups.InsertOnSubmit(lineup);
                        dbContext.SubmitChanges();

                        //set lineupID to equal that of newly created lineup object
                        lineupID = lineup.LineupID;
                    }
                    else //new lineup item created with game and position ID's required
                    {
                        //get the gameID from the search results list box valueMember
                        int gameID = Convert.ToInt16(uploadSearchResultsLstBox.SelectedValue.ToString());

                        //get lineupID from match and player ID's
                        lineupID = Convert.ToInt16((dbContext.Lineups.Where(l => l.PlayerID == playerID && l.GameID == gameID).Single().LineupID.ToString()));
                    }

                    GpxFile reader = new GpxFile();

                    //Get list of GPX tracks
                    List<string> gpxTrackList = reader.GPXTracksList(selectedFile);

                    //Iterate trough list and generate new Timelines object from each
                    for (int i = 0; i < gpxTrackList.Count; i++)
                    {
                        string[] elements = gpxTrackList[i].Split(',');

                        TimeLine timeLines = new TimeLine
                        {
                            Longitude = Convert.ToDouble(elements[1]),
                            Latitude = Convert.ToDouble(elements[2]),
                            ReadingTime = Convert.ToDateTime(elements[3]),
                            LineupID = lineupID,
                            GPSDeviceID = 1
                        };
                        //Write to database
                        dbContext.TimeLines.InsertOnSubmit(timeLines);
                        dbContext.SubmitChanges();
                    }
                }
                MessageBox.Show("Upload Complete");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void TrainingCBoxChecked(object sender, EventArgs e)
        {
            if (trainingCBox.Checked == true)
            {
                //clear game search details
                uploadSearchTxt.Text = "";
                uploadSearchResultsLstBox.DataSource = null;

                //If training data list box populated with all registered players
                using (DataClassesDataContext dbContext = new DataClassesDataContext())
                {
                    uploadLineupLstBox.ValueMember = "PlayerID";
                    uploadLineupLstBox.DisplayMember = "Forename";
                    uploadLineupLstBox.DataSource = dbContext.Players;
                }
            }
            else if (trainingCBox.Checked == false)
            {
                //Clear list box when unchecked
                uploadLineupLstBox.DataSource = null;
            }
        }

        /// <summary>
        /// Event handler to enable upload button once a player is selected
        /// </summary>
        private void uploadLineupLstBoxIndexChanged(object sender, EventArgs e)
        {
            if (uploadLineupLstBox.SelectedIndex == -1)
            {
                uploadBtn.Enabled = false;
            }
            else
            {
                uploadBtn.Enabled = true;
            }
        }

        /// <summary>
        /// Allows searching games table by date or opponent
        /// </summary>
        /// <param name="searchType">string, "date" or "opponent"</param>
        /// <param name="searchString">string, the search value</param>
        private void SearchForGame(string searchType, string searchString)
        {
            List<Game> gameList = new List<Game>();
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
            PopulateGameLstBox(gameList);
        }

        private void PopulateGameLstBox(List<Game> games)
        {
            uploadSearchResultsLstBox.ValueMember = "GameID";
            uploadSearchResultsLstBox.DisplayMember = "GameDate";
            uploadSearchResultsLstBox.DataSource = games;
        }

        private void FormatResultsString(object sender, ListControlConvertEventArgs e)
        {
            //set variables from associated list box 
            string opponentName = "";
            string gameDate = ((Game)e.ListItem).GameDate.ToShortDateString();
            int opponentID = Convert.ToInt16(((Game)e.ListItem).OpponentID.ToString());

            //select opponent name from opponents table
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                opponentName = (dbContext.Opponents.Where(o => o.OpponentID == opponentID)).Single().OpponentName;
            }

            //Create new list item string
            e.Value = string.Format("{0} - {1}", gameDate, opponentName);
        }

        /// <summary>
        /// Allows searching of lineup records that match a game ID
        /// </summary>
        /// <param name="selectedGame">The selected game ID</param>
        private void SearchForLineup(int selectedGame)
        {
            List<Lineup> lineupList = new List<Lineup>();

            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                foreach (var lineup in dbContext.Lineups)
                {
                    if (lineup.GameID == selectedGame)
                    {
                        lineupList.Add(lineup);
                    }
                }
            }
            PopulateLineupLstBox(lineupList);
        }

        private void PopulateLineupLstBox(List<Lineup> lineup)
        {
            uploadLineupLstBox.ValueMember = "LineupID";
            uploadLineupLstBox.DisplayMember = "LineupID";
            uploadLineupLstBox.DataSource = lineup;
        }

        private void FormatLineupString(object sender, ListControlConvertEventArgs e)
        { 
            //list box can contain Lineup objects if uploading game data or Player objects if training 
            //Check for object type Lineup
            if (e.ListItem.GetType().Equals(typeof(Lineup)))
            {
                //set variables from associated list box 
                string forename = "";
                string surname = "";
                string position = "";
                int playerID = Convert.ToInt16(((Lineup)e.ListItem).PlayerID.ToString());
                int positionID = Convert.ToInt16(((Lineup)e.ListItem).PositionID.ToString());

                //select players details from players table
                using (DataClassesDataContext dbContext = new DataClassesDataContext())
                {
                    forename = (dbContext.Players.Where(p => p.PlayerID == playerID)).Single().Forename;
                    surname = (dbContext.Players.Where(p => p.PlayerID == playerID)).Single().Surname;
                    position = (dbContext.Positions.Where(p => p.PositionID == positionID)).Single().Position1;
                }

                //create new list item string
                e.Value = string.Format("{0} {1} - {2}", forename, surname, position);
            }
            else //must be player object
            {
                //all data already in player object, assign field data to local variables
                string forename = ((Player)e.ListItem).Forename.ToString();
                string surname = ((Player)e.ListItem).Surname.ToString();

                //create new list item string
                e.Value = string.Format("{0} {1}", forename, surname);
            }
        }
    }
}

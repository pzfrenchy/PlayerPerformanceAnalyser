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
        //variables used to create a training activity
        int trainingGameTypeID = 2; //reference training gametype ID in database.
        int trainingOppositionID = 1; //reference training opposition ID in database.
        int trainingPositionID = 9; //reference training position ID in database.

        int gpsDeviceID = 1; //reference "other" device ID in database.
        int trainingPitchID = 1; //reference the home training pitch in database.

        public UploadForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler to search for game details and update gameSearchLstBox with results
        /// </summary>
        private void uploadSearchTxtChanged(object sender, EventArgs e)
        {
            string searchType = uploadSearchCombo.Text;
            string searchString = uploadSearchTxt.Text;

            //ensure searchstring hasn't been completely deleted
            if (string.IsNullOrEmpty(searchString))
            {
                uploadSearchResultsLstBox.DataSource = null;
                uploadLineupLstBox.DataSource = null;
            }
            //populate list box
            else
            {
                PopulateGameLstBox(searchType, searchString);
            }
        }

        /// <summary>
        /// Method to search for all players associated to a game when selected.
        /// </summary>
        private void uploadSearchIndexChanged(object sender, EventArgs e)
        { 
            string searchString = uploadSearchTxt.Text;
            if (string.IsNullOrEmpty(searchString))
            {
                //if search text is empty do nothing
            }
            else
            {
                int selectedGame = Convert.ToInt16(uploadSearchResultsLstBox.SelectedValue.ToString());
                SearchForLineup(selectedGame);
            }
        }

        /// <summary>
        /// Method to create a new training activity in the game table and return the new lineup ID
        /// </summary>
        /// <param name="dt">Datetime for the activity</param>
        /// <param name="oppID">opponent</param>
        /// <param name="pitchID">pitch</param>
        /// <param name="gameTypeID">activity type</param>
        /// <param name="positionID">player position</param>
        /// <param name="playerID">player ID</param>
        /// <returns>int, lineup ID of the new activity</returns>
        private int GetTrainingLineupID(DateTime dt, int oppID, int pitchID, int gameTypeID, int positionID, int playerID)
        {
            int lineupID = 0;
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                //training, so no previous game would be set, need to make new game object
                Game game = new Game
                {
                    //temp date, real training date is pulled from GPX file
                    GameDate = dt,
                    OpponentID = oppID,
                    PitchID = pitchID,
                    GameTypeID = gameTypeID
                };
                dbContext.Games.InsertOnSubmit(game);
                dbContext.SubmitChanges();

                //create new lineup object
                Lineup lineup = new Lineup
                {
                    PositionID = positionID,
                    PlayerID = playerID,
                    GameID = game.GameID //gameID direct from new game record
                };
                //write object to database
                dbContext.Lineups.InsertOnSubmit(lineup);
                dbContext.SubmitChanges();

                //set lineupID to equal that of newly created lineup object
                lineupID = lineup.LineupID;
            }
            return lineupID;
        }

        /// <summary>
        /// Method to iterate through a list of track elements and upload to timeline table
        /// </summary>
        /// <param name="gpxTrackList">list of CSV strings containing track information</param>
        /// <param name="lineupID">the associated lineup id</param>
        private void AddTrackElementsToTimeLineTable(List<string> gpxTrackList, int lineupID)
        {
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                //Iterate trough list and generate new Timelines object from each
                for (int i = 0; i < gpxTrackList.Count; i++)
                {
                    string[] elements = gpxTrackList[i].Split(',');

                    TimeLine timeLines = new TimeLine
                    {
                        Latitude = Convert.ToDouble(elements[1]),
                        Longitude = Convert.ToDouble(elements[2]),
                        ReadingTime = Convert.ToDateTime(elements[3]),
                        LineupID = lineupID,
                        GPSDeviceID = gpsDeviceID
                    };
                    //Write to database
                    dbContext.TimeLines.InsertOnSubmit(timeLines);
                    dbContext.SubmitChanges();
                }
            }
        }

        /// <summary>
        /// Event handler to enable gpx file upload based on a selected lineupID
        /// </summary>
        private void uploadBtn_Click(object sender, EventArgs e)
        {
            FileHandling file = new FileHandling();
            string selectedFile = file.getFileName();

            try
            {
                using (DataClassesDataContext dbContext = new DataClassesDataContext())
                {
                    int lineupID = 0;

                    //check if training item is being uploaded as position and game ID's not required.
                    if (trainingCBox.Checked == true)
                    {
                        DateTime dt = DateTime.Now;
                        int opponentID = trainingOppositionID;
                        int pitchID = trainingPitchID;
                        int gameTypeID = trainingGameTypeID;
                        int positionID = trainingPositionID;
                        int playerID = Convert.ToInt16(uploadLineupLstBox.SelectedValue.ToString());

                        lineupID = GetTrainingLineupID(dt, opponentID, pitchID, gameTypeID, positionID, playerID);
                    }
                    else //new lineup item created with game and position ID's required
                    {
                        //get the gameID from the search results list box valueMember
                        int gameID = Convert.ToInt16(uploadSearchResultsLstBox.SelectedValue.ToString());

                        //get lineupID from match and player ID's
                        lineupID = Convert.ToInt16(uploadLineupLstBox.SelectedValue.ToString());
                    }

                    GpxFile reader = new GpxFile();

                    //Get list of GPX tracks
                    List<string> gpxTrackList = reader.GPXTracksList(selectedFile);

                    AddTrackElementsToTimeLineTable(gpxTrackList, lineupID);
                }
                MessageBox.Show("Upload Complete");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// Event handler to change state of elements based on checkbox state
        /// </summary>
        private void TrainingCBoxChecked(object sender, EventArgs e)
        {
            if (trainingCBox.Checked == true)
            {
                //clear game search details
                uploadSearchTxt.Text = "";
                uploadSearchTxt.Enabled = false;
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
                uploadSearchTxt.Enabled = true;
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
        /// Method to populate the gamelistbox based on search results from provided search type and search string
        /// </summary>
        /// <param name="searchType">string containing date or opponent</param>
        /// <param name="searchString">string containing search parameters</param>
        private void PopulateGameLstBox(string searchType, string searchString)
        {
            try
            {
                //check that search type is date and the search string is integer 
                if (searchType == "Date" && Int32.TryParse(searchString, out int temp))
                {
                    using (DataClassesDataContext dbContext = new DataClassesDataContext())
                    {
                        uploadSearchResultsLstBox.ValueMember = "GameID";
                        uploadSearchResultsLstBox.DisplayMember = "LineupDetails";
                        uploadSearchResultsLstBox.DataSource = dbContext.GameSearchByDateProc(Convert.ToInt32(searchString));
                    }
                }
                else if (searchType == "Opposition")
                {
                    using (DataClassesDataContext dbContext = new DataClassesDataContext())
                    {
                        uploadSearchResultsLstBox.ValueMember = "GameID";
                        uploadSearchResultsLstBox.DisplayMember = "LineupDetails";
                        uploadSearchResultsLstBox.DataSource = dbContext.GameSearchByOpponentProc(searchString);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// Method to return opponents name based on the provided id
        /// </summary>
        /// <param name="opponentID">the id for searching</param>
        /// <returns>string containing opponents name</returns>
        private string GetOpponentNameByID(int opponentID)
        {
            string opponentName = "";
            //select opponent name from opponents table
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                opponentName = (dbContext.Opponents.Where(o => o.OpponentID == opponentID)).Single().OpponentName;
            }
            return opponentName;
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

        /// <summary>
        /// Event handler to format the lineup string when data changes
        /// </summary>
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

                //select player details from players table
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

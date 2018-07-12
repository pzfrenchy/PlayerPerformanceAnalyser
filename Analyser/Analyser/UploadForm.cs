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
        public UploadForm()
        {
            InitializeComponent();
        }

        private void uploadSearchTxtChanged(object sender, EventArgs e)
        {
            if (uploadSearchCombo.Text == "ID")
            {
                using (DataClassesDataContext dbContext = new DataClassesDataContext())
                {
                    uploadSearchResultsLstBox.Items.Clear();
                    foreach (var game in dbContext.Games)
                    {
                        if (game.GameID.ToString().Contains(uploadSearchTxt.Text) && uploadSearchTxt.Text != "")
                        {
                            uploadSearchResultsLstBox.Items.Add(string.Format("ID: {0} - Date: {1} - Opposition: {2}", game.GameID, game.GameDate.Value.ToShortDateString(), game.Opponent.OpponentName));
                        }
                    }
                }
            }
            else if (uploadSearchCombo.Text == "Date")
            {
                using (DataClassesDataContext dbContext = new DataClassesDataContext())
                {
                    uploadSearchResultsLstBox.Items.Clear();
                    foreach (var game in dbContext.Games)
                    {
                        if (game.GameDate.ToString().Contains(uploadSearchTxt.Text) && uploadSearchTxt.Text != "")
                        {
                            uploadSearchResultsLstBox.Items.Add(string.Format("ID: {0} - Date: {1} - Opposition: {2}", game.GameID, game.GameDate.Value.ToShortDateString(), game.Opponent.OpponentName));
                        }
                    }
                }
            }
            else if (uploadSearchCombo.Text == "Opposition")
            {
                using (DataClassesDataContext dbContext = new DataClassesDataContext())
                {
                    uploadSearchResultsLstBox.Items.Clear();
                    foreach (var game in dbContext.Games)
                    {
                        string oppName = game.Opponent.OpponentName.ToUpper();
                        if (oppName.Contains(uploadSearchTxt.Text.ToUpper()) && uploadSearchTxt.Text != "")
                        {
                            uploadSearchResultsLstBox.Items.Add(string.Format("ID: {0} - Date: {1} - Opposition: {2}", game.GameID, game.GameDate.Value.ToShortDateString(), game.Opponent.OpponentName));
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select your search type");
            }
            if (string.IsNullOrEmpty(uploadSearchTxt.Text))
            {
                uploadLineupLstBox.SelectedIndex = -1;
                uploadLineupLstBox.Items.Clear();
            }
        }

        private void uploadSeachIndexChanged(object sender, EventArgs e)
        {
            uploadLineupLstBox.Items.Clear();

            string[] selectedMatch = uploadSearchResultsLstBox.Text.Split(' ');
            int matchID = Convert.ToInt16(selectedMatch[1]);

            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                foreach (var lineupItem in dbContext.Lineups)
                {
                    if (lineupItem.GameID == matchID)
                    {
                        uploadLineupLstBox.Items.Add(string.Format("ID: {0} {1} {2}", lineupItem.PlayerID, lineupItem.Player.Forename, lineupItem.Player.Surname));
                    }
                }
            }
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            string selectedFile = "";
            OpenFileDialog op = new OpenFileDialog();
            op.InitialDirectory = "C:\\";
            op.Title = "Select file";
            if (op.ShowDialog() == DialogResult.OK)
            {
                selectedFile = op.FileName;
            }

            try
            {
                using (DataClassesDataContext dbContext = new DataClassesDataContext())
                {
                    string[] selectedPlayer = uploadLineupLstBox.Text.Split(' ');
                    int playerID = Convert.ToInt16(selectedPlayer[1]);

                    int lineupID = 0;

                    if (trainingCBox.Checked == true)
                    {
                        Lineup lineup = new Lineup
                        {
                            PositionID = null,
                            PlayerID = playerID,
                            GameID = null,
                            Training = true
                        };
                        dbContext.Lineups.InsertOnSubmit(lineup);
                        dbContext.SubmitChanges();

                        lineupID = lineup.LineupID;
                    }
                    else
                    {
                        string[] selectedMatch = uploadSearchResultsLstBox.Text.Split(' ');
                        int matchID = Convert.ToInt16(selectedMatch[1]);

                        //get lineupID from match and player data
                        foreach (var lineupItem in dbContext.Lineups)
                        {
                            if (lineupItem.PlayerID == playerID && lineupItem.GameID == matchID)
                            {
                                lineupID = lineupItem.LineupID;
                            }
                        }
                    }

                    GpxFile reader = new GpxFile();

                    List<string> list = reader.GPXTracksList(selectedFile);
                    for (int i = 0; i < list.Count; i++)
                    {
                        string[] elements = list[i].Split(',');

                        TimeLine timeLines = new TimeLine
                        {
                            Longitude = Convert.ToDouble(elements[1]),
                            Latitude = Convert.ToDouble(elements[2]),
                            ReadingTime = Convert.ToDateTime(elements[3]),
                            LineupID = lineupID,
                            GPSDeviceID = null
                        };

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
                uploadSearchTxt.Text = "";
                uploadSearchTxt.ReadOnly = true;

                uploadLineupLstBox.Items.Clear();

                using (DataClassesDataContext dbContext = new DataClassesDataContext())
                {
                    foreach (var player in dbContext.Players)
                    {
                        uploadLineupLstBox.Items.Add(string.Format("ID: {0} - {1} {2}", player.PlayerID, player.Forename, player.Surname));
                    }
                }
            }
            else if (trainingCBox.Checked == false)
            {
                uploadLineupLstBox.SelectedIndex = -1;
                uploadLineupLstBox.Items.Clear();
                uploadSearchTxt.ReadOnly = false;
            }
        }

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
    }
}

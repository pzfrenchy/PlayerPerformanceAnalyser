using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using AnalyserLibrary;

namespace Analyser
{
    public partial class PlayerStatsForm : Form
    {
        Bitmap printImage; //used for printing the page

        Series series = new Series("series");
        int XYCount = 0; //variable to hold the total count of XYCoordinates in a series
        int XYCountdown = 0; //variable to track which coord to display as graphics timer runs
        List<XY> xy = new List<XY>();

        public PlayerStatsForm()
        {
            InitializeComponent();
            PopulatePlayerCombo();
            breakdownChart.Series.Add(series);
            breakdownChart.Series["series"].YValueMembers = "Percent";
            PopulateActivityStats();
            timeLbl.Text = "0:00";
        }

        /// <summary>
        /// Method to populate the player combo box
        /// </summary>
        private void PopulatePlayerCombo()
        {
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                playerCombo.ValueMember = "PlayerID";
                playerCombo.DisplayMember = "Fullname";
                playerCombo.DataSource = dbContext.PlayerFullNameProc();
            }
        }

        /// <summary>
        /// Method to populate the date combo box with a list of activities, displays date of activity
        /// </summary>
        /// <param name="gameList">List of activities</param>
        private void PopulateDateCombo(List<Game> gameList)
        {
            dateCombo.ValueMember = "GameID";
            dateCombo.DisplayMember = "GameDate";
            dateCombo.DataSource = gameList;
        }

        /// <summary>
        /// Method find all activities associated to a selected player and display
        /// </summary>
        private void PlayerComboIndexChanged(object sender, EventArgs e)
        {
            //Get ID of selected player
            int playerID = Convert.ToInt16(playerCombo.SelectedValue.ToString());

            //Find all associated activities
            List<Game> gameList = Search.Instance.FindGamesByPlayerID(playerID);

            //Add all activities to combo
            PopulateDateCombo(gameList);

            //If no activities clear all data.
            if (gameList.Count <= 0)
            {
                ClearData();
            }
        }

        /// <summary>
        /// Method to populate all activities statistics on selection of activity
        /// </summary>
        private void DateComboIndexChanged(object sender, EventArgs e)
        {
            PopulateActivityStats();
        }

        /// <summary>
        /// Method to draw points on a picturebox based on a list of coordinates
        /// </summary>
        /// <param name="xy">A list of all coordinates to be displayed</param>
        private void DrawPoints(List<XY> xy, int p)
        {
            //Associate picturebox object to new graphics object
            Graphics graphics;
            graphics = pitchPictureBox.CreateGraphics();

            //Clear any previous plotted coordinates
            graphics.Clear(Color.LimeGreen);

            SolidBrush brush = new SolidBrush(Color.Black);

            //Alternate method to draw whole movement trace in one go, leaving here as may need at a later point
            //iterate through coordinates list and draw points
            //for (int i = 0; i < xy.Count; i++)
            //{
            //    pitchPictureBox.CreateGraphics().DrawRectangle(new Pen(Brushes.Black, 1), new Rectangle(Convert.ToInt32(xy[i].Y), Convert.ToInt32(xy[i].X), 1, 1));
            //}

            //draw point
            pitchPictureBox.CreateGraphics().DrawEllipse(new Pen(Brushes.Black, 2), new Rectangle(Convert.ToInt32(xy[p].Y), Convert.ToInt32(xy[p].X), 5, 5));
        }

        /// <summary>
        /// Method to bind data source to chart
        /// </summary>
        /// <param name="d">List of coordinates</param>
        private void PopulateChartWithDistance(List<double> d)
        {
            //Clear previous chart data
            series.Points.Clear();
            breakdownChart.DataSource = null;
            breakdownChart.DataBind();

            //Check there is data in the list and bind to chart datasource
            if (d.Count > 0)
            {
                breakdownChart.DataSource = d;
                breakdownChart.DataBind();
            }
        }

        /// <summary>
        /// Method to populate form elements with activity statistics
        /// </summary>
        private void PopulateActivityStats()
        {
            int playerID = Convert.ToInt16(playerCombo.SelectedValue.ToString());
            int gameID = Convert.ToInt16(dateCombo.SelectedValue.ToString());

            List<TimeLine> matchedTimeLineRecords = Search.Instance.FindMatchingTimeLines(gameID, playerID);

            if (matchedTimeLineRecords.Count() != 0)
            {
                //calculate total distance and display
                double totalDistance = Calculations.Instance.CalcTotalDistance(matchedTimeLineRecords);
                distanceLbl.Text = string.Format("{0} m", Math.Round(totalDistance, 2));

                //calculate velocity and display
                Speed speed = new Speed(totalDistance, matchedTimeLineRecords[0].ReadingTime, matchedTimeLineRecords[matchedTimeLineRecords.Count - 1].ReadingTime);
                double v = speed.AvgMtrPerSecondRnd();
                paceLbl.Text = string.Format("{0} m/s", v);

                //calculate sprints and display
                double minSpeed = 6.4; //the minimum threshold for classifying movement in m/s
                double maxSpeed = 12.0; //the maximum threshold for classifying movement in m/s
                double sprints = Calculations.Instance.CalcSprints(matchedTimeLineRecords, minSpeed, maxSpeed);
                sprintsLbl.Text = string.Format("{0}", sprints);
            }
            else
            {
                //no data exists, clear text fields
                distanceLbl.Text = "no data";
                paceLbl.Text = "no data";
                sprintsLbl.Text = "no data";
            }

            SeriesData seriesData = new SeriesData();
            double seriesInterval = 5.0; //interval for series, set here, could be dynamically set in future
            PopulateChartWithDistance(seriesData.GenerateSeriesData(matchedTimeLineRecords, seriesInterval));

            //Create list of xy coordinates from timeline events for the graphical display
            xy = Calculations.Instance.CalcXYFromGeolocationCoords(matchedTimeLineRecords, Width, Height);
            List<XY> minMax = Calculations.Instance.CalcMinMaxCoords(xy);

            XYCount = xy.Count();
            XYCountdown = xy.Count();
        }

        /// <summary>
        /// Method to find all activities associated to a player
        /// </summary>
        private void CreatPlayersGameList()
        {
            int playerID = Convert.ToInt16(playerCombo.SelectedValue.ToString());
            List<Game> gameList = Search.Instance.FindGamesByPlayerID(playerID);
            if (gameList.Count <= 0)
            {
                ClearData();
            }
        }

        /// <summary>
        /// Method to clear all chart and statistics data
        /// </summary>
        private void ClearData()
        {
            series.Points.Clear();
            breakdownChart.DataSource = null;
            breakdownChart.DataBind();

            distanceLbl.Text = "no data";
            paceLbl.Text = "no data";
        }

        /// <summary>
        /// Timer tick method, draws graphics point per tick and stops at zero
        /// </summary>
        private void movementTimer_Tick(object sender, EventArgs e)
        {
            if (XYCountdown != 0)
            {
                DrawPoints(xy, XYCount - XYCountdown);
                XYCountdown--;

                //temp code to populate timer display, just counting timer ticks for 
                //some reference but not representitive of activity at present
                timeLbl.Text = string.Format("{0}:00", XYCount - XYCountdown);
            }
            else
            {
                movementTimer.Stop();
                movementTimer.Interval = 100;
                speedLbl.Text = "Normal";
                XYCountdown = xy.Count();
                timeLbl.Text = "0:00";
            }
        }

        /// <summary>
        /// Event handler to start timer on playBtn click
        /// </summary>
        private void playBtn_Click(object sender, EventArgs e)
        {
            movementTimer.Start();
        }

        /// <summary>
        /// Event handler to stop timer on pauseBtn click
        /// </summary>
        private void pauseBtn_Click(object sender, EventArgs e)
        {
            movementTimer.Stop();
        }

        /// <summary>
        /// Event handler to decrease timer interval on fastForwardBtn click
        /// </summary>
        private void fastForwardBtn_Click(object sender, EventArgs e)
        {
            //check timer is enabled
            if (movementTimer.Enabled)
            {
                //check value of interval and adjust accordingly
                if (movementTimer.Interval == 100)
                {
                    movementTimer.Interval = 50;
                    speedLbl.Text = "X2";
                }
                else if (movementTimer.Interval == 50)
                {
                    movementTimer.Interval = 25;
                    speedLbl.Text = "X4";
                }
            }
        }

        /// <summary>
        /// Event handler to increase timer interval on rewindBtn click
        /// </summary>
        private void rewindBtn_Click(object sender, EventArgs e)
        {
            //check timer is enabled
            if (movementTimer.Enabled)
            {
                //check value of interval and adjust accordingly
                if (movementTimer.Interval == 50)
                {
                    movementTimer.Interval = 100;
                    speedLbl.Text = "Normal";
                }
                else if (movementTimer.Interval == 25)
                {
                    movementTimer.Interval = 50;
                    speedLbl.Text = "X2";
                }
            }
        }

        /// <summary>
        /// Method for capturing a form, saving to an image and opening in print preview
        /// </summary>
        private void CaptureScreen()
        {
            Graphics g = CreateGraphics();
            Size s = Size;
            printImage = new Bitmap(s.Width, s.Height, g);
            Graphics printGraphics = Graphics.FromImage(printImage);
            printGraphics.CopyFromScreen(Location.X, Location.Y, 0, 0, s);
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        /// <summary>
        /// Method to print a document based on an image
        /// </summary>
        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(printImage, 0,0);
        }

        /// <summary>
        /// Event handler to run capturescreen on print menu item click
        /// </summary>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CaptureScreen();
        }

        /// <summary>
        /// Event handler to close currect form
        /// </summary>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

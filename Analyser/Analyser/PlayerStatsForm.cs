using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        Series series = new Series("series");

        public PlayerStatsForm()
        {
            InitializeComponent();
            PopulatePlayerCombo();
            breakdownChart.Series.Add(series);
            breakdownChart.Series["series"].YValueMembers = "Percent";
            PopulateData();
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                series.Points.Clear();
                breakdownChart.DataSource = null;
                breakdownChart.DataBind();

                distanceLbl.Text = "no data";
                paceLbl.Text = "no data";
            }
        }

        private void DateComboIndexChanged(object sender, EventArgs e)
        {
            PopulateData();
        }

        /// <summary>
        /// Method to draw points on a picturebox based on a list of coordinates
        /// </summary>
        /// <param name="xy">A list of all coordinates to be displayed</param>
        private void DrawPoints(List<XY> xy)
        {
            //Associate picturebox object to new graphics object
            Graphics graphics;
            graphics = pitchPictureBox.CreateGraphics();

            //Clear any previous plotted coordinates
            graphics.Clear(Color.LimeGreen);

            SolidBrush brush = new SolidBrush(Color.Black);

            //iterate through coordinates list and draw points
            for (int i = 0; i < xy.Count; i++)
            {
                pitchPictureBox.CreateGraphics().DrawRectangle(new Pen(Brushes.Black, 1), new Rectangle(Convert.ToInt32(xy[i].Y), Convert.ToInt32(xy[i].X), 1, 1));
            }
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
        private void PopulateData()
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
            }
            else
            {
                distanceLbl.Text = "no data";
                paceLbl.Text = "no data";
            }

            SeriesData seriesData = new SeriesData();
            double seriesInterval = 5.0; //interval for series, set here, could be dynamically set in future
            PopulateChartWithDistance(seriesData.GenerateSeriesData(matchedTimeLineRecords, seriesInterval));

            List<XY> xy = Calculations.Instance.CalcXYFromGeolocationCoords(matchedTimeLineRecords, Width, Height);
            List<XY> minMax = Calculations.Instance.CalcMinMaxCoords(xy);

            DrawPoints(xy);
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

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void playBtn_Click(object sender, EventArgs e)
        {

        }

        private void DrawXY()
        {

        }
    }
}

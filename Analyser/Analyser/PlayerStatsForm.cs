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
        }

        private void PopulatePlayerCombo()
        {
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                playerCombo.ValueMember = "PlayerID";
                playerCombo.DisplayMember = "Forename";
                playerCombo.DataSource = dbContext.Players;
            }
        }

        private void PopulateDateCombo(List<Game> gameList)
        {
            dateCombo.ValueMember = "GameID";
            dateCombo.DisplayMember = "GameDate";
            dateCombo.DataSource = gameList;
        }

        private void PlayerComboIndexChanged(object sender, EventArgs e)
        {
            int playerID = Convert.ToInt16(playerCombo.SelectedValue.ToString());
            Search search = new Search();
            List<Game> gameList = search.FindGamesByPlayerID(playerID);
            PopulateDateCombo(gameList);
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
            int playerID = Convert.ToInt16(playerCombo.SelectedValue.ToString());
            int gameID = Convert.ToInt16(dateCombo.SelectedValue.ToString());

            Search search = new Search();
            List<TimeLine> matchedTimeLineRecords = search.FindMatchingTimeLines(gameID, playerID);

            if (matchedTimeLineRecords.Count() != 0)
            {
                //calculate total distance and display
                
                double totalDistance = CalcTotals.Instance.CalcTotalDistance(matchedTimeLineRecords);
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
            PopulateChartWithDistance(seriesData.GetDistanceData(matchedTimeLineRecords));
        }

        private void PopulateChartWithDistance(List<double> d)
        {
            series.Points.Clear();
            breakdownChart.DataSource = null;
            breakdownChart.DataBind();

            if (d.Count > 0)
            {
                breakdownChart.DataSource = d;
                breakdownChart.DataBind();
            }
        }
    }
}

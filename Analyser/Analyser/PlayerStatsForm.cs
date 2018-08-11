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
            List<Game> gameList = Search.Instance.FindGamesByPlayerID(playerID);
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
            PopulateChartWithDistance(seriesData.GetDistanceData(matchedTimeLineRecords));

            List<XY> xy = GeographicToCartesianCoords(matchedTimeLineRecords);
            List<XY> minMax = Calculations.Instance.CalcMinMaxCoords(xy);

            DrawPoints(xy);
        }

        private void DrawPoints(List<XY> xy)
        {
            Graphics graphics;
            graphics = pitchPictureBox.CreateGraphics();
            graphics.Clear(Color.LimeGreen);

            SolidBrush brush = new SolidBrush(Color.Black);

            for (int i = 0; i < xy.Count; i++)
            {
                pitchPictureBox.CreateGraphics().DrawRectangle(new Pen(Brushes.Black, 1), new Rectangle(Convert.ToInt32(xy[i].Y), Convert.ToInt32(xy[i].X), 1, 1));
            }
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

        private List<XY> GeographicToCartesianCoords(List<TimeLine> timeLines)
        {
            List<XY> XYCoords = new List<XY>();
            List<XY> NormXYCoords = new List<XY>();

            foreach (var t in timeLines)
            {
                double x = (t.Longitude + 180) * (Width / 360);
                double latRad = t.Latitude * Math.PI / 180;
                double mercN = Math.Log(Math.Tan((Math.PI / 4) + (latRad / 2)));
                double y = (Height / 2) - (Width * mercN / (2 * Math.PI));

                XY xy = new XY(x, y);
                XYCoords.Add(xy);
            }

            List<XY> minMax = Calculations.Instance.CalcMinMaxCoords(XYCoords);
            int padding = 10;

            foreach (var item in XYCoords)
            {
                item.X = ((item.X - minMax[0].X) / (minMax[1].X - minMax[0].X)) * 200 + padding;
                item.Y = ((item.Y - minMax[0].Y) / (minMax[1].Y - minMax[0].Y)) * 200 + padding;
            }
            return XYCoords;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            DrawXY();
        }

        private void DrawXY()
        {

        }
    }
}

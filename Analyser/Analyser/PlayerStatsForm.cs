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
    public partial class PlayerStatsForm : Form
    {
        public PlayerStatsForm()
        {
            InitializeComponent();
            PopulatePlayerCombo();
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
            List<Game> gameList = search.FindAllGamesByPlayerID(playerID);
            PopulateDateCombo(gameList);
        }

        private void DateComboIndexChanged(object sender, EventArgs e)
        {
            //calculate distance overwrite distance label
            int playerID = Convert.ToInt16(playerCombo.SelectedValue.ToString());
            int gameID = Convert.ToInt16(dateCombo.SelectedValue.ToString());

            Search search = new Search();
            List<Coordinates> coords = search.FindCoordsFromLineupItem(gameID, playerID);

            if (coords.Count() != 0)
            {
                //calculate total distance and display
                double totalDistance = CalcTotalDistance(coords);
                distanceLbl.Text = string.Format("{0} m", Math.Round(totalDistance, 2));

                //calculate velocity and display
                Speed speed = new Speed(totalDistance, coords[0].Dt, coords[coords.Count - 1].Dt);
                double v = speed.AvgMtrPerSecondRnd();
                paceLbl.Text = string.Format("{0} m/s", v);
            }
            else
            {
                distanceLbl.Text = "no data";
                paceLbl.Text = "no data";
            }
        }

        private double CalcTotalDistance(List<Coordinates> coords)
        {
            double totalDistance = 0.0;

            //calculate sum of distance covered
            for (int i = 0; i < coords.Count() - 1; i++)
            {
                Distance d = new Distance(coords[i].Lat, coords[i].Lon, coords[i + 1].Lat, coords[i + 1].Lon);
                double distance = d.DistanceInMtr();
                totalDistance = totalDistance + distance;
            }

            return totalDistance;
        }
    }
}

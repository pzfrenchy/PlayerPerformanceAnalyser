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
            List<Game> gameList = new List<Game>();
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                foreach (var lineup in dbContext.Lineups)
                {
                    if (lineup.PlayerID == playerID)
                    {
                        int gameID = lineup.GameID;
                        foreach(var game in dbContext.Games)
                        {
                            if (game.GameID == gameID)
                            {
                                gameList.Add(game);
                            }
                        }
                    }
                }
            }
            PopulateDateCombo(gameList);
        }

        private void DateComboIndexChanged(object sender, EventArgs e)
        {
            //calculate distance overwrite distance label
            int playerID = Convert.ToInt16(playerCombo.SelectedValue.ToString());
            int gameID = Convert.ToInt16(dateCombo.SelectedValue.ToString());
            double totalDistance = 0.0;
            Distance calc = new Distance();

            List<Coordinates> coords = new List<Coordinates>();
            
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                foreach (var lineup in dbContext.Lineups)
                {
                    if (lineup.GameID == gameID && lineup.PlayerID == playerID)
                    {
                        int lineupID = lineup.LineupID;
                        foreach (var timeline in dbContext.TimeLines)
                        {
                            if (timeline.LineupID == lineupID)
                            {
                                DateTime dt = timeline.ReadingTime;
                                double lat = timeline.Latitude;
                                double lon = timeline.Longitude;
                                Coordinates coordinates = new Coordinates(dt, lat, lon);
                                coords.Add(coordinates);
                            }
                        }
                    }
                }
            }
            if (coords.Count() != 0)
            {
                //calculate sum of distance covered and display
                for (int i = 0; i < coords.Count() - 1; i++)
                {
                    double distance = calc.FullDistanceInMtr(coords[i].Lat, coords[i].Lon, coords[i + 1].Lat, coords[i + 1].Lon);
                    totalDistance = totalDistance + distance;
                }
                distanceLbl.Text = string.Format("{0} m", Math.Round(totalDistance, 2));

                //calculate velocity and display
                Speed speed = new Speed();
                double v = speed.AvgMtrPerSecondRnd(totalDistance, coords[0].Dt, coords[coords.Count-1].Dt);
                paceLbl.Text = string.Format("{0} m/s", v);
            }
            else
            {
                distanceLbl.Text = "no data";
                paceLbl.Text = "no data";
            }
        }
    }
}

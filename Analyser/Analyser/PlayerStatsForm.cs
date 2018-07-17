using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void PopulateDateCombo()
        {

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
                        int gameID = lineup.GameID.Value;
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
            dateCombo.ValueMember = "GameID";
            dateCombo.DisplayMember = "GameDate";
            dateCombo.DataSource = "gameList";
        }
    }
}

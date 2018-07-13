using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyserLibrary
{
    public class DataLists
    {
        private static DataLists instance;

        private DataLists() { }

        public static DataLists Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataLists();
                }
                return instance;
            }
        }

        public List<string> PlayerData()
        {
            List<string> playersList = new List<string>();
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                foreach (var player in dbContext.Players)
                {
                    playersList.Add(string.Format("ID: {0} - {1} {2} DOB: {3}", player.PlayerID, player.Forename, player.Surname, player.Dob.ToShortDateString()));
                }
            }
            return playersList;
        }

        public List<string> PitchData()
        {
            List<string> pitchList = new List<string>();
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                foreach (var pitch in dbContext.Pitches)
                {
                    pitchList.Add(pitch.PitchName);
                }
            }
            return pitchList;
        }

        public List<string> OppositionData()
        {
            List<string> oppList = new List<string>();
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                foreach (var opponents in dbContext.Opponents)
                {
                    oppList.Add(string.Format("ID: {0} - {1}", opponents.OpponentID, opponents.OpponentName));
                }
            }
            return oppList;
        }

        public List<string> MatchData()
        {
            List<string> matchList = new List<string>();
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                foreach (var game in dbContext.Games)
                {
                    matchList.Add(string.Format("{0} {1} {2}", game.GameDate.Value.ToShortDateString(), game.Opponent.OpponentName, game.Pitch.PitchName));
                }
            }
            return matchList;
        }

        public List<string> PositionData()
        {
            List<string> positionList = new List<string>();
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                foreach (var position in dbContext.Positions)
                {
                    positionList.Add(string.Format("ID: {0} - {1}", position.PositionID, position.Position1));
                }
            }
            return positionList;
        }

        public List<string> LineupData(string match)
        {
            List<string> lineupList = new List<string>();

            string[] selectedMatch = match.Split(' ');
            int matchID = Convert.ToInt16(selectedMatch[1]);

            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                foreach (var lineup in dbContext.Lineups)
                {
                    if (lineup.GameID == matchID)
                    {
                        lineupList.Add(string.Format("{0} {1} {2}: {3}", lineup.Game.GameID, lineup.Player.Forename, lineup.Player.Surname, lineup.Position.Position1));
                    }
                }
            }
            return lineupList;
        }
    }
}

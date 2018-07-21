using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyserLibrary
{
    public class Search
    {
        private void addGameToGameList(List<Game> gameList, Game game)
        {
            if (game.GetType().Equals(typeof(Game)))
            {
                gameList.Add(game);
            }
            else
            {
                throw new ArgumentException("Incorrect object type", "game");
            }
        }

        private void findGameByDate(string searchString, List<Game> gameList)
        {
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                foreach (var game in dbContext.Games)
                {
                    if (game.GameDate.ToString().Contains(searchString) && searchString != "")
                    {
                        addGameToGameList(gameList, game);
                    }
                }
            }
        }

        private void findGameByOpponent(string searchString, List<Game> gameList)
        {
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                foreach (var game in dbContext.Games)
                {
                    string oppName = getOpponentName(game);
                    if (oppName.Contains(searchString.ToUpper()) && searchString != "")
                    {
                        addGameToGameList(gameList, game);
                    }
                }
            }
        }

        private string getOpponentName(Game game)
        {
            string opponentName = game.Opponent.OpponentName.ToUpper();
            return opponentName;
        }

        /// <summary>
        /// Allows searching games table by date or opponent
        /// </summary>
        /// <param name="searchType">string, "date" or "opponent"</param>
        /// <param name="searchString">string, search value</param>
        public List<Game> SearchForGame(string searchType, string searchString)
        {
            List<Game> gameList = new List<Game>();
            if (searchType == "Date")
            {
                findGameByDate(searchString, gameList);
            }
            else if (searchType == "Opposition")
            {
                findGameByOpponent(searchString, gameList);
            }
            return gameList;
        }

        /// <summary>
        /// Allows searching Lineup table by gameID and playerID and returns a list of all matching coordinates.
        /// </summary>
        /// <param name="gameID">int, ID of game</param>
        /// <param name="playerID">int, ID of player</param>
        /// <returns></returns>
        public List<Coordinates> FindCoordsFromLineupItem(int gameID, int playerID)
        {
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
            return coords;
        }

        public List<Game> FindAllGamesByPlayerID(int playerID)
        {
            List<Game> gameList = new List<Game>();
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                foreach (var lineup in dbContext.Lineups)
                {
                    if (lineup.PlayerID == playerID)
                    {
                        int gameID = lineup.GameID;
                        foreach (var game in dbContext.Games)
                        {
                            if (game.GameID == gameID)
                            {
                                gameList.Add(game);
                            }
                        }
                    }
                }
            }
            return gameList;
        }
    }
}

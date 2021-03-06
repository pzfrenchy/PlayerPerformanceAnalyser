﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyserLibrary
{
    public class Search
    {
        private static Search instance;

        private Search() { }

        public static Search Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Search();
                }
                return instance;
            }
        }
        private void AddGameToGameList(List<Game> gameList, Game game)
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

        private void FindGameByDate(string searchString, List<Game> gameList)
        {
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                foreach (var game in dbContext.Games)
                {
                    if (game.GameDate.ToString().Contains(searchString) && searchString != "")
                    {
                        AddGameToGameList(gameList, game);
                    }
                }
            }
        }

        private void FindGameByOpponent(string searchString, List<Game> gameList)
        {
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                foreach (var game in dbContext.Games)
                {
                    string oppName = GetOpponentName(game);
                    if (oppName.Contains(searchString.ToUpper()) && searchString != "")
                    {
                        AddGameToGameList(gameList, game);
                    }
                }
            }
        }

        private string GetOpponentName(Game game)
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
                FindGameByDate(searchString, gameList);
            }
            else if (searchType == "Opposition")
            {
                FindGameByOpponent(searchString, gameList);
            }
            return gameList;
        }

        /// <summary>
        /// Using GameID and PlayerID returns a list of matching TimeLine object.
        /// </summary>
        /// <param name="gameID">int, ID of game</param>
        /// <param name="playerID">int, ID of player</param>
        /// <returns></returns>
        public List<TimeLine> FindMatchingTimeLines(int gameID, int playerID)
        {
            List<TimeLine> output = new List<TimeLine>();
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
                                output.Add(timeline);
                            }
                        }
                    }
                }
            }
            return output;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="playerID"></param>
        /// <returns></returns>
        public List<Game> FindGamesByPlayerID(int playerID)
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

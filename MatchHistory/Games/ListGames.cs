using System.Collections.Generic;

namespace LeagueMatchHistory.MatchHistory.Games
{
    public class ListGames
    {
        public int gameIndexBegin;
        public int gameIndexEnd;
        public int gameTimestampBegin;
        public int gameTimestampEnd;
        public int gameCount;
        public List<ListGame> games;
    }
}

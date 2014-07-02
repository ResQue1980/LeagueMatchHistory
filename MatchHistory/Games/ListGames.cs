using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

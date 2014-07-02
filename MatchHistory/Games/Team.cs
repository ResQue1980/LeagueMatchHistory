using System.Collections.Generic;

namespace LeagueMatchHistory.MatchHistory.Games
{
    public class Team
    {
        public int teamId;
        public string win;
        public bool firstBlood;
        public bool firstTower;
        public bool firstInhibitor;
        public bool firstBaron;
        public bool firstDragon;
        public int towerKills;
        public int inhibitorKills;
        public int baronKills;
        public int dragonKills;
        public int vilemawKills;
        public List<TeamBans> bans;
    }
}

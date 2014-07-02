using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueMatchHistory.MatchHistory.Games.Timeline.Frames.Events
{
    public class EliteMonsterKillFrame : EventFrame
    {
        public string type;
        public int timestamp;
        public Position position;
        public int killerId;
        public string monsterType;
    }
}

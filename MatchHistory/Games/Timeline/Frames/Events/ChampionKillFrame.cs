using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueMatchHistory.MatchHistory.Games.Timeline.Frames.Events
{
    public class ChampionKillFrame : EventFrame
    {
        public string type;
        public int timestamp;
        public Position position;
        public int killerId;
        public int victimId;
        public List<int> assistingParticipantIds;
    }
}

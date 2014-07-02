using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueMatchHistory.MatchHistory.Games.Timeline.Frames.Events
{
    public class WardFrame : EventFrame
    {
        public string type;
        public int timestamp;
        public string wardType;
        public int creatorId;
    }
}

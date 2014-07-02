using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueMatchHistory.MatchHistory.Games.Timeline.Frames.Events
{
    public class BuildingKillFrame : EventFrame
    {
        public string type;
        public int timestamp;
        public Position position;
        public int killerId;
        public List<int> assistingParticipantIds;
        public int teamId;
        public string buildingType;
        public string laneType;
        public string towerType;
    }
}

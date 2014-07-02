using System.Collections.Generic;

namespace LeagueMatchHistory.MatchHistory.Games.Timeline.Frames.Events
{
    public class BuildingKillFrame : EventFrame
    {
        public Position position;
        public int killerId;
        public List<int> assistingParticipantIds;
        public int teamId;
        public string buildingType;
        public string laneType;
        public string towerType;
    }
}

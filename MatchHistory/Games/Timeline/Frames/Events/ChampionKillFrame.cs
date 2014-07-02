using System.Collections.Generic;

namespace LeagueMatchHistory.MatchHistory.Games.Timeline.Frames.Events
{
    public class ChampionKillFrame : EventFrame
    {
        public Position position;
        public int killerId;
        public int victimId;
        public List<int> assistingParticipantIds;
    }
}

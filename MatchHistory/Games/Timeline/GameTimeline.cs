
namespace LeagueMatchHistory.MatchHistory.Games.Timeline
{
    public class GameTimeline
    {
        public int participantId;
        public TimelineDelta creepsPerMinDeltas;
        public TimelineDelta xpPerMinDeltas;
        public TimelineDelta goldPerMinDeltas;
        public TimelineDelta csDiffPerMinDeltas;
        public TimelineDelta xpDiffPerMinDeltas;
        public TimelineDelta damageTakenPerMinDeltas;
        public TimelineDelta damageTakenDiffPerMinDeltas;
        public string role;
        public string lane;
    }
}

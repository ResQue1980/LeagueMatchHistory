using System.Collections.Generic;

namespace LeagueMatchHistory.MatchHistory.Games.Timeline.Frames
{
    public class Frame
    {
        public ParticipantFrames participantFrames;
        public List<EventFrame> events;
        public int timestamp;
    }
}

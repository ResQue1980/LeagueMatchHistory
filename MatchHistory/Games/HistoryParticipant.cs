using LeagueMatchHistory.MatchHistory.Games.Timeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueMatchHistory.MatchHistory.Games
{
    public class HistoryParticipant
    {
        public int participantId;
        public int teamId;
        public int championId;
        public int skinId;
        public int spell1Id;
        public int spell2Id;
        public ParticipantStats stats;
        public GameTimeline timeline;
    }
}

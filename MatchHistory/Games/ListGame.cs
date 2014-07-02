using LeagueMatchHistory.MatchHistory.Games.Timeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueMatchHistory.MatchHistory.Games
{
    public class ListGame
    {
        public long gameId;
        public string platformId;
        public long gameCreation;
        public int gameDuration;
        public int queueId;
        public int mapId;
        public int seasonId;
        public string gameVersion;
        public List<HistoryParticipant> participants;
        public List<ParticipantIdentity> participantIdentities;
    }
}

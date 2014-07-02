
namespace LeagueMatchHistory.MatchHistory.Games
{
    public class ParticipantIdentity
    {
        public int participantId;
        public Identity player;
    }

    public class Identity
    {
        public string platformId;
        public int accountId;
        public string summonerName;
        public string currentPlatformId;
        public int currentAccountId;
        public string matchHistoryUri;
        public int profileIcon;
    }
}

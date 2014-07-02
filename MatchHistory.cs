using LeagueMatchHistory.MatchHistory;
using LeagueMatchHistory.MatchHistory.Games;
using LeagueMatchHistory.MatchHistory.Games.Timeline;
using LeagueMatchHistory.MatchHistory.Games.Timeline.Frames;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace LeagueMatchHistory
{
    public class PlayerMatchHistory
    {
        public Task<HistoryAccount> GetPlayerAsync(string originalRegion, string summonerName)
        {
            return GetUrlTask<HistoryAccount>(string.Format("players/?name={0}&region={1}", 
                                            summonerName, 
                                            originalRegion));
        }

        public HistoryAccount GetPlayer(string originalRegion, string summonerName)
        {
            return GetUrl<HistoryAccount>(string.Format("players/?name={0}&region={1}",
                                            summonerName,
                                            originalRegion));
        }

        public Task<PlayerListGames> GetGamesAsync(HistoryAccount summoner, int begIndex = 0, int endIndex = 10, int champion = -1, int queueId = -1)
        {
            string OptionalParameters = "";
            if (champion != -1)
                OptionalParameters += string.Format("&champion={0}", champion);

            if (queueId != -1)
                OptionalParameters += string.Format("&queue={0}", queueId);

            return GetUrlTask<PlayerListGames>(string.Format("stats/player_history/{0}/{1}?begIndex={2}&endIndex={3}{4}",
                                                            summoner.platformId,
                                                            summoner.accountId,
                                                            begIndex,
                                                            endIndex,
                                                            OptionalParameters));
        }

        public PlayerListGames GetGames(HistoryAccount summoner, int begIndex = 0, int endIndex = 10, int champion = -1, int queueId = -1)
        {
            string OptionalParameters = "";
            if (champion != -1)
                OptionalParameters += string.Format("&champion={0}", champion);

            if (queueId != -1)
                OptionalParameters += string.Format("&queue={0}", queueId);

            return GetUrl<PlayerListGames>(string.Format("stats/player_history/{0}/{1}?begIndex={2}&endIndex={3}{4}",
                                                            summoner.platformId,
                                                            summoner.accountId,
                                                            begIndex,
                                                            endIndex,
                                                            OptionalParameters));
        }

        public Task<Game> GetFullGameDataAsync(ListGame game)
        {
            return GetUrlTask<Game>(string.Format("stats/game/{0}/{1}",
                                                game.platformId,
                                                game.gameId));
        }

        public Game GetFullGameData(ListGame game)
        {
            return GetUrl<Game>(string.Format("stats/game/{0}/{1}",
                                                game.platformId,
                                                game.gameId));
        }

        public Task<IndepthTimeline> GetGameTimelineAsync(ListGame game)
        {
            return GetUrlTask<IndepthTimeline>(string.Format("stats/game/{0}/{1}/timeline",
                                                game.platformId,
                                                game.gameId));
        }

        public IndepthTimeline GetGameTimeline(ListGame game)
        {
            return GetUrl<IndepthTimeline>(string.Format("stats/game/{0}/{1}/timeline",
                                                game.platformId,
                                                game.gameId));
        }

        private async Task<T> GetUrlTask<T>(params string[] endpoint)
        {
            string URL = "https://acs.leagueoflegends.com/v1";
            foreach (string s in endpoint)
            {
                URL = string.Join("/", new string[] {URL, s});
            }
            string Json;
            using (WebClient client = new WebClient())
            {
                Json = await client.DownloadStringTaskAsync(new Uri(URL));
            }

            if (string.IsNullOrEmpty(Json))
                throw new WebException();

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            serializer.RegisterConverters(new[] { new CustomObjectConverter() });
            return serializer.Deserialize<T>(Json);
        }

        private T GetUrl<T>(params string[] endpoint)
        {
            string URL = "https://acs.leagueoflegends.com/v1";
            foreach (string s in endpoint)
            {
                URL = string.Join("/", new string[] { URL, s });
            }
            string Json;
            using (WebClient client = new WebClient())
            {
                Json = client.DownloadString(URL);
            }

            if (string.IsNullOrEmpty(Json))
                throw new WebException();

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            serializer.RegisterConverters(new[] { new CustomObjectConverter() });
            return serializer.Deserialize<T>(Json);
        }
    }
}

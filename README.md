LeagueMatchHistory
==================

C# library to interface with the new online match history for League of Legends.

Both asynchronous and synchronous functions are provided. Full detail for each match & full history for each player. New match history must be enabled on the region to use this library.

## Example usage

#### Get all data for the first game of a user & the indepth timeline

```csharp
PlayerMatchHistory history = new PlayerMatchHistory();
HistoryAccount acc = await history.GetPlayerAsync("NA1", "Snowl");
PlayerListGames games = await history.GetGamesAsync(acc);
Game game = await history.GetFullGameDataAsync(games.games.games[0]); //lol riot
IndepthTimeline timeline = await history.GetGameTimelineAsync(games.games.games[0]);
```
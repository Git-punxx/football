namespace Infrastructure;

using FootballWorld;

using ID = UInt64;
public class SRProvider: IStatsProvider
{
    public LeagueStats FetchLeagueStats(ID leagueId) {
        return new LeagueStats();
    }

    public TeamStats FetchTeamStats(ID teamId) {
        return new TeamStats();
    }

    public List<GameResult> FetchPreviousResults(ID teamId) {
        return new List<GameResult>();
    }

    public List<Fixture> FetchPendingFixtures() {
        return new List<Fixture>();
    }
}

namespace Infrastructure;

using FootballWorld;

using ID = UInt64;
public class SRProvider: IStatsProvider
{
    public LeagueStats FetchLeagueStats(ID leagueId) {
        return new LeagueStats();
    }

    public TeamStats FecthTeamStats(ID teamId) {
        return new TeamStats();
    }

    public List<Fixture> FetchPendingFixtures() {
        return new List<Fixture>();
    }
}

namespace Services;

using Infrastructure;
using FootballWorld;

using ID = UInt64;
public class StatsService
{
    private IStatsProvider provider;

    public StatsService() {
        provider = new SRProvider();
    }
    public LeagueStats FetchLeagueStats(ID teamId) {
        return provider.FetchLeagueStats(teamId);
    }
}

namespace FootballWorld;

using ID = UInt64;

/// Domain layer super types
public abstract class DomainObject {
    abstract public ID GetId();
}

public interface IStatsProvider {
    public LeagueStats FetchLeagueStats(ID leagueId);
     
}
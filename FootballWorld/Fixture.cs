namespace FootballWorld;


public enum ProgressState {
    Pending,
    InProgress,
    Finished,
}
public class Fixture {

    public League Competition { get; }
    public Team Home { get; }
    public Team Away { get; }
    public DateTime StartsAt { get; }
    public Odds StartingOdds { get; } 

    public Fixture(string competition, string home, string away, DateTime startsAt, uint homeWin, uint draw, uint awayWin) {
        Competition = new League(competition);
        Home = new Team(home);
        Away = new Team(away);
        StartsAt = startsAt;
        StartingOdds = new Odds(homeWin, draw, awayWin);
    }

}

public struct GameResult {

}
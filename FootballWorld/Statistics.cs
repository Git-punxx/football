namespace FootballWorld;

public struct Odds {
    public uint HomeWin { get; set; }
    public uint Draw { get; set; }
    public uint AwayWin { get; set; }

    public Odds(uint home, uint draw, uint away) {
        HomeWin = home;
        Draw = draw;
        AwayWin = away;
    }
}
public struct Snapshot {

}


/// The team statistics from previous matches. We take them from Sportradar using The team Id
public struct TeamStats {

}

/// The total league stats. We take them from sportradar using the league id
public struct LeagueStats {

}

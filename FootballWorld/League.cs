namespace FootballWorld;

using ID = UInt64;
public class League {
    public ID SRId { get; } 
    public string Name { get; }

    public League(string name) {
        Name = name;
        SRId = 0;
    }

    public League(ID id, string name) {
        Name = name;
        SRId = id;
    }
}
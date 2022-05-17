namespace FootballWorld;
using ID = UInt64;
public class Team
{
    public string? Name { get; }

    public ID SRId { get; }

    public Team() {
        Name = "Default Team";
        SRId = 0;
    }

    public Team (string name){
        Name = name;
        SRId = 0;
    }

    public Team (string name, ID srId) {
        Name = name;
        SRId = srId;
    }

}

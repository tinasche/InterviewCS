namespace InterviewCS.Classes;

partial class Alien
{
    public Alien(string species, string originPlanet, string reason)
    {   
        this.Species = species;
        this.OriginPlanet = originPlanet;
        this.VisitationReason = reason;
        alienCount += 1;
    }

    public override string ToString()
    {
        return $"I am a {this.Species} from {this.OriginPlanet} and I've come to {this.VisitationReason}.\n";
    }

    public static int GetAlienCount() => alienCount;
}
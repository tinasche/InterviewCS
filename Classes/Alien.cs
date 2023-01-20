namespace InterviewCS.Classes
{
    [Author("Tinashe Chitakunye", "testing partial class theory")]
    partial class Alien
    {
        public int Id { get; set; }
        public string Species { get; set; } = String.Empty;
        public string OriginPlanet { get; set; } = String.Empty;
        public DateTime ArrivedOn { get; set; } = DateTime.UtcNow;
        public string VisitationReason { get; set; }

        static int alienCount = 0;
    }
}
namespace TripDatabase.Models
{
    public class Trip
    {
        public long Id { get; set; }
        public string Destination { get; set; } = null!;
        public string Description { get; set; } = null!;
        public double Lat { get; set; }
        public double Lon { get; set; }
        public ICollection<Member>? Members { get; set; }

    }
}

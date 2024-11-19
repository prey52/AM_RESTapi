namespace AM_server_rest.Models
{
    public class Tour
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Waypoint> Waypoints { get; set; } = new List<Waypoint>();
    }
}

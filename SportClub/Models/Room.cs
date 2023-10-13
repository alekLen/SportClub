namespace SportClub.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Timetable> timetables { get; set; }
    }
}

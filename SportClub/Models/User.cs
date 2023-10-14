namespace SportClub.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }=string.Empty;
        public string DateOfBirth { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public Sex Sex { get; set; } = default!;
        public Post? Post { get; set; } = null;
        public Speciality? Speciality { get; set; } = null;
        public List<Timetable>? timetables { get; set; } = null;
        public string? DateOfStart { get; set; } = null;
        public string Login {  get; set; }= string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
    }
}

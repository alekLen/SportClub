namespace SportClub.Models
{
    public class Coach
    {
        public int Id { get; set; }
        public string Name { get; set; }=string.Empty;
        public string DateOfBirth { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public Sex Sex { get; set; }
        public Post Post { get; set;}
        public Speciality Speciality { get; set; }
        public List<Timetable> timetables { get; set; }
        public string Login {  get; set; }= string.Empty;
        public string Password { get; set; } = string.Empty;  
    }
}

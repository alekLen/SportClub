namespace SportClub.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }= string.Empty;
        public int Number {  get; set; }
        public Coach Coach { get; set; }
    }
}

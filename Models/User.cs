namespace UsersDashboard.Models
{
    public class User
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int BirthYear { get; set; }
        public string Login { get; set; }
        public bool IsAdmin { get; set; }
    }
}
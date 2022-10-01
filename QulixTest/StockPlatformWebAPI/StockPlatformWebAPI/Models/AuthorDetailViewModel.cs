namespace StockPlatformWebAPI.Models
{
    public class AuthorDetailViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Nickname { get; set; } = null!;
        public DateTime? DateOfBirth { get; set; }
        public DateTime? DateOfRegistration { get; set; }
    }
}

namespace BLL.DTO
{
    public class AuthorDetailDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? DateOfRegistration { get; set; }
    }
}

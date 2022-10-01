namespace DAL.DbModels
{
    public partial class Author
    {
        public Author()
        {
            Photos = new HashSet<Photo>();
            Texts = new HashSet<Text>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Nickname { get; set; } = null!;
        public DateTime? DateOfBirth { get; set; }
        public DateTime? DateOfRegistration { get; set; }

        public virtual ICollection<Photo> Photos { get; set; }
        public virtual ICollection<Text> Texts { get; set; }
    }
}

namespace DAL.DbModels
{
    public partial class Text
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Text1 { get; set; }
        public DateTime? DateOfCreation { get; set; }
        public string Cost { get; set; } = null!;
        public int AuthorId { get; set; }
        public int? NumberOfSales { get; set; }
        public int? Raiting { get; set; }

        public virtual Author Author { get; set; } = null!;
    }
}

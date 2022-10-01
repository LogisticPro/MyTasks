namespace BLL.DTO
{
    public class PhotoDetailDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public byte[]? Picture { get; set; }
        public string? Link { get; set; }
        public int OriginalLength { get; set; }
        public int OriginalWidth { get; set; }
        public DateTime? DateOfCreation { get; set; }
        public int AuthorId { get; set; }
        public string Cost { get; set; } = null!;
        public int? NumberOfSales { get; set; }
        public int? Raiting { get; set; }
    }
}

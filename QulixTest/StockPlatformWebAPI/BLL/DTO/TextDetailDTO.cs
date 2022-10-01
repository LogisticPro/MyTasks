using System;
namespace BLL.DTO
{
    public class TextDetailDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Text1 { get; set; }
        public DateTime? DateOfCreation { get; set; }
        public string Cost { get; set; }
        public int AuthorId { get; set; }
        public int? NumberOfSales { get; set; }
        public int? Raiting { get; set; }
    }
}

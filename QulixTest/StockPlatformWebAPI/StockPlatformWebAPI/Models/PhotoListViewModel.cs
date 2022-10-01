namespace StockPlatformWebAPI.Models
{
    public class PhotoListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public byte[]? Picture { get; set; }
    }
}

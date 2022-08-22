namespace Heroes3WebApp.Models
{
    public class HeroModel
    {
        public int Id { get; set; }
        public int TownId { get; set; }
        public string? TownName { get; set; }
        public string? Name { get; set; }
        public string? Class { get; set; }
        public int Type { get; set; }
        public byte[]? Picture { get; set; }
        public byte[]? TownPicture { get; set; }
    }
}

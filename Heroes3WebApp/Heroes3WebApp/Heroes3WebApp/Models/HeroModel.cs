namespace Heroes3WebApp.Models
{
    public class HeroModel
    {
        public int Id { get; set; }
        public string? TownName { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public byte[]? Picture { get; set; }
    }
}

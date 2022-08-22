namespace Heroes3WebApp.Models
{
    public class TownDetailModel
    {
        public int Id { get; set; }
        public int LandscapeId { get; set; }
        public string? Name { get; set; }
        public string? LandscapeName { get; set; }
        public string? HeroClass_1 { get; set; }
        public string? HeroClass_2 { get; set; }
        public string? Discription { get; set; }
        public byte[]? DetailPicture { get; set; }
    }
}

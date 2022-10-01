namespace BLL.DTO
{
    public class PhotoListDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public byte[]? Picture { get; set; }
    }
}

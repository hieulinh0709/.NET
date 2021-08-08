namespace WebAPI.Core.Models
{
    public class Picture
    {
        public int PictureId { get; set; }
        public string PhotoFileName { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}

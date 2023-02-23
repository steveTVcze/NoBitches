namespace AnimeWeb.Models;

public class WaifuModel
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Image
    {
        public string Signature { get; set; }
        public string Extension { get; set; }
        public int ImageId { get; set; }
        public int Favourites { get; set; }
        public string DominantColor { get; set; }
        public string Source { get; set; }
        public DateTime UploadedAt { get; set; }
        public object LikedAt { get; set; }
        public bool IsNsfw { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Url { get; set; }
        public string PreviewUrl { get; set; }
        public List<Tag> Tags { get; set; }
    }

    public class Root
    {
        public List<Image> Images { get; set; }
    }

    public class Tag
    {
        public int TagId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsNsfw { get; set; }
    }


}
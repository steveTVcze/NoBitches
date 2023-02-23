namespace AnimeWeb.Models
{
    public class AnimeReviewsModel
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Datum
        {
            public int MalId { get; set; }
            public string Url { get; set; }
            public string Type { get; set; }
            public Reactions Reactions { get; set; }
            public DateTime Date { get; set; }
            public string Review { get; set; }
            public int Score { get; set; }
            public List<string> Tags { get; set; }
            public bool IsSpoiler { get; set; }
            public bool IsPreliminary { get; set; }
            public object EpisodesWatched { get; set; }
            public User User { get; set; }
        }

        public class Images
        {
            public Jpg Jpg { get; set; }
            public Webp Webp { get; set; }
        }

        public class Jpg
        {
            public string ImageUrl { get; set; }
        }

        public class Pagination
        {
            public int LastVisiblePage { get; set; }
            public bool HasNextPage { get; set; }
        }

        public class Reactions
        {
            public int Overall { get; set; }
            public int Nice { get; set; }
            public int LoveIt { get; set; }
            public int Funny { get; set; }
            public int Confusing { get; set; }
            public int Informative { get; set; }
            public int WellWritten { get; set; }
            public int Creative { get; set; }
        }

        public class Root
        {
            public Pagination Pagination { get; set; }
            public List<Datum> Data { get; set; }
        }

        public class User
        {
            public string Url { get; set; }
            public string Username { get; set; }
            public Images Images { get; set; }
        }

        public class Webp
        {
            public string ImageUrl { get; set; }
        }


    }
}

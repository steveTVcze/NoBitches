namespace AnimeWeb.Models
{
    public class AnimeNewsModel
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Datum
        {
            public int MalId { get; set; }
            public string Url { get; set; }
            public string Title { get; set; }
            public DateTime Date { get; set; }
            public string AuthorUsername { get; set; }
            public string AuthorUrl { get; set; }
            public string ForumUrl { get; set; }
            public Imageses Images { get; set; }
            public int Comments { get; set; }
            public string Excerpt { get; set; }
        }

        public class Imageses
        {
            public Jpgs Jpg { get; set; }
        }

        public class Jpgs
        {
            public string ImageUrl { get; set; }
        }

        public class Paginations
        {
            public int LastVisiblePage { get; set; }
            public bool HasNextPage { get; set; }
        }

        public class Root
        {
            public Paginations Pagination { get; set; }
            public List<Datum> Data { get; set; }
        }


    }
}

namespace AnimeWeb.Models
{
    public class UserModel
    {

        public class Rootobject
        {
            public Pagination pagination { get; set; }
            public Datum[] data { get; set; }
        }

        public class Pagination
        {
            public int last_visible_page { get; set; }
            public bool has_next_page { get; set; }
        }

        public class Datum
        {
            public string username { get; set; }
            public string url { get; set; }
            public Images images { get; set; }
            public DateTime last_online { get; set; }
        }

        public class Images
        {
            public Jpg jpg { get; set; }
            public Webp webp { get; set; }
        }

        public class Jpg
        {
            public string image_url { get; set; }
        }

        public class Webp
        {
            public string image_url { get; set; }
        }

    }
}

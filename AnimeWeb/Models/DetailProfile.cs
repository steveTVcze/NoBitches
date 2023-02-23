namespace AnimeWeb.Models
{
    public class DetailProfile
    {

        public class Rootobject
        {
            public Data data { get; set; }
        }

        public class Data
        {
            public int mal_id { get; set; }
            public string username { get; set; }
            public string url { get; set; }
            public Images images { get; set; }
            public DateTime last_online { get; set; }
            public string gender { get; set; }
            public object birthday { get; set; }
            public object location { get; set; }
            public DateTime joined { get; set; }
            public Statistics statistics { get; set; }
            public Favorites favorites { get; set; }
            public Updates updates { get; set; }
            public object about { get; set; }
            public External[] external { get; set; }
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

        public class Statistics
        {
            public Anime anime { get; set; }
            public Manga manga { get; set; }
        }

        public class Anime
        {
            public float days_watched { get; set; }
            public float mean_score { get; set; }
            public int watching { get; set; }
            public int completed { get; set; }
            public int on_hold { get; set; }
            public int dropped { get; set; }
            public int plan_to_watch { get; set; }
            public int total_entries { get; set; }
            public int rewatched { get; set; }
            public int episodes_watched { get; set; }
        }

        public class Manga
        {
            public int days_read { get; set; }
            public float mean_score { get; set; }
            public int reading { get; set; }
            public int completed { get; set; }
            public int on_hold { get; set; }
            public int dropped { get; set; }
            public int plan_to_read { get; set; }
            public int total_entries { get; set; }
            public int reread { get; set; }
            public int chapters_read { get; set; }
            public int volumes_read { get; set; }
        }

        public class Favorites
        {
            public Anime1[] anime { get; set; }
            public Manga1[] manga { get; set; }
            public Character[] characters { get; set; }
            public object[] people { get; set; }
        }

        public class Anime1
        {
            public int mal_id { get; set; }
            public string url { get; set; }
            public Images1 images { get; set; }
            public string title { get; set; }
            public string type { get; set; }
            public int start_year { get; set; }
        }

        public class Images1
        {
            public Jpg1 jpg { get; set; }
            public Webp1 webp { get; set; }
        }

        public class Jpg1
        {
            public string image_url { get; set; }
            public string small_image_url { get; set; }
            public string large_image_url { get; set; }
        }

        public class Webp1
        {
            public string image_url { get; set; }
            public string small_image_url { get; set; }
            public string large_image_url { get; set; }
        }

        public class Manga1
        {
            public int mal_id { get; set; }
            public string url { get; set; }
            public Images2 images { get; set; }
            public string title { get; set; }
            public string type { get; set; }
            public int start_year { get; set; }
        }

        public class Images2
        {
            public Jpg2 jpg { get; set; }
            public Webp2 webp { get; set; }
        }

        public class Jpg2
        {
            public string image_url { get; set; }
            public string small_image_url { get; set; }
            public string large_image_url { get; set; }
        }

        public class Webp2
        {
            public string image_url { get; set; }
            public string small_image_url { get; set; }
            public string large_image_url { get; set; }
        }

        public class Character
        {
            public int mal_id { get; set; }
            public string url { get; set; }
            public Images3 images { get; set; }
            public string name { get; set; }
        }

        public class Images3
        {
            public Jpg3 jpg { get; set; }
            public Webp3 webp { get; set; }
        }

        public class Jpg3
        {
            public string image_url { get; set; }
        }

        public class Webp3
        {
            public string image_url { get; set; }
            public string small_image_url { get; set; }
        }

        public class Updates
        {
            public Anime2[] anime { get; set; }
            public Manga2[] manga { get; set; }
        }

        public class Anime2
        {
            public Entry entry { get; set; }
            public int score { get; set; }
            public string status { get; set; }
            public int? episodes_seen { get; set; }
            public int? episodes_total { get; set; }
            public DateTime date { get; set; }
        }

        public class Entry
        {
            public int mal_id { get; set; }
            public string url { get; set; }
            public Images4 images { get; set; }
            public string title { get; set; }
        }

        public class Images4
        {
            public Jpg4 jpg { get; set; }
            public Webp4 webp { get; set; }
        }

        public class Jpg4
        {
            public string image_url { get; set; }
            public string small_image_url { get; set; }
            public string large_image_url { get; set; }
        }

        public class Webp4
        {
            public string image_url { get; set; }
            public string small_image_url { get; set; }
            public string large_image_url { get; set; }
        }

        public class Manga2
        {
            public Entry1 entry { get; set; }
            public int score { get; set; }
            public string status { get; set; }
            public object chapters_read { get; set; }
            public object chapters_total { get; set; }
            public DateTime date { get; set; }
        }

        public class Entry1
        {
            public int mal_id { get; set; }
            public string url { get; set; }
            public Images5 images { get; set; }
            public string title { get; set; }
        }

        public class Images5
        {
            public Jpg5 jpg { get; set; }
            public Webp5 webp { get; set; }
        }

        public class Jpg5
        {
            public string image_url { get; set; }
            public string small_image_url { get; set; }
            public string large_image_url { get; set; }
        }

        public class Webp5
        {
            public string image_url { get; set; }
            public string small_image_url { get; set; }
            public string large_image_url { get; set; }
        }

        public class External
        {
            public string name { get; set; }
            public string url { get; set; }
        }

    }
}

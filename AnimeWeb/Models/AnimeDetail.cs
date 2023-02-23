namespace AnimeWeb.Models
{
    public class AnimeDetail
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Aired
        {
            public DateTime From { get; set; }
            public object To { get; set; }
            public Prop Prop { get; set; }
            public string String { get; set; }
        }

        public class Broadcast
        {
            public object Day { get; set; }
            public object Time { get; set; }
            public object Timezone { get; set; }
            public object String { get; set; }
        }

        public class Data
        {
            public int MalId { get; set; }
            public string Url { get; set; }
            public Images Images { get; set; }
            public Trailer Trailer { get; set; }
            public bool Approved { get; set; }
            public List<TitleName> Titles { get; set; }
            public string Title { get; set; }
            public string TitleEnglish { get; set; }
            public string TitleJapanese { get; set; }
            public List<string> TitleSynonyms { get; set; }
            public string Type { get; set; }
            public string Source { get; set; }
            public int Episodes { get; set; }
            public string Status { get; set; }
            public bool Airing { get; set; }
            public Aired Aired { get; set; }
            public string Duration { get; set; }
            public string Rating { get; set; }
            public double Score { get; set; }
            public int ScoredBy { get; set; }
            public int Rank { get; set; }
            public int Popularity { get; set; }
            public int Members { get; set; }
            public int Favorites { get; set; }
            public string Synopsis { get; set; }
            public string Background { get; set; }
            public object Season { get; set; }
            public object Year { get; set; }
            public Broadcast Broadcast { get; set; }
            public List<Producer> Producers { get; set; }
            public List<Licensor> Licensors { get; set; }
            public List<Studio> Studios { get; set; }
            public List<Genre> Genres { get; set; }
            public List<object> ExplicitGenres { get; set; }
            public List<Theme> Themes { get; set; }
            public List<object> Demographics { get; set; }
            public List<RelationS> Relations { get; set; }
            public Theme Theme { get; set; }
            public List<object> External { get; set; }
            public List<object> Streaming { get; set; }
        }

        public class Entry
        {
            public int MalId { get; set; }
            public string Type { get; set; }
            public string Name { get; set; }
            public string Url { get; set; }
        }

        public class From
        {
            public int Day { get; set; }
            public int Month { get; set; }
            public int Year { get; set; }
        }

        public class Genre
        {
            public int MalId { get; set; }
            public string Type { get; set; }
            public string Name { get; set; }
            public string Url { get; set; }
        }

        public class Images
        {
            public Jpg Jpg { get; set; }
            public Webp Webp { get; set; }
            public string ImageUrl { get; set; }
            public string SmallImageUrl { get; set; }
            public string MediumImageUrl { get; set; }
            public string LargeImageUrl { get; set; }
            public string MaximumImageUrl { get; set; }
        }

        public class Jpg
        {
            public string ImageUrl { get; set; }
            public string SmallImageUrl { get; set; }
            public string LargeImageUrl { get; set; }
        }

        public class Licensor
        {
            public int MalId { get; set; }
            public string Type { get; set; }
            public string Name { get; set; }
            public string Url { get; set; }
        }

        public class Producer
        {
            public int MalId { get; set; }
            public string Type { get; set; }
            public string Name { get; set; }
            public string Url { get; set; }
        }

        public class Prop
        {
            public From From { get; set; }
            public To To { get; set; }
        }

        public class RelationS
        {
            public string Relation { get; set; }
            public List<Entry> Entry { get; set; }
        }

        public class Root
        {
            public Data Data { get; set; }
        }

        public class Studio
        {
            public int MalId { get; set; }
            public string Type { get; set; }
            public string Name { get; set; }
            public string Url { get; set; }
        }

        public class Theme
        {
            public int MalId { get; set; }
            public string Type { get; set; }
            public string Name { get; set; }
            public string Url { get; set; }
        }

        public class Theme2
        {
            public List<string> Openings { get; set; }
            public List<string> Endings { get; set; }
        }

        public class TitleName
        {
            public string Type { get; set; }
            public string Title { get; set; }
        }

        public class To
        {
            public object Day { get; set; }
            public object Month { get; set; }
            public object Year { get; set; }
        }

        public class Trailer
        {
            public string YoutubeId { get; set; }
            public string Url { get; set; }
            public string EmbedUrl { get; set; }
            public Images Images { get; set; }
        }

        public class Webp
        {
            public string ImageUrl { get; set; }
            public string SmallImageUrl { get; set; }
            public string LargeImageUrl { get; set; }
        }


    }
}

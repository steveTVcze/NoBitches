namespace AnimeWeb.Models
{
    public class AnimeCharactersModel
    {

        public class Rootobject
        {
            public Datum[] data { get; set; }
        }

        public class Datum
        {
            public Character character { get; set; }
            public string role { get; set; }
            public int favorites { get; set; }
            public Voice_Actors[] voice_actors { get; set; }
        }

        public class Character
        {
            public int mal_id { get; set; }
            public string url { get; set; }
            public Images images { get; set; }
            public string name { get; set; }
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
            public string small_image_url { get; set; }
        }

        public class Voice_Actors
        {
            public Person person { get; set; }
            public string language { get; set; }
        }

        public class Person
        {
            public int mal_id { get; set; }
            public string url { get; set; }
            public Images1 images { get; set; }
            public string name { get; set; }
        }

        public class Images1
        {
            public Jpg1 jpg { get; set; }
        }

        public class Jpg1
        {
            public string image_url { get; set; }
        }


    }
}

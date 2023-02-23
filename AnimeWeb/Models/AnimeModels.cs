using Microsoft.TeamFoundation.Build.WebApi;
using static AnimeWeb.Models.AnimeModels;
using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AnimeWeb.Models
{
    public class AnimeModels
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Aired
        {
            public DateTime From { get; set; }
            public DateTime? To { get; set; }
            public Prop Prop { get; set; }
            public string String { get; set; }
        }

        public class Broadcast
        {
            public string Day { get; set; }
            public string Time { get; set; }
            public string Timezone { get; set; }
            public string String { get; set; }
        }

        public class Datum
        {
            public int MalId { get; set; }
            public string Url { get; set; }
            public Images Images { get; set; }
            public Trailer Trailer { get; set; }
            public bool Approved { get; set; }
            public List<Titles> Titles { get; set; }
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
            public string Season { get; set; }
            public int? Year { get; set; }
            public Broadcast Broadcast { get; set; }
            public List<Producer> Producers { get; set; }
            public List<Licensor> Licensors { get; set; }
            public List<Studio> Studios { get; set; }
            public List<Genre> Genres { get; set; }
            public List<object> ExplicitGenres { get; set; }
            public List<Theme> Themes { get; set; }
            public List<Demographic> Demographics { get; set; }
        }

        public class Demographic
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

        public class Items
        {
            public int Count { get; set; }
            public int Total { get; set; }
            public int PerPage { get; set; }
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

        public class Link
        {
            public string Url { get; set; }
            public string Label { get; set; }
            public bool Active { get; set; }
            public string First { get; set; }
            public string Last { get; set; }
            public object Prev { get; set; }
            public string Next { get; set; }
        }

        public class Meta
        {
            public int CurrentPage { get; set; }
            public int From { get; set; }
            public int LastPage { get; set; }
            public List<Link> Links { get; set; }
            public string Path { get; set; }
            public int PerPage { get; set; }
            public int To { get; set; }
            public int Total { get; set; }
        }

        public class Pagination
        {
            public int LastVisiblePage { get; set; }
            public bool HasNextPage { get; set; }
            public int CurrentPage { get; set; }
            public Items Items { get; set; }
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

        public class Root
        {
            public Pagination Pagination { get; set; }
            public List<Datum> Data { get; set; }
            public string Links { get; set; }
            public Meta Meta { get; set; }
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

        public class Titles
        {
            public string Type { get; set; }
            public string Title { get; set; }
        }

        public class To
        {
            public int? Day { get; set; }
            public int? Month { get; set; }
            public int? Year { get; set; }
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
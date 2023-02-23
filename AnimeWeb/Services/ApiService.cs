using AnimeWeb.Models;
using System.Diagnostics;

namespace AnimeWeb.Services
{
    public class ApiService
    {
        private readonly HttpClient _client;
        private readonly ILogger<ApiService> _logger;

        public ApiService(ILogger<ApiService> logger)
        {
            _client = new HttpClient();
            _logger = logger;
        }

        private const string API_V4 = "https://api.jikan.moe/v4/";
        private const string API_Femboys = "https://api.catboys.com/";
        private const string API_WAIFU = "https://api.waifu.im/";

        public async Task<Rootobject?> TopAnime()
        {
            var data = await Download<Rootobject>($"{API_V4}top/anime");
            return data;
        }
        public async Task<FemboyRootobject> GetFemboyed()
        {
            var data = await Download<FemboyRootobject>($"{API_Femboys}img");
            return data;
        }
        public async Task<UpcomingAnimeModel.Rootobject> GetUpcomingAnime()
        {
            var data = await Download<UpcomingAnimeModel.Rootobject>($"{API_V4}seasons/upcoming");
            return data;
        }
        public async Task<SearchAnimeModel.Rootobject> GetAnimeSearch(string name, bool sfw)
        {
            string safeforwork = "";
            if (sfw == true)
            {
                safeforwork = "sfw";
            }
            else
            {
                safeforwork = "nsfw";
            }
            var data = await Download<SearchAnimeModel.Rootobject>($"{API_V4}anime?q={name}&{safeforwork}");
            return data;
        }
        public async Task<WaifuModel.Root> GetWaifuRandom()
        {
            var data = await Download<WaifuModel.Root>($"{API_WAIFU}search/");
            return data;        }
        public async Task<FemboySoundRootobject> GetSoundFromFemboy()
        {
            var data = await Download<FemboySoundRootobject>($"{API_Femboys}catboy");
            return data;
        }

        public async Task<AnimeCharactersModel.Rootobject> GetCharactersForAnime(int id)
        {
            var data = await Download<AnimeCharactersModel.Rootobject>($"{API_V4}anime/{id}/characters");
            return data;
        }
        public async Task<AnimeReviewsModel.Root> GetReviewsForAnime(int id)
        {
            var data = await Download<AnimeReviewsModel.Root>($"{API_V4}anime/{id}/reviews");
            return data;
        }
        public async Task<AnimeNewsModel.Root> GetNewsForAnime(int id)
        {
            var data = await Download<AnimeNewsModel.Root>($"{API_V4}anime/{id}/news");
            return data;
        }
        public async Task<UserModel.Rootobject> GetUsers(string username)
        {
            var data = await Download<UserModel.Rootobject>($"{API_V4}users?q={username}");
            return data;
        }
        public async Task<DetailProfile.Rootobject> GetUserDetail(string username)
        {
            var data = await Download<DetailProfile.Rootobject>($"{API_V4}users/{username}/full");
            return data;
        }
        public async Task<AnimeDetail.Root> GetAnimeDetail(int id)
        {
            var data = await Download<AnimeDetail.Root>($"{API_V4}anime/{id}/full");
            return data;
        }
        private async Task<T?> Download<T>(string url)
        {
            try
            {
                //string data = await _client.GetStringAsync(url);
                return await _client.GetFromJsonAsync<T>(url);
            }
            catch (Exception ex)
            {
                _logger.LogError($"{url} - {ex.Message}}}");
            }

            return default(T?);
        }
    }
}

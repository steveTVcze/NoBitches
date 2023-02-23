using AnimeWeb.Models;
using AnimeWeb.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Dynamic;

namespace AnimeWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApiService _api;
        private readonly FIleService _file;
        private List<string> _list = new();
        public HomeController(ILogger<HomeController> logger, ApiService api, FIleService file)
        {
            _logger = logger;
            _api = api;
            this._file = file;
        }

        public IActionResult Index()
        {
            var data = _api.TopAnime().GetAwaiter().GetResult();
            Console.WriteLine(data);
            return View("index", data);
        }

        public IActionResult Upcoming()
        {
            var data = _api.GetUpcomingAnime().GetAwaiter().GetResult();
            return View("UpcomingAnime", data);  
        }
        public IActionResult GetRandomWaifu()
        {
            var data = _api.GetWaifuRandom().GetAwaiter().GetResult();
            Console.WriteLine("test" + data);
            return View("RandomWaifu",data);
        }
        public IActionResult Femboys()
        {
            var data = _api.GetFemboyed().GetAwaiter().GetResult();
            var fef = _api.GetSoundFromFemboy().GetAwaiter().GetResult();
            //dynamic models = new ExpandoObject();
            //models.Nevim = data;
            var TupleModel = new Tuple<FemboySoundRootobject, FemboyRootobject>(fef, data);
            //models.Femboy = fef;
            _list.Add(data.url);
            _file.WriteToFile(data.url);
            return View("Femboys", TupleModel);
        }
        public IActionResult Last()
        {
            Task<string> url = _file.ReadLast();
            if (url.Result != null)
            {
                var data = url.Result.ToString();
                var sound = _api.GetSoundFromFemboy().GetAwaiter().GetResult();
                var TupleModel = new Tuple<string, FemboySoundRootobject>(data, sound);
                return View("LastFemboyo", TupleModel);
            }
            return View("Index");
        }
        public IActionResult Search(string name, bool sfw)
        {
            var data = _api.GetAnimeSearch(name, sfw).GetAwaiter().GetResult();
            return View("SearchAnime", data);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult SearchUser(string username)
        {
            var data = _api.GetUsers(username).GetAwaiter().GetResult();
            return View("SearchUser", data);
        }
        public IActionResult UserDetail(string username)
        {
            var data = _api.GetUserDetail(username).GetAwaiter().GetResult();
            return View("UserDetail", data);
        }
        public IActionResult AnimeDetail(int id)
        {
            var data = _api.GetAnimeDetail(id).GetAwaiter().GetResult();
            var characters = _api.GetCharactersForAnime(id).GetAwaiter().GetResult();
            var reviews = _api.GetReviewsForAnime(id).GetAwaiter().GetResult();
            var news = _api.GetNewsForAnime(id).GetAwaiter().GetResult();
            var TupleModel = new Tuple<AnimeDetail.Root, AnimeCharactersModel.Rootobject, AnimeReviewsModel.Root, AnimeNewsModel.Root>(data, characters, reviews, news);
            return View("AnimeDetail", TupleModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
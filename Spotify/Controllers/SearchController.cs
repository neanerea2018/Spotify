using System.Web.Mvc;
using Spotify.Models.ViewModels;

namespace Spotify.Controllers
{
    public class SearchController : Controller
    {
        //client id
        //a6603f0e913d4511bdfe8aa0c167d293

        //client secret
        //aaf58db86409493487c372a89a7b5abc
        public ActionResult Index()
        {



            var model = new SearchViewModel();

            return View(model);
        }
    }
}
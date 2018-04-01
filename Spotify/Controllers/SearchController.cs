using System.Web.Mvc;
using Spotify.Models.ViewModels;

namespace Spotify.Controllers
{
    public class SearchController : Controller
    {
        public ActionResult Index()
        {
            var model = new SearchViewModel();

            return View(model);
        }
    }
}
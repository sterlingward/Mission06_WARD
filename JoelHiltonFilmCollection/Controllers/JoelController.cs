using Microsoft.AspNetCore.Mvc;

namespace JoelHiltonFilmCollection.Controllers
{
    public class JoelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
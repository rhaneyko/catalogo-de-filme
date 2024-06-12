using Microsoft.AspNetCore.Mvc;

namespace catalogo_de_filme.Controllers
{
    public class SeriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

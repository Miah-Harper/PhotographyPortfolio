using Microsoft.AspNetCore.Mvc;

namespace PhotographyPortfolio.Controllers
{
    public class BWController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

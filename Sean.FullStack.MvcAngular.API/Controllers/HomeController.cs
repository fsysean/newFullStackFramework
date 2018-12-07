using Microsoft.AspNetCore.Mvc;

namespace Sean.FullStack.MvcAngular.API.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Spa()
        {
            return File("~/index.html", "text/html");
        }
    }
}

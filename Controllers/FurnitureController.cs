using Microsoft.AspNetCore.Mvc;

namespace webdemo.Controllers
{
    [Route("fur")]
    public class FurnitureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

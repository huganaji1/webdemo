using Microsoft.AspNetCore.Mvc;

namespace webdemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("/homeadmin")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

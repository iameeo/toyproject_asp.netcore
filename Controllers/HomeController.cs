using Microsoft.AspNetCore.Mvc;

namespace ToyProject.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(ILogger<HomeController> logger) : base(logger)
        {

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using ToyProject.DBContext;
using ToyProject.Models;

namespace ToyProject.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(ILogger<HomeController> logger, IameeoContext iameeoDB) : base(logger, iameeoDB)
        {

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
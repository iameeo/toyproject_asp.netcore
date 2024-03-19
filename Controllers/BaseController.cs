using Microsoft.AspNetCore.Mvc;
using ToyProject.DBContext;

namespace ToyProject.Controllers
{
    public class BaseController : Controller
    {
        protected readonly ILogger _logger;
        protected readonly IameeoContext _iameeoDB;

        public BaseController(ILogger logger, IameeoContext iameeoDB)
        {
            _logger = logger;
            _iameeoDB = iameeoDB;
        }
    }
}

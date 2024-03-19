using Microsoft.AspNetCore.Mvc;
using ToyProject.DBContext;
using ToyProject.Models;

namespace ToyProject.Controllers
{
    public class NoticeController : BaseController
    {
        public NoticeController(ILogger<NoticeController> logger, IameeoContext iameeoDB) : base(logger, iameeoDB) 
        {
            _iameeoDB.Notices.Add(new Notice
            {
                UserId = "jaeho.lee",
                Name = "이주원",
                Regdate = DateTime.Now
            });
            _iameeoDB.SaveChanges();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

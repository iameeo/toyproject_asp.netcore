using Microsoft.AspNetCore.Mvc;
using ToyProject.Data;
using ToyProject.Models;

namespace ToyProject.Controllers
{
    public class NoticeController : BaseController
    {
        public NoticeController(ILogger<NoticeController> logger, IameeoContext iameeoDB) : base(logger, iameeoDB) 
        {
            _iameeoDB.Notice.Add(new Notice
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

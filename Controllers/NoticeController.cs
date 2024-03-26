using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToyProject.Data;
using ToyProject.Models;

namespace ToyProject.Controllers
{
    public class NoticeController : BaseController
    {
        public NoticeController(ILogger<NoticeController> logger, IameeoContext iameeoDB) : base(logger, iameeoDB) 
        {

        }

        public async Task<IActionResult> Index()
        {
            var list_query = from n in _iameeoDB.Notice
                             orderby n.Id ascending
                             select n;

            var list = await list_query.ToListAsync();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Notice notice)
        {
            if (ModelState.IsValid)
            {
                notice.Regdate = DateTime.Now;
                _iameeoDB.Notice.Add(notice);
                await _iameeoDB.SaveChangesAsync();

                return RedirectToAction("index");
            }
            return View(notice);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coreOnlineApparelStoreAdminPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreOnlineApparelStoreAdminPortal.Controllers
{
    public class FeedbackController : Controller
    {
        DbContextClass context;
        public FeedbackController(DbContextClass _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            var ind = context.FeedBacks.ToList();
            return View(ind);
        }
        public ActionResult Details(int id)
        {
            FeedBack b = context.FeedBacks.Where(x => x.FeedBackId == id).SingleOrDefault();
            return View(b);
        }
    }
}
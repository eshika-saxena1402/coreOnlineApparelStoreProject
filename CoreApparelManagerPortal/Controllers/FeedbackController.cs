using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApparelManagerPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreApparelManagerPortal.Controllers
{
    public class FeedbackController : Controller
    {
        OnlineApparelStoreDbContext context;
        public FeedbackController(OnlineApparelStoreDbContext _context)
        {
            context = _context;
        }
        public ViewResult Index()
        {
            var cat = context.FeedBacks.ToList();
            return View(cat);
        }     
        public ActionResult Details(int id)
        {
            FeedBacks c = context.FeedBacks.Where(x => x.FeedBackId == id).SingleOrDefault();
            return View(c);
        }
    }
}
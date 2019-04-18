using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coreOnlineApparelStoreAdminPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreOnlineApparelStoreAdminPortal.Controllers
{
    public class PaymentController : Controller
    {
        DbContextClass context;
        public PaymentController(DbContextClass _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            var ind = context.Payments.ToList();
            return View(ind);
        }
        public ActionResult Details(int id)
        {
            Payment b = context.Payments.Where(x => x.PaymentId == id).SingleOrDefault();
            return View(b);
        }
    }
}
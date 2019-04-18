using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coreOnlineApparelStoreAdminPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreOnlineApparelStoreAdminPortal.Controllers
{
    public class OrderProductController : Controller
    {
        DbContextClass context;
        public OrderProductController(DbContextClass _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            var ind = context.orderProducts.ToList();
            return View(ind);
        }
        public ActionResult Details(int id)
        {
            OrderProduct b = context.orderProducts.Where(x => x.OrderId == id).SingleOrDefault();
            return View(b);
        }
    }
}
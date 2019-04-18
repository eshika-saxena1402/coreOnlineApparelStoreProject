using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coreOnlineApparelStoreAdminPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreOnlineApparelStoreAdminPortal.Controllers
{
    public class OrderController : Controller
    {
        DbContextClass context;
        public OrderController(DbContextClass _context)
        {
            context = _context;
        }
        public ViewResult Index()
        {
            var cat = context.Orders.ToList();
            return View(cat);
        }
        public ActionResult Delete(int id)
        {
            Order cat = context.Orders.Find(id);
            return View(cat);
        }
        [HttpPost]
        public ActionResult Delete(int id, Order c1)
        {
            Order c = context.Orders.Where(x => x.OrderId == id).SingleOrDefault();
            context.Orders.Remove(c);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Order cat = context.Orders.Where(x => x.OrderId == id).SingleOrDefault();
            return View(cat);
        }
        [HttpPost]
        public ActionResult Edit(int id, Order c1)
        {
            Order c = context.Orders.Where(x => x.OrderId == c1.OrderId).SingleOrDefault();
            context.Entry(c).CurrentValues.SetValues(c1);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult Details(int id)
        {
            Order c = context.Orders.Where(x => x.OrderId == id).SingleOrDefault();
            return View(c);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coreOnlineApparelStoreAdminPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreOnlineApparelStoreAdminPortal.Controllers
{
    public class ManagerController : Controller
    {
        DbContextClass context;
        public ManagerController(DbContextClass _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            var ind = context.Managers.ToList();
            return View(ind);
        }
        [HttpGet]
        public ViewResult Create()//view not created
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Manager B)
        {
            if (ModelState.IsValid)
            {
                context.Managers.Add(B);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(B);

        }
        public ActionResult Delete(int id)
        {
            Manager ban = context.Managers.Find(id);
            return View(ban);
        }
        [HttpPost]
        public ActionResult Delete(int id, Manager b1)
        {
            Manager b = context.Managers.Where(x => x.ManagerId == id).SingleOrDefault();
            context.Managers.Remove(b);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Manager ban = context.Managers.Where(x => x.ManagerId == id).SingleOrDefault();
            return View(ban);
        }
        [HttpPost]
        public ActionResult Edit(int id, Manager b1)
        {
            Manager b = context.Managers.Where(x => x.ManagerId == b1.ManagerId).SingleOrDefault();
            context.Entry(b).CurrentValues.SetValues(b1);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult Details(int id)
        {
            Manager b = context.Managers.Where(x => x.ManagerId == id).SingleOrDefault();
            return View(b);
        }
    }
}

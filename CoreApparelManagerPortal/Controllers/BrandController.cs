using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApparelManagerPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreApparelManagerPortal.Controllers
{
    public class BrandController : Controller
    {
        OnlineApparelStoreDbContext context;
        public BrandController(OnlineApparelStoreDbContext _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            var ind = context.Brands.ToList();
            return View(ind);
        }
        [HttpGet]
        public ViewResult Create()//view not created
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create([Bind("BrandName")]Brands B)
        {
            if (ModelState.IsValid)
            {
                context.Brands.Add(B);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(B);

        }
        public ActionResult Delete(int id)
        {
            Brands ban = context.Brands.Find(id);
            return View(ban);
        }
        [HttpPost]
        public ActionResult Delete(int id, Brands b1)
        {
            Brands b = context.Brands.Where(x => x.BrandId == id).SingleOrDefault();
            context.Brands.Remove(b);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Brands ban = context.Brands.Where(x => x.BrandId == id).SingleOrDefault();
            return View(ban);
        }
        [HttpPost]
        public ActionResult Edit(int id, Brands b1)
        {
            Brands b = context.Brands.Where(x => x.BrandId == b1.BrandId).SingleOrDefault();
            context.Entry(b).CurrentValues.SetValues(b1);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult Details(int id)
        {
            Brands b = context.Brands.Where(x => x.BrandId == id).SingleOrDefault();
            return View(b);
        }
    }
}
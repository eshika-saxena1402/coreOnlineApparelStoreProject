using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApparelManagerPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreApparelManagerPortal.Controllers
{
    public class CategoryController : Controller
    {
        OnlineApparelStoreDbContext context;
        public CategoryController(OnlineApparelStoreDbContext _context)
        {
            context = _context;
        }
        public ViewResult Index()
        {
            var cat = context.Categories.ToList();
            return View(cat);
        }
        [HttpGet]
        public ViewResult Create()//view not created
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create([Bind("CategoryName")]Categories C)
        {
            if (ModelState.IsValid)
            {
                context.Categories.Add(C);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(C);
        }
        public ActionResult Delete(int id)
        {
            Categories cat = context.Categories.Find(id);
            return View(cat);
        }
        [HttpPost]
        public ActionResult Delete(int id, Categories c1)
        {
            Categories c = context.Categories.Where(x => x.CategoryId == id).SingleOrDefault();
            context.Categories.Remove(c);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Categories cat = context.Categories.Where(x => x.CategoryId == id).SingleOrDefault();
            return View(cat);
        }
        [HttpPost]
        public ActionResult Edit(int id, Categories c1)
        {
            Categories c = context.Categories.Where(x => x.CategoryId == c1.CategoryId).SingleOrDefault();
            context.Entry(c).CurrentValues.SetValues(c1);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult Details(int id)
        {
            Categories c = context.Categories.Where(x => x.CategoryId == id).SingleOrDefault();
            return View(c);
        }
    }
}
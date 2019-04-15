using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApparelManagerPortal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreApparelManagerPortal.Controllers
{
    public class ProductController : Controller
    {
        OnlineApparelStoreDbContext context;
        public ProductController(OnlineApparelStoreDbContext _context)
        {
            context = _context;
        }
        public ViewResult Index()
        {
            var pro = context.Products.ToList();
            return View(pro);
        }
        [HttpGet]
        public ViewResult Create()
        {
            ViewBag.category = new SelectList(context.Categories, "CategoryId", "CategoryName");
            ViewBag.vendor = new SelectList(context.Vendors, "VendorId", "VendorName");
            ViewBag.brand = new SelectList(context.Brands, "BrandId", "BrandName");
            return View();
        }
        [HttpPost]
        public ActionResult Create([Bind("ProductName", "ProductPrice", "ProductQuantity", "ProductSize")]Products c)
        {
            if (ModelState.IsValid)
            {
                context.Products.Add(c);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(c);

        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Products pro = context.Products.Find(id);
            return View(pro);
        }
        [HttpPost]
        public ActionResult Delete(int id, Products P1)
        {
            Products p = context.Products.Where(x => x.ProductId == id).SingleOrDefault();
            context.Products.Remove(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Products p = context.Products.Where(x => x.ProductId == id).SingleOrDefault();
            ViewBag.category = new SelectList(context.Categories, "CategoryId", "CategoryName", p.CategoryId);
            ViewBag.vendor = new SelectList(context.Vendors, "VendorId", "VendorName", p.VendorId);
            ViewBag.brand = new SelectList(context.Brands, "BrandId", "BrandName", p.BrandId);
            return View(p);
        }
        [HttpPost]
        public ActionResult Edit(int id, Products p1)
        {
            Products p = context.Products.Where(x => x.ProductId == p1.ProductId).SingleOrDefault();
            context.Entry(p).CurrentValues.SetValues(p1);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult Details(int id)
        {
            Products p = context.Products.Where(x => x.ProductId == id).SingleOrDefault();
            return View(p);
        }
    }
}
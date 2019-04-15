using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApparelManagerPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreApparelManagerPortal.Controllers
{
    public class VendorController : Controller
    {
        OnlineApparelStoreDbContext context;
        public VendorController(OnlineApparelStoreDbContext _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            var ven = context.Vendors.ToList();
            return View(ven);
        }
        [HttpGet]
        public ViewResult Create()//view not created
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create([Bind("VendorName", "VendorEmail", "VendorPhoneNo")]Vendors V)
        {
            if (ModelState.IsValid)
            {
                context.Vendors.Add(V);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(V);

        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Vendors ven = context.Vendors.Find(id);
            return View(ven);
        }
        [HttpPost]
        public ActionResult Delete(int id, Vendors ven)
        {
            var v = context.Vendors.Where(x => x.VendorId == id).SingleOrDefault();
            context.Vendors.Remove(v);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Vendors vendor = context.Vendors.Where(x => x.VendorId == id).SingleOrDefault();
            return View(vendor);
        }
        [HttpPost]
        public ActionResult Edit(int id, Vendors v1)
        {
            Vendors v = context.Vendors.Where(x => x.VendorId == v1.VendorId).SingleOrDefault();
            context.Entry(v).CurrentValues.SetValues(v1);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult Details(int id)
        {
            Vendors v = context.Vendors.Where(x => x.VendorId == id).SingleOrDefault();
            return View(v);
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coreOnlineApparelStoreAdminPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreOnlineApparelStoreAdminPortal.Controllers
{
    public class CustomerController : Controller
    {
        DbContextClass context;
        public CustomerController(DbContextClass _context)
        {
            context = _context;
        }
        public ViewResult Index()
        {
            var cat = context.Customers.ToList();
            return View(cat);
        }

        public ActionResult Delete(int id)
        {
            Customer cat = context.Customers.Find(id);
            return View(cat);
        }
        [HttpPost]
        public ActionResult Delete(int id, Customer c1)
        {
            Customer c = context.Customers.Where(x => x.CustomerId == id).SingleOrDefault();
            context.Customers.Remove(c);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Customer cat = context.Customers.Where(x => x.CustomerId == id).SingleOrDefault();
            return View(cat);
        }
        [HttpPost]
        public ActionResult Edit(int id, Customer c1)
        {
            Customer c = context.Customers.Where(x => x.CustomerId == c1.CustomerId).SingleOrDefault();
            context.Entry(c).CurrentValues.SetValues(c1);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult Details(int id)
        {
            Customer c = context.Customers.Where(x => x.CustomerId == id).SingleOrDefault();
            return View(c);
        }
    }
}
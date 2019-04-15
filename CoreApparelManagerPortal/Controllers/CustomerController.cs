using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApparelManagerPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreApparelManagerPortal.Controllers
{
    public class CustomerController : Controller
    {
        OnlineApparelStoreDbContext context;
        public CustomerController(OnlineApparelStoreDbContext _context)
        {
            context = _context;
        }
        public ViewResult Index()
        {
            var cat = context.Customers.ToList();
            return View(cat);
        }
        public ActionResult Details(int id)
        {
            Customers c = context.Customers.Where(x => x.CustomerId == id).SingleOrDefault();
            return View(c);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApparelStoreUserPortal.Models;
using ApparelStoreUserPortal.Helper;
using Microsoft.AspNetCore.Http;

namespace ApparelStoreUserPortal.Controllers
{
    public class HomeController : Controller
    {
        OnlineApparelStoreDbContext context = new OnlineApparelStoreDbContext();
        public IActionResult Index()
        {
            var products = context.Products.ToList();
            int j = 0;
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            int i = 0;
            if (cart != null)
            {
                foreach (var item in cart)
                {
                    i++;
                }
                if(i !=0)
                {
                    foreach(var item in cart)
                    {
                        j++;
                    }
                    HttpContext.Session.SetString("Cartitem", i.ToString());
                }
              
            }         
            return View(products);
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult logout()
        {
            HttpContext.Session.Remove("logout");
            HttpContext.Session.Remove("Cartitem");
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", null);
            return RedirectToAction("index");
           
        }
    }
}
                    
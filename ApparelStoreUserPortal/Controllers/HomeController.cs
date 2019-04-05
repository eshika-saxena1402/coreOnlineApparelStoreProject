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
            HttpContext.Session.SetString("homecart", "Login");
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
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cus", null);
            HttpContext.Session.SetString("log", "LogOut");
            return RedirectToAction("index");
           
        }
        public IActionResult userProfile(string id)
        {
            Customers customers = context.Customers.Where(x => x.Email == id).SingleOrDefault();
            int a = customers.CustomerId;
            ViewBag.id = a;
            return View(customers);
        }
        public IActionResult EditProfile()
        {
            Customers cust = SessionHelper.GetObjectFromJson<Customers>(HttpContext.Session, "cus");
            return View(cust);
        }
        [HttpPost]
        public IActionResult EditProfile(string id,Customers customers)
        {
            Customers customer = context.Customers.Where(x => x.Email == customers.Email).SingleOrDefault();
            customer.CustomerFirstName = customers.CustomerFirstName;
            customer.CustomerLastName = customers.CustomerLastName;
            customer.UserName = customers.UserName;
            customer.Gender = customers.Gender;
            customer.Email = customers.Email;
            customer.PhoneNumber = customers.PhoneNumber;
            customer.Country = customers.Country;
            customer.State = customers.State;
            customer.ZipCode = customers.ZipCode;
            customer.Address = customers.Address;
            customer.Address2 = customers.Address2;          
            customer.AlternatePhoneNumber = customers.AlternatePhoneNumber;
            customer.Country2 = customers.Country2;
            customer.State2 = customers.State2;
            customer.ZipCode2 = customers.ZipCode2;
            context.SaveChanges();
            return RedirectToAction("userProfile","home",new { @id=customers.Email});
        }
        public IActionResult CustomerHistory()
        {
            Customers c = SessionHelper.GetObjectFromJson<Customers>(HttpContext.Session,"cus");
            List<Orders> orders = context.Orders.Where(x=>x.CustomerId==c.CustomerId).ToList();
            ViewBag.ord = orders;       
            return View();
        }
        public IActionResult orderDetails(int id)
        {
            List<OrderProducts> orderProducts = new List<OrderProducts>();
            List<Products> products = new List<Products>();
            orderProducts = context.OrderProducts.Where(x => x.OrderId == id).ToList();
            foreach(var item in orderProducts)
            {
                Products p = context.Products.Where(x => x.ProductId == item.ProductId).SingleOrDefault();
                products.Add(p);
            }
            ViewBag.pro = products;
            return View();
        }
        [HttpGet]
        public IActionResult EditPassword()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EditPassword(string oldpassword, string newpassword, string newpassword1)
        {

            Customers c = SessionHelper.GetObjectFromJson<Customers>(HttpContext.Session, "cus");
            if (oldpassword == c.Password && newpassword == newpassword1)
            {
                Customers cus = context.Customers.Where(x => x.Email == c.Email).SingleOrDefault();
                cus.Password = newpassword;
                context.SaveChanges();

            }

            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult Feedback()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Feedback(FeedBacks feedBacks)
        {
            Customers c = SessionHelper.GetObjectFromJson<Customers>(HttpContext.Session, "cus");
            feedBacks.CustomerId = c.CustomerId;
            feedBacks.Message = feedBacks.Message;
            context.FeedBacks.Add(feedBacks);
            context.SaveChanges();
            return RedirectToAction("UserProfile", "Cart", new { @id = c.Email });
        }

    }
}

                    
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApparelManagerPortal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreApparelManagerPortal.Controllers
{
    [Route("Account")]
    public class AccountController : Controller
    {
        OnlineApparelStoreDbContext context;
        public AccountController(OnlineApparelStoreDbContext _context)
        {
            context = _context;
        }
        [Route("")]
        [Route("index")]
        [Route("~/")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [Route("login")]
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            Managers ad = context.Managers.Where(x => x.ManagerEmail == username).SingleOrDefault();
            if (username != null && password != null && ad != null && password.Equals(ad.ManagerPassword))
            {
                HttpContext.Session.SetString("uname", ad.ManagerFirstName + " " + ad.ManagerLastName);
                return View("Home");
            }
            else
            {
                ViewBag.Error = "Invalid Credentials";
                return View("Index");
            }

        }
        [Route("logout")]
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("uname");
            return RedirectToAction("Index");
        }
    }
}
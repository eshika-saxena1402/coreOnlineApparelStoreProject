using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApparelStoreUserPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApparelStoreUserPortal.Controllers
{
    public class BrandController : Controller
    {
        OnlineApparelStoreDbContext context = new OnlineApparelStoreDbContext();

        public IActionResult Display()
        {
            var brands = context.Brands.ToList();
            return View(brands);
        }
        public IActionResult DisplayByBrand(int id)
        {
            var products = context.Products.Where(x => x.BrandId == id).ToList();
            return View(products);

        }
    }
}
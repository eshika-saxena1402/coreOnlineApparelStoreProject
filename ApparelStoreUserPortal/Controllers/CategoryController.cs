﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApparelStoreUserPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApparelStoreUserPortal.Controllers
{
    public class CategoryController : Controller
    {
        OnlineApparelStoreDbContext context = new OnlineApparelStoreDbContext();
        
        public IActionResult Display()
        {
            var categories = context.Categories.ToList();
            return View(categories);
        }
        public IActionResult DisplayByCategory(int id)
        {
            var products = context.Products.Where(x => x.CategoryId == id).ToList();
            return View(products);

        }
    }
}
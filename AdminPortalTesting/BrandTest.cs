using coreOnlineApparelStoreAdminPortal.Controllers;
using coreOnlineApparelStoreAdminPortal.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AdminPortalTesting
{
    public class BrandTest
    {
        BrandController controller;
        DbContextClass context;
        public BrandTest()
        {
            controller = new BrandController(context);
        }
        [Trait("Brand", "Index")]
        [Fact(DisplayName = "BrandIndex")]
        public void Test1()
        {
            IActionResult result = controller.Index();
            Assert.NotNull(result);
            //Assert.Throws<NullReferenceException>(()=> {
            //    controller.Index(); });      
        }
        [Trait("Brand", "Create")]
        [Fact(DisplayName = "BrandCreate")]
        public void Test2()
        {
            IActionResult result = controller.Create();
            Assert.NotNull(result);
        }
        [Trait("Brand", "Create")]
        [Fact(DisplayName = "BrandPostCreate")]
        public void Test3()
        {
            IActionResult result = controller.Create(int b);
            Assert.NotNull(result);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ManagerProduct.Models;
using ManagerProduct.Controllers;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ManagerProduct.Tests.Controllers
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIndex()
        {
            var db = new ProductEntities();
            var controller = new ProductController();

            var result = controller.Index() as ViewResult;


            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result.Model, typeof(List<Product>));
            Assert.AreEqual(db.Products.Count(), (result.Model as List<Product>).Count);
        }
        [TestMethod]
        public void TestCreate()
        {
            var db = new ProductEntities();
            var controller = new ProductController();

            var result = controller.Create() as ViewResult;


            Assert.IsNotNull(result);
           
        }

        [TestMethod]
        public void TestEdit()
        {
           
            var controller = new ProductController();
            var result_0 = controller.Edit(0) as ViewResult;
            Assert.IsInstanceOfType(result_0, typeof(HttpNotFoundResult));


            var db = new ProductEntities();
            var item = db.Products.First();
            var result_1 = controller.Edit(item.id) as ViewResult;
            Assert.IsNotNull(result_1);
            var model = result_1.Model as Product;
            Assert.IsNotNull(model);
            Assert.AreEqual(item.id, model.id);
        }
        
    }
}
 
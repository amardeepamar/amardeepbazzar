using amardeepbazzar.Entities;
using amardeepbazzar.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace e_commerce.Controllers
{
    public class ProductController : Controller
    {
        ProductsService productsService = new ProductsService();

        public ActionResult Index()
        {
            return View();
        }
        //operation for ProductTable ActionMethod
        public ActionResult ProductTable(string search)
        {
            var products = productsService.GetProducts();
            if (string.IsNullOrEmpty(search) == false)
            {
                products = products.Where(p => p.Name!=null && p.Name.ToLower().Contains(search)).ToList();
            }
            
            return PartialView(products);
        }

        //operation for Create ActionMethod
        [HttpGet]
        public ActionResult Create()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            productsService.SaveProduct(product);
            return RedirectToAction("ProductTable", "Product");
        }

        //operation for Edit ActionMethod
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var product = productsService.GetProduct(Id);
            return PartialView(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            productsService.UpdateProduct(product);
            return RedirectToAction("ProductTable", "Product");
        }

        //operation for Delete ActionMethod
        [HttpPost]
        public ActionResult Delete(int Id)
        {
            productsService.DeleteProduct(Id);
            return RedirectToAction("ProductTable", "Product");
        }

    }
}
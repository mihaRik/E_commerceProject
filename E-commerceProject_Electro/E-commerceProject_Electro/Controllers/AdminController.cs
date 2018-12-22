using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_commerceProject_Electro.Models;

namespace E_commerceProject_Electro.Controllers
{
    public class AdminController : Controller
    {
        E_commerceProjectDbContext _db = new E_commerceProjectDbContext();

        // GET: Admin
        public ActionResult Index()
        {
            return View(_db.Products.ToList());
        }

        [HttpGet]
        public ActionResult CreateProduct()
        {
            return View(_db.Categories.ToList());
        }

        [HttpPost]
        [Route("api/image")]
        public ActionResult CreateProduct(string productName, string productPrice,
            string productDiscount, HttpPostedFileBase[] productImage, string productCategoryId)
        {
            Product product = new Product()
            {
                ProductName = productName,
                ProductPrice = Convert.ToSingle(productPrice),
                CategoryId = Convert.ToInt32(productCategoryId),
                ProductDiscountValueInPercents = Convert.ToInt32(productDiscount),
            };
            _db.Products.Add(product);
            _db.SaveChanges();

            foreach (HttpPostedFileBase image in productImage)
            {
                if (image != null && image.ContentLength > 0)
                {
                    string serverPath = Server.MapPath("~/uploads");
                    image.SaveAs(Path.Combine(serverPath, image.FileName));

                    ProductImage productImg = new ProductImage()
                    {
                        ProductId = product.Id,
                        ImagePath = Path.Combine("../uploads", image.FileName)
                    };
                    _db.ProductImages.Add(productImg);
                    _db.SaveChanges();
                }
            }
            return RedirectToAction("CreateProduct");
        }

        [HttpGet]
        public ActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCategory(string categoryName)
        {
            Category category = new Category()
            {
                CategoryName = categoryName
            };
            _db.Categories.Add(category);
            _db.SaveChanges();

            return RedirectToAction("CreateCategory");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_commerceProject_Electro.Models;

namespace E_commerceProject_Electro.Controllers
{
    public class HomeController : Controller
    {
        E_commerceProjectDbContext _db = new E_commerceProjectDbContext();
        // GET: Home
        public ActionResult Index()
        {
            ICollection<ProductToImages> products = _db.Products
                .GroupJoin(_db.ProductImages, x => x.Id, y => y.ProductId, (x, y) => new ProductToImages()
                {
                    Id = x.Id,
                    ProductName = x.ProductName,
                    ProductPrice = x.ProductPrice,
                    ProductDiscountValueInPercents = x.ProductDiscountValueInPercents,
                    ProductAddDate = x.ProductAddDate,
                    ProductImages = y,
                })
                .ToList();

            return View(products);
        }

        public ActionResult Product(int id)
        {
            ProductToImages selectedProduct = _db.Products
                .GroupJoin(_db.ProductImages, x => x.Id, y => y.ProductId, (x, y) => new ProductToImages()
                {
                    Id = x.Id,
                    ProductName = x.ProductName,
                    ProductPrice = x.ProductPrice,
                    ProductDiscountValueInPercents = x.ProductDiscountValueInPercents,
                    ProductAddDate = x.ProductAddDate,
                    ProductImages = y
                })
                .ToList()
                .Find(x => x.Id == id);
            if (selectedProduct == null)
            {
                return View("_ErrorPage");
            }

            return View(selectedProduct);
        }

        public ActionResult Store()
        {
            ICollection<ProductToImages> products = _db.Products
                .GroupJoin(_db.ProductImages, x => x.Id, y => y.ProductId, (x, y) => new ProductToImages()
                {
                    Id = x.Id,
                    ProductName = x.ProductName,
                    ProductPrice = x.ProductPrice,
                    ProductDiscountValueInPercents = x.ProductDiscountValueInPercents,
                    ProductAddDate = x.ProductAddDate,
                    ProductImages = y,
                })
                .ToList();

            return View(products);
        }
    }
}
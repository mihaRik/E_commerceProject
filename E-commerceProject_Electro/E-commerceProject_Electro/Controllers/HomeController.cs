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
            return View(_db.Products.ToList());
        }
    }
}
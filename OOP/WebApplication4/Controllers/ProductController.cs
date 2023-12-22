using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class ProductController : Controller
    {
        public EFDbContext db = new EFDbContext();
        public ViewResult List()
        {
            return View(db.Products);
        }
        // GET: Product
/*        public ActionResult Index()
        {
            return View();
        }*/
    }
}
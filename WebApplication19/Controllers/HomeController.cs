using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication19.Models;

namespace WebApplication19.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using WebApplication19.Models;

    namespace BookStore.Controllers
    {
        public class HomeController : Controller
        {
            BookContext db = new BookContext();
            public ActionResult Index()
            {
                // получаем из од все объекты Book
                IEnumerable<Book> books = db.Books;
                ViewBag.Books = books;
                return View();
            }
        }
    }
}
/*using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication19.Models;

namespace WebApplication19.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}*/
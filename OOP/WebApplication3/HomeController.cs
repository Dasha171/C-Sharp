using Microsoft.AspNetCore.Mvc;

namespace WebApplication3
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var products = _dbContext.Products.ToList();
            var viewModel = new ProductViewModel // создайте класс ViewModel с нужными свойствами
            {
                Products = products
            };
            return View(viewModel);
        }

        public IActionResult Buy(int id)
        {
            var product = _dbContext.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            // Здесь может быть логика оформления заказа

            return View(product);
        }
    }

}

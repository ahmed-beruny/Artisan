using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Artisan.Models;

namespace Artisan.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly myDbContext _context;

    public HomeController(ILogger<HomeController> logger, myDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        var query = from p in _context.Products
                    join c in _context.Categories on p.CategoryId equals c.Id
                    select new Product
                    {
                        Id = p.Id,
                        Name = p.Name,
                        Description = p.Description,
                        Price = p.Price,
                        Image = p.Image,
                        CategoryId = p.CategoryId,
                        Category = c
                    };
        List<Product> products = query.ToList();
        return View(products);
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

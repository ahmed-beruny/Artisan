using Microsoft.AspNetCore.Mvc;

public class AdminController : Controller {

    private readonly myDbContext _context;

    public AdminController(myDbContext context) {
        _context = context;
    }
    public IActionResult Index() {
        List<Product> products = _context.Products.ToList();
        return View(products);
    }

    public IActionResult AddCategory() {
        return View();
    }

    //add category
    [HttpPost]
    public IActionResult AddCategory(Category category) {
        _context.Categories.Add(category);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    //add product
    public IActionResult AddProduct() {
        ViewBag.Categories = _context.Categories.ToList();
        return View();
    }

    [HttpPost]
    public IActionResult AddProduct(Product product) {
        _context.Products.Add(product);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
}
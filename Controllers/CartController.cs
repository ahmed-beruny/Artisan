using Microsoft.AspNetCore.Mvc;

public class CartController : Controller{
    public IActionResult Index(){
        return View();
    }

    public IActionResult AddToCart(){
        return View();
    }

    [HttpPost]
    public IActionResult AddToCart(int id){
        return View();
    }

    public IActionResult RemoveFromCart(){
        return View();
    }

    public IActionResult Checkout(){
        return View();
    }

    public IActionResult OrderConfirmation(){
        return View();
    }


}
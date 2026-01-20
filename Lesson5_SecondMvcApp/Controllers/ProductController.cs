using Lesson5_SecondMvcApp.Helpers;
using Lesson5_SecondMvcApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson5_SecondMvcApp.Controllers;

public class ProductController : Controller
{
    private List<Product> _products;

    public ProductController()
    {
        _products = ProductHelper.GetAllProduct();
    }

    [HttpGet]
    public IActionResult CreateProduct()
    {
        return View();
    }

    //[HttpPost]
    //public IActionResult CreateProduct()
    //{
    //    return View();
    //}



}

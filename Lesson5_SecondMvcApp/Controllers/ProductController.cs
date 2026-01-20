using Lesson5_SecondMvcApp.Helpers;
using Lesson5_SecondMvcApp.Models;
using Lesson5_SecondMvcApp.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace Lesson5_SecondMvcApp.Controllers;

public class ProductController : Controller
{
    public const string Product = "Product";
    private readonly IRepository _repository;
    private List<Product> _products;

    public ProductController(IRepository repository)
    {
        _repository = repository;
        _products = ProductHelper.GetAllProduct();
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    // // Way 1
    // [HttpPost]
    // public IActionResult CreateProduct(string productName, decimal productPrice, string productDesc)
    // {
    //     var newProduct = new Product()
    //     {
    //         Id = Guid.NewGuid(),
    //         Name = productName,
    //         Price = productPrice,
    //         Description = productDesc
    //     };
    //     _products.Add(newProduct);
    // 
    //     return RedirectToAction(nameof(Index));
    // }

    // // Way 2
    // [HttpPost]
    // public IActionResult CreateProduct(Product product)
    // {
    //     product.Id = Guid.NewGuid();
    //     _products.Add(product);
    // 
    //     return RedirectToAction(nameof(Index));
    // }


    //  // Way3 
    //  [HttpPost]
    //  public IActionResult CreateProduct(Product product)
    //  {
    //      product.Id = Guid.NewGuid();
    //      _products.Add(product);
    // 
    //      return RedirectToAction(nameof(Index));
    //  }

    // Custom
    public IActionResult CreateProduct(Product product)
    {
        product.Id = Guid.NewGuid();

        _repository.Add(product);

        return RedirectToAction(nameof(Index));
    }
}

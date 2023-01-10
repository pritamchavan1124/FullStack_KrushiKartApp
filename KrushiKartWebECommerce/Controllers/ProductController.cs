using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using KrushiKartWebECommerce.Models;

using BLLKrushiKart;
using BOLKrushiKart;

namespace KrushiKartWebECommerce.Controllers;

public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        CatlogManager manager=new CatlogManager();
        List<KrushiProduct> list=manager.GetAllProducts();
        this.ViewData["products"]=list;
        return View();
    }

    // public IActionResult Details(int id)
    // {
    //     CatlogManager managers=new CatlogManager();
    //     KrushiProduct product=managers.GetProduct(id);
    //     this.ViewData["product"]=product;

    //     return View();
    // }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

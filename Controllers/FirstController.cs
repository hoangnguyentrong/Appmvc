using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppMvc.Services;
using Microsoft.AspNetCore.Mvc;

namespace AppMvc.Controllers
{

  public class FirstController : Controller
{

    private readonly ILogger<FirstController> _logger;
    private readonly ProductService _productService;
    public FirstController(ILogger<FirstController> logger, ProductService productService)
    {
        _logger = logger;
        _productService = productService;
    }

    

    public string Index()
    {
      _logger.LogWarning("Thong báo");
        _logger.LogInformation("Index Action");
        return "Tôi là Index của First";
    }
    public object Nothing(){
      _logger.LogInformation("Action status");
      return DateTime.Now;
      
    }
    public IActionResult HelloView(){
      return View();
    }
public IActionResult ViewProduct(int? id)
{
    if (id == null)
        return NotFound();

    var product = _productService.FirstOrDefault(p => p.Id == id);
    if (product == null)
        return NotFound();

    ViewBag.Message = $"Sản phẩm với id = {id}";
    this.ViewData["product"] = product;
    return View();
}
}
}
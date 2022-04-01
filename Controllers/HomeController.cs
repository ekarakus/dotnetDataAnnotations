using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using kayit.Models;

namespace kayit.Controllers;

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
[HttpGet]
    public IActionResult Urun(){
        Urun u= new Urun();
        return View(u);
    }
    [HttpPost]
    public IActionResult Urun(Urun model){
        
        if(ModelState.IsValid){
            if(model.agirlik>1000){
                ModelState.AddModelError("agirlik","Ağırlık 1000 altı olmalı");
                return View(model);
            }
            return  View("Views/Home/Tamam.cshtml",model);
        }
        return View(model);
    }
}

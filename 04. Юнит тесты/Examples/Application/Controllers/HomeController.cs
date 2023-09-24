using System.Diagnostics;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers;

public class HomeController : Controller
{

    private readonly IHomeService _homeService;

    public HomeController(IHomeService homeService)
    {
        _homeService = homeService;        
    }

    public IActionResult Index()
    {
        return View("Index", _homeService.MyMethod());
    }  
}

using System.Diagnostics;
using ApplicationLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationLayer.Controllers;

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

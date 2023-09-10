using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Example6.Services;

namespace CFT.Template
{
    public class HomeController : Controller
    {
        private HomeService _homeService;

        public HomeController(HomeService homeService)
        {
            _homeService = homeService;
        }


        public IActionResult Index()
        {
            var model = _homeService.GetHomeViewModel();
            return View(model);
        }
    }
}
﻿using Microsoft.AspNetCore.Mvc;

namespace PhotographyPortfolio.Controllers
{
    public class PhotographyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BW()
        {
            return View();
        }
    }
}

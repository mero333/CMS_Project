﻿using Microsoft.AspNetCore.Mvc;

namespace CMS_Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace netcore.Controllers
{
    public class ProductsController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace pasta.Controllers
{
    public class pastaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
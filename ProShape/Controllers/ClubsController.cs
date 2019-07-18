using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProShape.Controllers
{
    public class ClubsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Level3.Controllers
{
    public class AppointmentsController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
    }
}
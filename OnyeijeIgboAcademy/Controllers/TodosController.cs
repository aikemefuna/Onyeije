using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnyeijeIgboAcademy.Controllers
{
    public class TodosController : Controller
    {
        public IActionResult Calender()
        {
            return View();
        }
    }
}

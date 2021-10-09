using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList_App.Controllers
{
    public class TodoAppController : Controller
    {


        public IActionResult TodoMainView()
        {
            return View();
        }
    }
}

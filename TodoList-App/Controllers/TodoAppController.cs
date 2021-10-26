using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList_App.Models;
using TodoList_App.Services;

namespace TodoList_App.Controllers
{
    public class TodoAppController : Controller
    {

        private readonly IDbService<Todo> _todoService;
        public TodoAppController(IDbService<Todo> todoService)
        {
            _todoService = todoService;
        }
        
        
        [HttpGet]
        public async Task<IActionResult> TodoMainView()
        {
            return  View( await _todoService.GetAllAsync());
        }


        [HttpGet]
        public async Task<IActionResult> GetTodo(int id)
        {
            return PartialView("_modalPopPartial",await _todoService.GetByIdAsync(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetModalView()
        {
            return PartialView("_modalPopPartial");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> InsertTodo(Todo todo)
        {
            if (ModelState.IsValid)
            {
                await _todoService.InsertAsync(todo);
                var lists = await _todoService.GetAllAsync();

                return Json(lists);
            }

            else
            {
                return PartialView("_modalPopPartial", todo);
            }
        }



    }
}

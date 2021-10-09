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

        public async Task<IActionResult> TodoMainView()
        {
            return  View( await _todoService.GetAllAsync());
        }
    }
}

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
            return  View(await _todoService.GetAllAsync());
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

        [HttpGet]
        public IActionResult GetModalViewUpdate(Todo todo)
        {
            return PartialView("_modalPopPartial",todo);
        }


        [HttpGet]
        public IActionResult GetDeleteModalView(Todo todo)
        {
            return PartialView("_ModalDeletePartial",todo);
        }

        [HttpGet]
        public async Task<IActionResult> GetListTable()
        {
            return PartialView("_TablePartial", await _todoService.GetAllAsync());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> InsertTodo(Todo todo)
        {
            if (ModelState.IsValid)
            {

               await _todoService.InsertAsync(todo);

                return RedirectToAction("GetListTable");
            }

            else
            {
                return PartialView("_modalPopPartial", todo);
            }
        }

        [HttpPost]

        public async Task<IActionResult> DeleteTodo(int id)
        {
   
            await _todoService.DeleteAsync(id);

            return RedirectToAction("GetListTable");
        }


        [HttpPost]

        public async Task<IActionResult> DeleteAllTodo()
        {
             await _todoService.DeleteAllAsync(await _todoService.GetAllAsync());

            return RedirectToAction("GetListTable");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateTodo(Todo todo)
        {
            await _todoService.UpdateAsync(todo);
            return RedirectToAction("GetListTable");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList_App.Data;

namespace TodoList_App.Services
{
    public class TodoService
    {
        private readonly AppDbContext _dbContext;
        public TodoService(AppDbContext dbcontext)
        {
            _dbContext = dbcontext;
        }
    }
}

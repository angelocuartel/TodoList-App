using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList_App.Data;
using TodoList_App.Models;

namespace TodoList_App.Services
{
    public class TodoService : IDbService<Todo>
    {
        private readonly AppDbContext _dbContext;
        public TodoService(AppDbContext dbcontext)
        {
            _dbContext = dbcontext;
        }

        public async Task DeleteAsync(int id)
        {
            using (_dbContext)
            {
                _dbContext.Remove(await _dbContext.Todos.FindAsync(id));
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Todo>> GetAllAsync()
        {
            using (_dbContext)
            {
                return await _dbContext.Todos.ToListAsync();
            }
        }

        public async Task<Todo> GetByIdAsync(int id)
        {
            using (_dbContext)
            {
                return await _dbContext.Todos.FindAsync(id);
            }
        }

        public async Task InsertAsync(Todo obj)
        {
            using (_dbContext)
            {
               await _dbContext.AddAsync(obj);
               await _dbContext.SaveChangesAsync();
            }

           
        }

        public async Task UpdateAsync(int id)
        {
            using (_dbContext)
            {
                _dbContext.Update(await _dbContext.Todos.FindAsync(id));
                await _dbContext.SaveChangesAsync();
            }
        }

         
       

       
    }
}

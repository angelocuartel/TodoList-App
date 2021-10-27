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
            
                _dbContext.Remove(await _dbContext.Todos.FindAsync(id));
                await _dbContext.SaveChangesAsync();
            
        }

        public async Task<IEnumerable<Todo>> GetAllAsync()
        {
            
                return await _dbContext.Todos.ToListAsync();
        }

        public async Task<Todo> GetByIdAsync(int id)
        {
          
                return await _dbContext.Todos.FindAsync(id);
            
        }

        public void Insert(Todo obj)
        {
            
                _dbContext.Todos.Add(obj);
                 _dbContext.SaveChanges();
            
        }

        public async Task InsertAsync(Todo obj)
        {
            
               await _dbContext.AddAsync(obj);
               await _dbContext.SaveChangesAsync();
            

           
        }

        public async Task UpdateAsync(int id)
        {
           
                _dbContext.Update(await _dbContext.Todos.FindAsync(id));
                await _dbContext.SaveChangesAsync();
            
        }

         
       

       
    }
}

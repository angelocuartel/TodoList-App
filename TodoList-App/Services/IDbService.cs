using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList_App.Services
{
    interface IDbService<T>
    {

         Task InsertAsync(T obj);

        Task<T> GetByIdAsync(int id);

        Task<IEnumerable<T>> GetAllAsync();

        Task DeleteAsync(int id);

        Task UpdateAsync(int id);
    }
}

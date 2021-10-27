using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList_App.Services
{
    public interface IDbService<T>
    {

         Task InsertAsync(T obj);

        Task<T> GetByIdAsync(int id);

        Task<IEnumerable<T>> GetAllAsync();

        Task DeleteAsync(int id);

        Task DeleteAllAsync(IEnumerable<T> list);

        Task UpdateAsync(T obj);

        void Insert(T obj);
    }
}

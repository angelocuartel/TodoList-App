using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList_App.Services
{
    interface IDbService<T>
    {

        void CreateAsync();

        T GetByIdAsync(int id);

        IEnumerable<T> GetAllAsync();

        void DeleteAsync();

        void UpdateAsync();
    }
}

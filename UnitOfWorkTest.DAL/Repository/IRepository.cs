using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWorkTest.DAL.Repository
{
    public interface IRepository<T> where T: class
    {
        IEnumerable<T> GetAllData();
        IEnumerable<T> Search();
        T GetByID(int id);
        void Add(T model);
        void Edit(T model);
        void Remove(int id);
    }
}

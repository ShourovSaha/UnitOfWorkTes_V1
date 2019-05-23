using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using UnitOfWorkTest.DAL.Repository;

namespace UnitOfWorkTest.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbSet<T> _entities = null;

        public Repository(DbContext db)
        {
            this._entities = db.Set<T>(); 
        }   
        
        public void Add(T model)
        {
            _entities.Add(model);
        }

        public void Edit(T model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAllData()
        {
            return _entities.ToList();
        }

        public T GetByID(int id)
        {
            return _entities.Find(id);
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Search()
        {
            throw new NotImplementedException();
        }
    }
}
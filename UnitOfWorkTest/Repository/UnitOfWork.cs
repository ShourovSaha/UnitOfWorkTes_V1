using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnitOfWorkTest.DAL.Repository;
using UnitOfWorkTest.DAL.DBModel;

namespace UnitOfWorkTest.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DBEmployeeEntities2 _dBContext; 
        public IEmployeeRepository Employees { get; }

        public UnitOfWork(DBEmployeeEntities2 dBContext)
        {
            this._dBContext = dBContext;
            this.Employees = new EmployeeRepository(_dBContext);
        }

        public int Complete()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _dBContext.Dispose();
        }
    }
}
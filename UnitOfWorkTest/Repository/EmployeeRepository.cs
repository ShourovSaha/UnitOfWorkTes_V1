using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnitOfWorkTest.DAL;
using UnitOfWorkTest.DAL.DBModel;
using UnitOfWorkTest.DAL.Repository;

namespace UnitOfWorkTest.Repository
{
    public class EmployeeRepository : Repository<Table_Employee>, IEmployeeRepository
    {
        private readonly DBEmployeeEntities2 _entities;

        public EmployeeRepository(DBEmployeeEntities2 dbContext) : base(dbContext)
        {
            this._entities = dbContext;
        }

        public IEnumerable<Table_Employee> GetHightPaidEmployee(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkTest.DAL;
using UnitOfWorkTest.DAL.DBModel;

namespace UnitOfWorkTest.DAL.Repository
{
    public interface IEmployeeRepository : IRepository<Table_Employee>
    {
        IEnumerable<Table_Employee> GetHightPaidEmployee(decimal amount);
    }
}

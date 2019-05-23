using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnitOfWorkTest.DAL;
using UnitOfWorkTest.DAL.DBModel;
using UnitOfWorkTest.Repository;

namespace UnitOfWorkTest.Controllers
{
    public class EmployeeController : Controller
    {
        private UnitOfWork uow;
        public EmployeeController()
        {
            uow = new UnitOfWork(new DBEmployeeEntities2());
        }
        // GET: Employee
        public ActionResult Index()
        {
            return View(uow.Employees.GetAllData());
        }

        public ActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEmployee(Table_Employee model)
        {
            try
            {
                uow.Employees.Add(model);
                ViewBag.msg = true;
            }
            catch (Exception ex)
            {
                ViewBag.msg = ex.Message;
            }
            
            return View();
        }
    }
}
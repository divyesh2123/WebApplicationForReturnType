using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationForReturnType.Concreate;
using WebApplicationForReturnType.Interface;

namespace WebApplicationForReturnType.Controllers
{
    public class EmployeeViewController : Controller
    {
        // GET: EmployeeView
        public ActionResult Index()
        {
            IEmployeeRepositroy employeeRepositroy = new EmployeeRepositroy();
            var result =  employeeRepositroy.GetEmployeeDepartmentList();

            return View(result);
        }
    }
}
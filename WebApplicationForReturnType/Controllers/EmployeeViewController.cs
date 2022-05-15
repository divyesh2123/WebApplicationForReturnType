using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationForReturnType.Concreate;
using WebApplicationForReturnType.Interface;
using WebApplicationForReturnType.ViewModel;

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

        
        public ActionResult DeleteEmployeInfo(int employeeId)
        {
            IEmployeeRepositroy employeeRepositroy = new EmployeeRepositroy();

            employeeRepositroy.DeleteEmployeeInformation(employeeId);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult CreateEmployee(EmployeeDepartmentViewModel employee)
        {
            IEmployeeRepositroy employeeRepositroy= new EmployeeRepositroy();
            employeeRepositroy.AddEmployeeInformation(employee);

            return RedirectToAction("Index");

        }

        public ActionResult CreateEmployee()
        {
            IDepartmentRepository departmentRepository = new DepartmentRepository();



            EmployeeDepartmentViewModel employeeDepartmentViewModel = new EmployeeDepartmentViewModel();

            employeeDepartmentViewModel.Data = departmentRepository.GetDepartmentsData();



            return View(employeeDepartmentViewModel);
        }



    }
}
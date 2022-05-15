using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationForReturnType.Interface;
using WebApplicationForReturnType.ViewModel;

namespace WebApplicationForReturnType.Concreate
{
    public class EmployeeRepositroy : IEmployeeRepositroy
    {
        public bool AddEmployeeInformation(EmployeeDepartmentViewModel employeeDepartmentViewModel)
        {
            using (EMSEntities eMSEntities = new EMSEntities())
            {
                Employee employee = new Employee();
                employee.City = employeeDepartmentViewModel.City;
                employee.State = employeeDepartmentViewModel.State;
                employee.ZipCode = employeeDepartmentViewModel.ZipCode;
                employee.LastName = employeeDepartmentViewModel.LastName;
                employee.FirstName = employeeDepartmentViewModel.FirstName;
                employee.DepartmentID = employeeDepartmentViewModel.DepartmentId;
                eMSEntities.Employees.Add(employee);
               var myData =  eMSEntities.SaveChanges() > 0 ? true: false;

                return myData;

            }
        }

        public bool DeleteEmployeeInformation(int employeeId)
        {

            using (EMSEntities eMSEntities = new EMSEntities())
            {
                var data = eMSEntities.Employees.Where(y => y.ID == employeeId).FirstOrDefault();

                if (data != null)
                {

                    eMSEntities.Employees.Remove(data);

                    return eMSEntities.SaveChanges() > 0 ? true : false;


                }

                else
                {
                    return false;
                }


            }

        }

        public List<EmployeeDepartmentViewModel> GetEmployeeDepartmentList()
        {
            using (EMSEntities eMSEntities = new EMSEntities())
            {
                var empdata = eMSEntities.Employees.ToList();

                var deptData = eMSEntities.Depts.ToList();


                var result = empdata.Join(deptData, y => y.DepartmentID, x => x.ID, (y, x) => new EmployeeDepartmentViewModel
                {
                    City = y.City,
                    DepartmentName = x.DepartmentName,
                    EmployeeId = y.ID,
                    DepartmentId = y.DepartmentID.Value,
                    FirstName = y.FirstName,
                    LastName = y.LastName,
                    State = y.State,
                    ZipCode = y.ZipCode

                }).ToList();


                return result;



            }
            
        }
  
        
    
    }
}
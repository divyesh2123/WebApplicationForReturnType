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
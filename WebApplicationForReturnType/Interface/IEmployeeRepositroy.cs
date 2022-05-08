using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationForReturnType.ViewModel;

namespace WebApplicationForReturnType.Interface
{
    public interface IEmployeeRepositroy
    {
         List<EmployeeDepartmentViewModel> GetEmployeeDepartmentList();


    }
}

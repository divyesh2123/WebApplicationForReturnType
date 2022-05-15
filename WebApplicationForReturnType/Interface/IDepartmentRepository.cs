using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace WebApplicationForReturnType.Interface
{
    public interface IDepartmentRepository
    {
        List<SelectListItem> GetDepartmentsData();
    }
}

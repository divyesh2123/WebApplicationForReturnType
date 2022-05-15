using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationForReturnType.ViewModel
{
    public class EmployeeDepartmentViewModel
    {

        public int EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string City { get; set; }

        public string State { get; set; }


        public string ZipCode { get; set; }

        public int DepartmentId { get; set; }

        public string DepartmentName { get; set; }

        public List<SelectListItem> Data { get; set; }




    }
}
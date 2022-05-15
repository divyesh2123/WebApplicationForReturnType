using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationForReturnType.Interface;

namespace WebApplicationForReturnType.Concreate
{
    public class DepartmentRepository : IDepartmentRepository
    {
        public List<SelectListItem> GetDepartmentsData()
        {
            using (EMSEntities eMS  = new EMSEntities())
            {

                var data = eMS.Depts.ToList().Select(y => new SelectListItem
                {Text = y.DepartmentName,
                Value = y.ID.ToString()

                }).ToList();


                return data;

            }
        }
    }
}
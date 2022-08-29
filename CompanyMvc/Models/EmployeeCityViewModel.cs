using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace CompanyMvc.Models
{
    public class EmployeeCityViewModel
    {
        public List<Employee> Employees { get; set; }
        public SelectList Cities { get; set; }
        public string EmployeeCity { get; set; }
        public string SearchString { get; set; }
    }
}

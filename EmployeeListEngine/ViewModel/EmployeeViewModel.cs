using EmployeeListEngine.Model;
using EmployeeListEngine.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeListEngine.ViewModel
{
    public class EmployeeViewModel
    {
        public EmployeeViewModel(Employee employee)
        {
            Name = employee.Name;
            EmployeeUri = employee.EmployeeUri;
            Title = employee.Title;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string EmployeeUri { get; set; }
        public string Title { get; set; }
    }
}

using EmployeeListEngine.Model;
using EmployeeListEngine.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeListEngine.ViewModel
{
    public class EmployeeListViewModel : INotifyPropertyChanged
    {
        public List<Employee> Employees { get; set; }

        public EmployeeListViewModel()
        {
            Employees = new List<Employee>();
            Employees = EmployeeGenerator.CreateEmployees();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

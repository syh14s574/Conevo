using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EmployeeListEngine.Model
{
    public class Employee
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string EmployeeUri { get; set; }
        public string Title { get; set; }
    }


    public class ContactManager
    {
        public List<Employee> Employees { get; set; }

    }

}

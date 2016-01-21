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
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string City { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public string SkypeAddress { get; set; }
        public string HomeAddress { get; set; }
        public string ImgUrl { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public List<string> Skill { get; set; }
        public List<string> Project { get; set; }
        public string Info { get; set; }
    }


    public class ContactManager
    {
        public List<Employee> Employees { get; set; }

    }

}

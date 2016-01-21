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
            EmployeeId = employee.EmployeeId;
            FirstName = employee.FirstName;
            SurName = employee.SurName;
            City = employee.City;
            Location = employee.Location;
            Email = employee.Email;
            HomePhone = employee.HomePhone;
            MobilePhone = employee.MobilePhone;
            SkypeAddress = employee.SkypeAddress;
            ImgUrl = employee.ImgUrl;
            Title = employee.Title;
            Company = employee.Company;
            Skill = employee.Skill;
            Project = employee.Project;
            Info = employee.Info;
        }

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
}

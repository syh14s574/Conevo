using EmployeeListEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeListEngine.Services
{
    public class EmployeeGenerator
    {
        private static List<string> PicturePath = new List<string>() { "Bild", "Bild", "Bild", "Bild", "Bild", "Bild" };
        private static List<string> Name = new List<string>() { "Anna Berg", "Berit Eriksson", "Cecilia Fransson", "Dorothea Andersson", "Eva Colt", "Filippa Daysson" };
        private static List<string> Title = new List<string>() { "VD", "Programmer", "Marketing", "Programmer", "Programmer", "Marketing" };

        public static List<Employee> CreateEmployees()
        {
            var random = new Random();
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < 25; i++)
            {
                string picturePath = PicturePath[random.Next(PicturePath.Count - 1)];
                string name = Name[random.Next(Name.Count - 1)];
                string title = Title[random.Next(Title.Count - 1)];

                Employee employee = new Employee() { EmployeeUri = picturePath, Name = name, Title = title};
                employees.Add(employee);
            }
            return employees;
        }
    }
}

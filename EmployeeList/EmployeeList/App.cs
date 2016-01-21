using EmployeeList.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace EmployeeList
{
    public class App : Application
    {
        //private static List<string> FirstName = new List<string>() { "Anna", "Berit", "Cecilia", "Dorothea", "Eva", "Filippa" };
        //private static List<string> LastName = new List<string>() { "Andersson", "Berg", "Colt", "Daysson", "Eriksson", "Fransson" };

        public App()
        {

            MainPage = new NavigationPage(new EmployeeListView());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

       //private void SeedDatabase()
       // {
       //     ContactDatabase db = new ContactDatabase();

       //     db.SaveContact(new Contact()
       //     {
       //         FirstName = "Anna",
       //         LastName = "Andersson",
       //         Email = "anna.andersson@nackademin.se",
       //         PhoneNo = "08-11 22 33",
       //         BirthDate = new DateTime(1970, 01, 01)
       //     });
       //     db.SaveContact(new Contact()
       //     {
       //         FirstName = "Berit",
       //         LastName = "Berg",
       //         Email = "Berit.berg@nackademin.se",
       //         PhoneNo = "08-33 22 33",
       //         BirthDate = new DateTime(1971, 02, 01)
       //     });
       //     db.SaveContact(new Contact()
       //     {
       //         FirstName = "Cecilia",
       //         LastName = "Colt",
       //         Email = "Cecilia.colt@nackademin.se",
       //         PhoneNo = "08-44 22 33",
       //         BirthDate = new DateTime(1973, 12, 01)
       //     });
       //     db.SaveContact(new Contact()
       //     {
       //         FirstName = "Dorothea",
       //         LastName = "Daysson",
       //         Email = "dorothea.daysson@nackademin.se",
       //         PhoneNo = "08-55 22 33",
       //         BirthDate = new DateTime(1980, 09, 12)
       //     });
       //     db.SaveContact(new Contact()
       //     {
       //         FirstName = "Eva",
       //         LastName = "Eriksson",
       //         Email = "eva.eriksson@nackademin.se",
       //         PhoneNo = "08-66 22 33",
       //         BirthDate = new DateTime(1979, 5, 21)
       //     });
       //     db.SaveContact(new Contact()
       //     {
       //         FirstName = "Filippa",
       //         LastName = "Fransson",
       //         Email = "filippa.fransson@nackademin.se",
       //         PhoneNo = "08-77 22 33",
       //         BirthDate = new DateTime(1985, 8, 23)
       //     });
       // }
    }
}

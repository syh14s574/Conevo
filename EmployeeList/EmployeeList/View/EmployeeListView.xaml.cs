using EmployeeListEngine.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EmployeeList.View
{
    public partial class EmployeeListView : ContentPage
    {
        // Hämtar viewModellen för EmployeeListan.
        private EmployeeListViewModel _EmployeeListViewModel;
        public EmployeeListView()
        {
            // Skapar instans av ViewModellen.
            _EmployeeListViewModel = new EmployeeListViewModel();
            InitializeComponent();
            // Kopplar bindningen till vymodellen.
            BindingContext = _EmployeeListViewModel;
        }
    }
}

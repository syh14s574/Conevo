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
    public class TimeReportListViewModel : INotifyPropertyChanged
    {
        public List<TimeReport> TimeReports { get; set; }

        public TimeReportListViewModel()
        {
            TimeReports = new List<TimeReport>();
            TimeReports = TimeReportGenerator.CreateTimeReports();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using timesheet.core.Base;
using timesheet.core.Singleton;
using timesheet.data.Models;
using timesheet.data.Services;
using timesheet.services.Models;

namespace timesheet.wpf.ViewModel
{
    public class TimeSheetViewModel : BaseViewModel
    {
        private EmployeeService _employeeService;

        public List<EmployeeTaskDays> employees
        {
            get;set;
        }

        public TimeSheetViewModel()
        {
            _employeeService = (EmployeeService)SingletonInstances.GetEmployeeService(typeof(EmployeeService));

            Task.Run(new Action(OnLoaded));
            
        }

        private async void OnLoaded()
        {
            await Load();
        }

        private async Task Load()
        {
            employees = await this._employeeService.GetEmployeeTaskDays();
            NotifyPropertyChanged("employees");
            
        }


    }
}

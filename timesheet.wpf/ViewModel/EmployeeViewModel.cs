using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using timesheet.core.Base;
using timesheet.core.Singleton;
using timesheet.data.Models;
using timesheet.data.Services;

namespace timesheet.wpf.ViewModel
{
    public class EmployeeViewModel : BaseViewModel
    {
        private EmployeeService _employeeService;

        public List<Employee> employees
        {
            get;set;
        }

        public EmployeeViewModel()
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
            employees = await this._employeeService.GetEmployees();
            NotifyPropertyChanged("employees");
            
        }


    }
}

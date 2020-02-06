using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using timesheet.data.Models;
using timesheet.services.Models;

namespace timesheet.data.Contracts
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetEmployees();

        Task<List<EmployeeTaskDays>> GetEmployeeTaskDays();
    }
}

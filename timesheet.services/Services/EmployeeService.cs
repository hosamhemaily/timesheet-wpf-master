using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using timesheet.data.Contracts;
using timesheet.data.Models;
using timesheet.services.Models;

namespace timesheet.data.Services
{
    public class EmployeeService : IEmployeeService
    {
        private string _baseurl = "http://localhost:5000/api";
        public EmployeeService()
        {
          
        }
        public async Task<List<Employee>> GetEmployees()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    List<Employee> employees = new List<Employee>();
                    HttpResponseMessage response = await client.GetAsync(this._baseurl + "/employee/getall");
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        employees = JsonConvert.DeserializeObject<List<Employee>>(json);
                    }
                    return employees;
                }
            }
            catch(Exception ex)
            {
                return null;
            }
            
        }

        public async Task<List<EmployeeTaskDays>> GetEmployeeTaskDays()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    List<EmployeeTaskDays> employees = new List<EmployeeTaskDays>();
                    HttpResponseMessage response = await client.GetAsync(this._baseurl + "/employee/GetAllEmpTasks");
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        employees = JsonConvert.DeserializeObject<List<EmployeeTaskDays>>(json);
                    }
                    return employees;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

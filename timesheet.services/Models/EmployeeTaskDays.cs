using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timesheet.services.Models
{
    public class EmployeeTaskDays
    {
        public string TaskName { get; set; }

        public double Sat { get; set; }
        public double Sun { get; set; }
        public double Mon { get; set; }
        public double Tue { get; set; }
        public double Wed { get; set; }
        public double Thu { get; set; }
        public double Fri { get; set; }

    }
}

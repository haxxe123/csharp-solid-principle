using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principle.open_closed.right
{
    public class SeniorDevSalaryCalculator : BaseSalaryCalculator
    {
        public SeniorDevSalaryCalculator(DeveloperReport report)
            : base(report)
        {
        }
        public override double CalculateSalary() => DeveloperReport.HourlyRate * DeveloperReport.WorkingHours * 1.2;
    }
}
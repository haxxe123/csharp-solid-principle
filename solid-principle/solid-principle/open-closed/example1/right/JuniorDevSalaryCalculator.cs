using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principle.open_closed.right
{
    public class JuniorDevSalaryCalculator : BaseSalaryCalculator
    {
        public JuniorDevSalaryCalculator(DeveloperReport developerReport)
            : base(developerReport)
        {
        }
        public override double CalculateSalary() => DeveloperReport.HourlyRate * DeveloperReport.WorkingHours;
    }
}
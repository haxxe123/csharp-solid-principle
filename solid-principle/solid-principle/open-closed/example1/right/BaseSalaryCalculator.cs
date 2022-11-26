using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principle.open_closed.right
{
    public abstract class BaseSalaryCalculator
    {
        protected DeveloperReport DeveloperReport { get; private set; }
        public BaseSalaryCalculator(DeveloperReport developerReport)
        {
            DeveloperReport = developerReport;
        }
        public abstract double CalculateSalary();
    }
}

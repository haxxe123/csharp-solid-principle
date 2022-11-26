using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principle.open_closed.wrong
{
    public class SalaryCalculator
    {
        private readonly IEnumerable<DeveloperReport> _developerReports;
        public SalaryCalculator(List<DeveloperReport> developerReports)
        {
            _developerReports = developerReports;
        }
        public double CalculateTotalSalaries()
        {
            double totalSalaries = 0D;
            foreach (var devReport in _developerReports)
            {
                if (devReport.Level == "Senior developer") // open-closed violated => if we add another category of developer we will need to modify the code
                {
                    totalSalaries += devReport.HourlyRate * devReport.WorkingHours * 1.2;
                }
                else // Junior developer salary
                {
                    totalSalaries += devReport.HourlyRate * devReport.WorkingHours; 
                }
            }
            return totalSalaries;
        }
    }
}
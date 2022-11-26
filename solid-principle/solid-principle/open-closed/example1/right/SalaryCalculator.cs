using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principle.open_closed.right
{
    public class SalaryCalculator
    {
        private readonly IEnumerable<BaseSalaryCalculator> _developerCalculation;
        public SalaryCalculator(IEnumerable<BaseSalaryCalculator> developerCalculation)
        {
            _developerCalculation = developerCalculation;
        }
        public double CalculateTotalSalaries()
        {
            double totalSalaries = 0D;
            foreach (var devCalc in _developerCalculation)
            {
                totalSalaries += devCalc.CalculateSalary(); // if there is a new dev category we don't need to modify the code here ! it's Opened for Extension !
            }
            return totalSalaries;
        }
    }
}
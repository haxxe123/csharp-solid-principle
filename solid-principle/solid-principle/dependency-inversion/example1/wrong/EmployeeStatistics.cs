using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principle.dependency_inversion.example1.wrong
{
    public class EmployeeStatistics
    {
        private readonly EmployeeManager _empManager;
        public EmployeeStatistics(EmployeeManager empManager)
        {
            _empManager = empManager;
        }
        public int CountFemaleManagers() =>
           _empManager.Employees.Count(emp => emp.Gender == Gender.Female && emp.Position == Position.Manager); // DIP Violated -> strong relation between EmployeeManager
        // The high level EmployeeStatistics depend on low level class EmployeeManager
        // EmployeeStatistics should depend on abstraction

    }
}

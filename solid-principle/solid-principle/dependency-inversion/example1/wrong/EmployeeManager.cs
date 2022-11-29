using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principle.dependency_inversion.example1.wrong
{
    public class EmployeeManager
    {
        private readonly List<Employee> _employees;
        public EmployeeManager()
        {
            _employees = new List<Employee>();
        }
        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }
        public List<Employee> Employees => _employees; // we have to expose this list for EmployeeStatistics
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principle.dependency_inversion.example1.right
{
    public class EmployeeStatistics
    {
        private readonly IEmployeeSearchable _emp;
        public EmployeeStatistics(IEmployeeSearchable emp) // we now depend on abstraction
        {
            _emp = emp;
        }
        public int CountFemaleManagers() => //
        _emp.GetEmployeesByGenderAndPosition(Gender.Female, Position.Manager).Count();
    }
}

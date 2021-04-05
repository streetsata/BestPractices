using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolidPrincples.DIP
{
    public class EmployeeStatisticsRef
    {
        private readonly IEmployeeSearchable emp;
        public EmployeeStatisticsRef(IEmployeeSearchable emp)
        {
            this.emp = emp;
        }
        public int CountFemaleManagers() =>
            emp.GetEmployeesByGenderAndPosition(Gender.Female, Position.Manager).Count();
    }
}

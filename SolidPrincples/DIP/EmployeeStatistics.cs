using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolidPrincples.DIP
{
    public class EmployeeStatistics
    {
        private readonly EmployeeManager empManager;

        public EmployeeStatistics(EmployeeManager empManager)
        {
            this.empManager = empManager;
        }

        public int CountFemaleManagers() =>
            empManager.Employees.Count(emp => emp.Gender == Gender.Female && emp.Position == Position.Manager);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolidPrincples.DIP
{
    public class EmployeeManagerRef : IEmployeeSearchable
    {
        private readonly List<Employee> employees;
        public EmployeeManagerRef()
        {
            employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        public IEnumerable<Employee> GetEmployeesByGenderAndPosition(Gender gender, Position position)
            => employees.Where(emp => emp.Gender == gender && emp.Position == position);
    }
}

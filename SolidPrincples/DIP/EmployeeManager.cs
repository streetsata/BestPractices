using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrincples.DIP
{
    public class EmployeeManager
    {
        private readonly List<Employee> employees;
        public EmployeeManager()
        {
            this.employees = new List<Employee>();
        }
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public List<Employee> Employees => employees;
    }
}

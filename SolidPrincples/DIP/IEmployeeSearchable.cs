using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrincples.DIP
{
    public interface IEmployeeSearchable
    {
        IEnumerable<Employee> GetEmployeesByGenderAndPosition(Gender gender, Position position);
    }
}

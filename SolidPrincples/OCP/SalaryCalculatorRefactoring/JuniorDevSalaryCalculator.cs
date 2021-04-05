using SolidPrincples.OCP.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrincples.OCP.SalaryCalculatorRefactoring
{
    internal class JuniorDevSalaryCalculator : BaseSalaryCalculator
    {
        public JuniorDevSalaryCalculator(DeveloperReport developerReport)
            : base(developerReport)
        {

        }

        public override double CalculateSalary() =>
            DeveloperReport.HourlyRate * DeveloperReport.WorkingHours;

    }
}

using System.Collections.Generic;

namespace SolidPrincples.OCP.SalaryCalculatorRefactoring
{
    internal class SalaryCalculatorRefactor
    {
        private readonly IEnumerable<BaseSalaryCalculator> developerCalculation;

        public SalaryCalculatorRefactor(IEnumerable<BaseSalaryCalculator> developerCalculation)
        {
            this.developerCalculation = developerCalculation;
        }

        public double CalculateTotalSalaries()
        {
            double totalSalaries = 0D;

            foreach (var devCalc in developerCalculation)
            {
                totalSalaries += devCalc.CalculateSalary();
            }

            return totalSalaries;
        }
    }
}

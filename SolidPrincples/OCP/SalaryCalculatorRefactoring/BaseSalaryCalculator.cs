using SolidPrincples.OCP.Model;

namespace SolidPrincples.OCP.SalaryCalculatorRefactoring
{
    internal abstract class BaseSalaryCalculator
    {
        protected DeveloperReport DeveloperReport { get; private set; }

        protected BaseSalaryCalculator(DeveloperReport developerReport)
        {
            DeveloperReport = developerReport;
        }

        public abstract double CalculateSalary();
    }
}

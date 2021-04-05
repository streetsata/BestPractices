using SolidPrincples.OCP.Model;

namespace SolidPrincples.OCP.SalaryCalculatorRefactoring
{
    internal class SeniorDevSalaryCalculator : BaseSalaryCalculator
    {
        public SeniorDevSalaryCalculator(DeveloperReport developerReport)
            : base(developerReport)
        {

        }

        public override double CalculateSalary() =>
            DeveloperReport.HourlyRate * DeveloperReport.WorkingHours * 1.2;
    }
}

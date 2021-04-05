using SolidPrincples.OCP.Model;
using System.Collections.Generic;

namespace SolidPrincples.OCP.SalaryCalculator
{
    internal class SalaryCalculator
    {
        private readonly IEnumerable<DeveloperReport> developerReports;

        public SalaryCalculator(List<DeveloperReport> developerReports)
        {
            this.developerReports = developerReports;
        }

        public double CalculateTotalSalaries()
        {
            double totalSalaries = 0D;

            foreach (var devReport in developerReports)
            {
                if (devReport.Level == "Senior developer")
                {
                    totalSalaries += devReport.HourlyRate * devReport.WorkingHours * 1.2;
                }
                else
                {
                    totalSalaries += devReport.HourlyRate * devReport.WorkingHours;
                }

            }

            return totalSalaries;
        }
    }
}

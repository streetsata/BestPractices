using BestPractices.SolidPrinciples.Refactoring;
using SolidPrincples.DIP;
using SolidPrincples.LSP;
using SolidPrincples.OCP.Model;
using SolidPrincples.OCP.MonitorFiltering;
using SolidPrincples.OCP.SalaryCalculator;
using SolidPrincples.OCP.SalaryCalculatorRefactoring;
using System;
using System.Collections.Generic;

namespace BestPractices.SolidPrinciples
{
    internal class Program
    {
        protected Program() { }
        private static void Main(string[] args)
        {
            var line = string.Format($"\n{new string('=', 100)}\n");

            #region SRP
            var report = new SolidPrinciples.InitialProject.WorkReport();
            var reportRef = new SolidPrinciples.Refactoring.WorkReport();
            var scheduler = new SolidPrinciples.Refactoring.Scheduler();

            report.AddEntry(new SolidPrinciples.InitialProject.WorkReportEntry { ProjectCode = "123Ds", ProjectName = "Project1", SpentHours = 5 });
            report.AddEntry(new SolidPrinciples.InitialProject.WorkReportEntry { ProjectCode = "987Fc", ProjectName = "Project1", SpentHours = 2 });
            Console.WriteLine(report.ToString());
            Console.WriteLine(line);

            reportRef.AddEntry(new SolidPrinciples.Refactoring.WorkReportEntry { ProjectCode = "123Ds", ProjectName = "Project1", SpentHours = 5 });
            reportRef.AddEntry(new SolidPrinciples.Refactoring.WorkReportEntry { ProjectCode = "987Fc", ProjectName = "Project1", SpentHours = 2 });
            Console.WriteLine(reportRef.ToString());
            Console.WriteLine(line);

            scheduler.AddEntry(new SolidPrinciples.Refactoring.ScheduleTask { TaskId = 1, Content = "Do something now.", ExecuteOn = DateTime.Now.AddDays(5) });
            scheduler.AddEntry(new SolidPrinciples.Refactoring.ScheduleTask { TaskId = 2, Content = "Don't forget to...", ExecuteOn = DateTime.Now.AddDays(2) });
            Console.WriteLine(scheduler.ToString());
            Console.WriteLine(line);

            var saver = new FileSaver();
            saver.SaveToFile(@"Reports", "WorkReport.txt", reportRef);
            saver.SaveToFile(@"Schedulers", "Schedule.txt", scheduler);
            #endregion

            #region OCP
            // SalaryCalculator
            {
                var devReports = new List<DeveloperReport>
                {
                    new DeveloperReport {Id = 1, Name = "Dev1", Level = "Senior developer", HourlyRate  = 30.5, WorkingHours = 160 },
                    new DeveloperReport {Id = 2, Name = "Dev2", Level = "Junior developer", HourlyRate  = 20, WorkingHours = 150 },
                    new DeveloperReport {Id = 3, Name = "Dev3", Level = "Senior developer", HourlyRate  = 30.5, WorkingHours = 180 }
                };
                var calculator = new SalaryCalculator(devReports);
                Console.WriteLine($"Sum of all the developer salaries is {calculator.CalculateTotalSalaries()} dollars");
            }

            Console.WriteLine(line);

            // SalaryCalculatorRef
            {
                var devCalculations = new List<BaseSalaryCalculator>
                {
                    new SeniorDevSalaryCalculator(new DeveloperReport {Id = 1, Name = "Dev1", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 160 }),
                    new JuniorDevSalaryCalculator(new DeveloperReport {Id = 2, Name = "Dev2", Level = "Junior developer", HourlyRate = 20, WorkingHours = 150 }),
                    new SeniorDevSalaryCalculator(new DeveloperReport {Id = 3, Name = "Dev3", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 180 })
                };
                var calculator = new SalaryCalculatorRefactor(devCalculations);
                Console.WriteLine($"Sum of all the developer salaries is {calculator.CalculateTotalSalaries()} dollars");
            }

            Console.WriteLine(line);

            // MonitorFilter
            {
                var monitors = new List<ComputerMonitor>
                {
                    new ComputerMonitor { Name = "Samsung S345", Screen = Screen.CurvedScreen, Type = MonitorType.OLED },
                    new ComputerMonitor { Name = "Philips P532", Screen = Screen.WideScreen, Type = MonitorType.LCD },
                    new ComputerMonitor { Name = "LG L888", Screen = Screen.WideScreen, Type = MonitorType.LED },
                    new ComputerMonitor { Name = "Samsung S999", Screen = Screen.WideScreen, Type = MonitorType.OLED },
                    new ComputerMonitor { Name = "Dell D2J47", Screen = Screen.CurvedScreen, Type = MonitorType.LCD }
                };

                var filter = new MonitorFilter();
                var lcdMonitors = filter.FilterByType(monitors, MonitorType.LCD);

                Console.WriteLine("All LCD monitors");
                foreach (var monitor in lcdMonitors)
                {
                    Console.WriteLine($"Name: {monitor.Name}, Type: {monitor.Type}, Screen: {monitor.Screen}");
                }

                Console.WriteLine(line);

                var filterNew = new MonitorFilterNew();
                var lcdMonitorsNew = filterNew.Filter(monitors, new MonitorTypeSpecification(MonitorType.LCD));
                Console.WriteLine("All LCD monitors");
                foreach (var monitor in lcdMonitorsNew)
                {
                    Console.WriteLine($"Name: {monitor.Name}, Type: {monitor.Type}, Screen: {monitor.Screen}");
                }

                Console.WriteLine(line);

                Console.WriteLine("All WideScreen Monitors");
                var wideScreenMonitors = filterNew.Filter(monitors, new ScreenSpecification(Screen.WideScreen));
                foreach (var monitor in wideScreenMonitors)
                {
                    Console.WriteLine($"Name: {monitor.Name}, Type: {monitor.Type}, Screen: {monitor.Screen}");
                }
            }

            #endregion

            #region LSP
            {
                Console.WriteLine(line);
                
                var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };

                //SumCalculator sum = new SumCalculator(numbers);
                Calculator sum = new SumCalculator(numbers);
                Console.WriteLine($"The sum of all the numbers: {sum.Calculate()}");
                
                Console.WriteLine();
                
                //EvenNumbersSumCalculator evenSum = new EvenNumbersSumCalculator(numbers);
                Calculator evenSum = new EvenNumbersSumCalculator(numbers);
                Console.WriteLine($"The sum of all the even numbers: {evenSum.Calculate()}");

                // Problem
                //SumCalculator badEvenSum = new EvenNumbersSumCalculator(numbers);
                Calculator badEvenSum = new EvenNumbersSumCalculator(numbers);
                Console.WriteLine($"(Bad)The sum of all the even numbers: {badEvenSum.Calculate()}");
            }
            #endregion

            #region ISP
            #endregion

            #region DIP
            {
                var empManager = new EmployeeManagerRef();
                empManager.AddEmployee(new Employee { Name = "Leen", Gender = Gender.Female, Position = Position.Manager });
                empManager.AddEmployee(new Employee { Name = "Mike", Gender = Gender.Male, Position = Position.Administrator });
                var stats = new EmployeeStatisticsRef(empManager);
                Console.WriteLine($"Number of female managers in our company is: {stats.CountFemaleManagers()}");
            }
            #endregion
        }
    }
}

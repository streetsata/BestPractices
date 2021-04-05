using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BestPractices.SolidPrinciples.InitialProject
{
    internal class WorkReport
    {
        private readonly List<WorkReportEntry> entries;

        public WorkReport()
        {
            entries = new List<WorkReportEntry>();
        }

        public void AddEntry(WorkReportEntry entry) => entries.Add(entry);

        public void RemoveEntryAt(int index) => entries.RemoveAt(index);

        /* We can add even more features in this class,
         * like the Load or UploadToCloud methods because they are all related to our WorkReport,
         * but, just because we can doesn’t mean we have to do it.
         * 
         * Right now, there is one issue with the WorkReport class. 
         * 
         * It has more than one responsibility!
         * 
         * Its job is not only to keep track of our work report entries but to save the entire work report to a file.
         * This means that we are violating the SRP and our class has more than one reason to change in the future.
         * 
         * The first reason to change this class is if we want to modify the way we keep track of our entries.
         * But if we want to save a file in a different way, that is entirely a new reason to change our class.
         * And imagine what this class would look like if we added additional functionalities to it.
         * We would have so many unrelated code parts in a single class.
         */
        public void SaveToFile(string directoryPath, string fileName)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.WriteAllText(Path.Combine(directoryPath, fileName), ToString());
        }

        public void SaveToCloud(string uri, string fileName)
        {
            //if (!Directory.Exists(directoryPath))
            //{
            //    Directory.CreateDirectory(directoryPath);
            //}

            //File.WriteAllText(Path.Combine(directoryPath, fileName), ToString());
        }

        public override string ToString() =>
            string.Join(Environment.NewLine, entries.Select(p => $"Code: {p.ProjectCode}, Name: {p.ProjectName}, Hours: {p.SpentHours}"));
    }
}

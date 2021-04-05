using BestPractices.SolidPrinciples.Refactoring.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BestPractices.SolidPrinciples.Refactoring
{
    internal class WorkReport : IEntryManager<WorkReportEntry>
    {
        private readonly List<WorkReportEntry> entries;

        public WorkReport()
        {
            entries = new List<WorkReportEntry>();
        }

        public void AddEntry(WorkReportEntry entry) => entries.Add(entry);

        public void RemoveEntryAt(int index) => entries.RemoveAt(index);

        public override string ToString() =>
            string.Join(Environment.NewLine, entries.Select(p => $"Code: {p.ProjectCode}, Name: {p.ProjectName}, Hours: {p.SpentHours}"));
    }
}

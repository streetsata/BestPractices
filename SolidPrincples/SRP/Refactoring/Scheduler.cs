using BestPractices.SolidPrinciples.Refactoring.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BestPractices.SolidPrinciples.Refactoring
{
    internal class Scheduler : IEntryManager<ScheduleTask>
    {
        private readonly List<ScheduleTask> scheduleTasks;

        public Scheduler()
        {
            scheduleTasks = new List<ScheduleTask>();
        }

        public void AddEntry(ScheduleTask entry) => scheduleTasks.Add(entry);

        public void RemoveEntryAt(int index) => scheduleTasks.RemoveAt(index);

        public override string ToString() =>
            string.Join(Environment.NewLine, scheduleTasks.Select(t => $"Task with id: {t.TaskId} with content: {t.Content} is going to be executed on: {t.ExecuteOn}"));
    }
}

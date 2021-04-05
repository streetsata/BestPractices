using System;

namespace BestPractices.SolidPrinciples.Refactoring
{
    internal class ScheduleTask
    {
        public int TaskId { get; set; }
        public string Content { get; set; }
        public DateTime ExecuteOn { get; set; }
    }
}

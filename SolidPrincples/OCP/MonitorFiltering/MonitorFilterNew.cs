using SolidPrincples.OCP.Contracts;
using SolidPrincples.OCP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolidPrincples.OCP.MonitorFiltering
{
    internal class MonitorFilterNew : IFilter<ComputerMonitor>
    {
        public List<ComputerMonitor> Filter(IEnumerable<ComputerMonitor> monitors, ISpecification<ComputerMonitor> specification) =>
            monitors.Where(m => specification.isSatisfied(m)).ToList();

    }
}

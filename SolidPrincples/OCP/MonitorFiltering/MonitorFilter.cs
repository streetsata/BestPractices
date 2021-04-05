using SolidPrincples.OCP.Model;
using System.Collections.Generic;
using System.Linq;

namespace SolidPrincples.OCP.MonitorFiltering
{
    internal class MonitorFilter
    {
        public List<ComputerMonitor> FilterByType(IEnumerable<ComputerMonitor> monitors, MonitorType type) =>
            monitors.Where(m => m.Type == type).ToList();

        public List<ComputerMonitor> FilterByScreen(IEnumerable<ComputerMonitor> monitors, Screen screen) =>
            monitors.Where(m => m.Screen == screen).ToList();
    }
}

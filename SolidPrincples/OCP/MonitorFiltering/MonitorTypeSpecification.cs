using SolidPrincples.OCP.Contracts;
using SolidPrincples.OCP.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrincples.OCP.MonitorFiltering
{
    internal class MonitorTypeSpecification : ISpecification<ComputerMonitor>
    {
        private readonly MonitorType type;

        public MonitorTypeSpecification(MonitorType type)
        {
            this.type = type;
        }

        public bool isSatisfied(ComputerMonitor item) => item.Type == type;
    }
}

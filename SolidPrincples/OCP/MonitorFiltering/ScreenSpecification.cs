using SolidPrincples.OCP.Contracts;
using SolidPrincples.OCP.Model;

namespace SolidPrincples.OCP.MonitorFiltering
{
    internal class ScreenSpecification : ISpecification<ComputerMonitor>
    {
        private readonly Screen screen;
        public ScreenSpecification(Screen screen)
        {
            this.screen = screen;
        }
        public bool isSatisfied(ComputerMonitor item) => item.Screen == screen;
    }
}

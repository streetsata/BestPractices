using System.Collections.Generic;

namespace SolidPrincples.OCP.Contracts
{
    public interface IFilter<T>
    {
        List<T> Filter(IEnumerable<T> monitors, ISpecification<T> specification);
    }
}

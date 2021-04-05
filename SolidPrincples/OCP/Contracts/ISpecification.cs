namespace SolidPrincples.OCP.Contracts
{
    public interface ISpecification<in T>
    {
        bool isSatisfied(T item);
    }
}

namespace BestPractices.SolidPrinciples.Refactoring.Contracts
{
    internal interface IEntryManager<in T>
    {
        void AddEntry(T entry);
        void RemoveEntryAt(int index);
    }
}

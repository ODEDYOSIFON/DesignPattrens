namespace DesignPattrens.Behavioral.Strategy
{
    // Strategy Interface:
    // - Declares a common interface for all supported algorithms.
    // - Context (SortedList) uses this interface to call the algorithm.
    public interface ISortStrategy
    {
        void Sort(List<int> data);
    }
}

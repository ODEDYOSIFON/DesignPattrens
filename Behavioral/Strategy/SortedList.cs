namespace DesignPattrens.Behavioral.Strategy
{
    // Context:
    // - Maintains a reference to a strategy object.
    // - Calls the sorting algorithm defined by the current strategy.
    public class SortedList
    {
        private readonly ISortStrategy _sortStrategy;

        public SortedList(ISortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        // Delegates the sorting work to the chosen strategy.
        public void Sort(List<int> data)
        {
            _sortStrategy.Sort(data);
        }
    }
}

namespace DesignPattrens.Behavioral.Strategy
{
    // Concrete Strategy:
    // - Implements the ISortStrategy interface.
    // - Provides a quick sort implementation.
    public class QuickSortStrategy : ISortStrategy
    {
        public void Sort(List<int> data)
        {
            Console.WriteLine("Sorting using quick sort");
            // Quick sort algorithm could be implemented here.
        }
    }
}

namespace DesignPattrens.Behavioral.Strategy
{
    // Concrete Strategy:
    // - Implements the ISortStrategy interface.
    // - Provides a bubble sort implementation.
    public class BubbleSortStrategy : ISortStrategy
    {
        public void Sort(List<int> data)
        {
            Console.WriteLine("Sorting using bubble sort");
            // Bubble sort algorithm could be implemented here.
        }
    }
}

namespace StrategyPattern.SecondExample;

public class BubbleSort<T> : SortStrategy<T>
    where T : IComparable<T>
{
    public override void Sort(List<T> list)
    {
        list.Sort();
        Console.WriteLine("BubbleSorted list ");
    }
}
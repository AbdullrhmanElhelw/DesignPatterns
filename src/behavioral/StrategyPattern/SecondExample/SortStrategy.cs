namespace StrategyPattern.SecondExample;

public abstract class SortStrategy<T>
 where T : IComparable<T>
{
    public abstract void Sort(List<T> list);
}
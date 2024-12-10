namespace StrategyPattern.SecondExample;

public class SortContext<T>
    where T : IComparable<T>
{
    private readonly SortStrategy<T> _sortStrategy;

    public SortContext(SortStrategy<T> sortStrategy)
    {
        _sortStrategy = sortStrategy;
    }

    public void Sort(List<T> list) =>
        _sortStrategy.Sort(list);
}
namespace BuilderPattern;

public interface IBuilder<out T> where T : class
{
    public T Build();
}
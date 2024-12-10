namespace DecoratorPattern;

public class Handler : IHandler
{
    public virtual void Handle()
    {
        Console.WriteLine("Handler");
    }
}
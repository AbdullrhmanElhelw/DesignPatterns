using DecoratorPattern;

public class ChachingDecorator : HandlerDecorator
{
    public ChachingDecorator(IHandler handler) : base(handler)
    {
    }

    public override void Handle()
    {
        Console.WriteLine("Chaching");
        base.Handle();
    }
}
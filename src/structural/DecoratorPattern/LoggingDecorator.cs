using DecoratorPattern;

public class LoggingDecorator : HandlerDecorator
{
    public LoggingDecorator(IHandler handler) : base(handler)
    {
    }

    public override void Handle()
    {
        Console.WriteLine("Logging");
        base.Handle();
    }
}
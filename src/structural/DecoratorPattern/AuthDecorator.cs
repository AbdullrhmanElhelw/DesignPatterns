using DecoratorPattern;

public class AuthDecorator : HandlerDecorator
{
    public AuthDecorator(IHandler handler) : base(handler)
    {
    }

    public override void Handle()
    {
        Console.WriteLine("Auth");
        base.Handle();
    }
}
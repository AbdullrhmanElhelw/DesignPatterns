namespace Factory;

public class Circle : IShape
{
    public string Draw()
    {
        return "We Will Draw " + typeof(Circle);
    }
}
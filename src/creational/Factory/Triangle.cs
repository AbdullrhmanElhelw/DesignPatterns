namespace Factory;

public class Triangle : IShape
{
    public string Draw()
    {
        return "We Will Draw " + typeof(Triangle);
    }
}
namespace Factory;

public class Square : IDimension
{
    public string GetDimension()
    {
        return "The Shape With " + typeof(Square) + "Dimension";
    }
}
namespace Factory;

public abstract class Program
{
    private static void Main(string[] args)
    {
        var circle = new ShapeFactory().GetShape(Shapes.Circle);
        var dimension = new ShapeFactory().GetDimension(Dimensions.Circular);

        Console.WriteLine(circle.Draw());
        Console.WriteLine(dimension.GetDimension());
    }
}
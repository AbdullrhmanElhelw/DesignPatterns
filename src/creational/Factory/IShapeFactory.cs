namespace Factory;

public interface IShapeFactory
{
    IShape GetShape(Shapes shapes);

    IDimension GetDimension(Dimensions dimensions);
}
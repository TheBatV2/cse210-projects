public class Circle : Shapes
{
    private double _radius;

    public Circle(string color, double radius) : base (color)
    {
        _radius = radius;
    }

    public override double getArea()
    {
        return _radius * _radius * Math.PI;
    }
}
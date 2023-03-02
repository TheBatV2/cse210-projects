public class Square : Shapes
{
    private double _edge;

    public Square(string color, double edge) : base (color)
    {
        _edge = edge;
    }

    public override double getArea()
    {
        return _edge * _edge;
    }
}
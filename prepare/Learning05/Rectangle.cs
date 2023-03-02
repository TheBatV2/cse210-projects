class Rectangle : Shapes
{
    private double _length;
    private double _height;

    public Rectangle(string color, double length, double height) : base (color)
    {
        _length = length;
        _height = height;
    }

    public override double getArea()
    {
        return _length * _height;
    }
}
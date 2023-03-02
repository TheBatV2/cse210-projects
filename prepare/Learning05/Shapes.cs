public abstract class Shapes
{
    private string _color;

    public Shapes(string color)
    {
        _color = color;
    }
    public string getColor()
    {
        return _color;
    }

    public void setColor(string color) 
    {
        _color = color;
    }

    public abstract double getArea();   

}
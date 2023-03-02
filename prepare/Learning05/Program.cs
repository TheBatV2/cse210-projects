using System;

class Program
{
    static void Main(string[] args)
    {
        //creates a list to house all shapes
        List<Shapes> shapes = new List<Shapes>();

        //Gives perameters for all shapes here and adds them to list
        Square ss = new Square("Orange", 7);
        shapes.Add(ss);

        Circle sc = new Circle("Purple", 3.2);
        shapes.Add(sc);

        Rectangle sr = new Rectangle("Yellow", 3, 4.5);
        shapes.Add(sr);

        //uses a foreach loop to call each function and display each shape
        foreach (Shapes s in shapes)
        {
            string color = s.getColor();

            double area = s.getArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }

    }
}
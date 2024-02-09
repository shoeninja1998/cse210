using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new();

        Square square = new(4.5, "Blue");
            shapes.Add(square);
        Rectangle rectangle = new(3.6, 5.1, "Red");
            shapes.Add(rectangle);
        Circle circle = new(6, "Yellow");
            shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.Color;
            double area = shape.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}
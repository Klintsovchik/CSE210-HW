using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("red", 3f));
        shapes.Add(new Rectangle("blue", 5f, 3f));
        shapes.Add(new Circle("black", 5.6f));

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            float area = shape.GetArea();

            System.Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    } 
}
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        Square square = new Square("Blue", 5);
        Rectangle rectangle = new Rectangle("Green", 4, 6);
        Circle circle = new Circle("Red", 3);

        
        Console.WriteLine("Testing Single Shapes:");
        Console.WriteLine($"{square.GetColor()} Square Area: {square.GetArea()}");
        Console.WriteLine($"{rectangle.GetColor()} Rectangle Area: {rectangle.GetArea()}");
        Console.WriteLine($"{circle.GetColor()} Circle Area: {circle.GetArea()}");
        Console.WriteLine();

        
        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        Console.WriteLine("Polymorphism in Action:");
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"{shape.GetColor()} Shape Area: {shape.GetArea()}");
        }
    }
}

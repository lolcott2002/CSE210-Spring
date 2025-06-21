using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square shapenumber1 = new Square("violet", 3);
        shapes.Add(shapenumber1);

        Rectangle shapenumber2 = new Rectangle("indigo", 4, 5);
        shapes.Add(shapenumber2);

        Circle shapenumber3 = new Circle("teal", 6);
        shapes.Add(shapenumber3);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"this {color} colored shape has an area of {area} units squared.");
        }
    }
}
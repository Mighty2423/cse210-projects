using System;

class Program 
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Squares s1 = new Squares(5, "red");
        shapes.Add(s1);

        Circles c1 = new Circles(3, "blue");
        shapes.Add(c1);

        Rectangle r1 = new Rectangle(4, 6, "green");
        shapes.Add(r1);

        Pentagon p1 = new Pentagon(5, 6, "yellow");
        shapes.Add(p1);

        Trapazoid t1 = new Trapazoid(5, 6, 7, 8, 9, "orange");
        shapes.Add(t1);

        Triangle tr1 = new Triangle(5, 6, 7, "purple");
        shapes.Add(tr1);

        
    foreach (Shape s in shapes)
        {
            // Notice that all shapes have a GetColor method from the base class
            string color = s.GetColor();

    // Notice that all shapes have a GetArea method, but the behavior is
    // different for each type of shape
    double area = s.GetArea();

    Console.WriteLine($"The {color} shape has an area of {area}.");
        }

        // 3D SHAPESS  VERSION

    }

}



public class Triangle : Shape
{
    private double side1;
    private double side2;
    private double side3;
    private string color;

    public Triangle(double side1, double side2, double side3, string color) : base(color)
    {
        this.side1 = side1;
        this.side2 = side2;
        this.side3 = side3;
    }
    public override double GetArea()
    {
        return 0.5 * (side1 + side2 + side3);
    }
}
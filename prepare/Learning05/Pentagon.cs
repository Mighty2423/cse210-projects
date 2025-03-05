public class Pentagon : Shape
{
    private double _side;
    private double _height;

    public Pentagon(double side, double height, string color) : base(color)
    {
        _side = side;
        _height = height;
    }

    public override double GetArea()
    {
        return 1.720477400588967 * _side * _side;
    }
}

public class Trapazoid : Shape
{
    private double _base1;
    private double _base2;
    private double _height;
    private double _side1;
    private double _side2;

    public Trapazoid(double base1, double base2, double height, double side1, double side2, string color) : base(color)
    {
        _base1 = base1;
        _base2 = base2;
        _height = height;
        _side1 = side1;
        _side2 = side2;
    }

    public override double GetArea()
    {
        return (_base1 + _base2) * _height / 2;
    }
}
public class Squares : Shape
{
    private double _side;

    public Squares(double side, string color) : base(color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}
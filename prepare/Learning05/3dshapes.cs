

public class Shapes3D : Shape
{
    private double _length;
    private double _width;
    private double _height;

    public Shapes3D(double length, double width, double height, string color) : base(color)
    {
        _length = length;
        _width = width;
        _height = height;
    }

    public override double GetArea()
    {
        return 2 * (_length * _width + _length * _height + _width * _height);
    }
}
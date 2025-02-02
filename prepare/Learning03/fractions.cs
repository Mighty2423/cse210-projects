using System ;

public class Fraction
{
    private int _topn;
    private int _bottomn;
    
    public Fraction()
    {
    _topn = 1;
    _bottomn = 1;
    }

    public Fraction(int wholenumber)
    {
    _topn = wholenumber;
    _bottomn = 1;
    }

    public Fraction(int top , int bottom)
    {
    _topn = top;
    _bottomn = bottom;
    }

    public string GetFractString()
    {
    return $"{_topn} / {_bottomn}";
    }

    public double GetDecValue()
    {
    return (double)_topn / (double)_bottomn;
    }
}
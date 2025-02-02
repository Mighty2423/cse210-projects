using System;

public class multiplication
{
    private int _frontn;
    private int _backn;

    public multiplication()
    {
        _frontn = 1;
        _backn = 1;
    }

    public multiplication(int wholenumber)
    {
        _frontn = wholenumber;
        _backn = 1;
    }

    public multiplication(int front, int back)
    {
        _frontn = front;
        _backn = back;
    }

    public string GetmultString()
    {
        return $"{_frontn} * {_backn}";

    }

    public int Getmultvalue()
    {
        return _frontn * _backn;
    }
    
}
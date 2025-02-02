using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Security.AccessControl;

public class subtraction
{
    private int _frontn;
    private int _backn;

    public subtraction()
    {
        _frontn = 1;
        _backn = 1;
    }

    public subtraction(int wholenumber)
    {
        _frontn = wholenumber;
        _backn = 1;
    }

    public subtraction(int front, int back)
    {
        _frontn = front;
        _backn = back;
    }

    public string GetsubString()
    {
        return $"{_frontn} - {_backn}";

    }

    public int Getlessvalue()
    {
        return _frontn - _backn;
    }
}    
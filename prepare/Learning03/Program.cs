using System;

class Program
{
    static void Main(string[] args)
    {
    
        //trying out as a fraction class
        Console.WriteLine("Fraction class");
    Fraction start1 = new Fraction();
        Console.WriteLine (start1.GetFractString());
        Console.WriteLine (start1.GetDecValue());
            
        Fraction start2 = new Fraction(5);
        Console.WriteLine (start2.GetFractString());
        Console.WriteLine (start2.GetDecValue());

        Fraction start3 = new Fraction(3,4);
        Console.WriteLine (start3.GetFractString());
        Console.WriteLine (start3.GetDecValue());

        Fraction start4 = new Fraction(1,3);
        Console.WriteLine (start4.GetFractString());
        Console.WriteLine (start4.GetDecValue());


        //trying out as an addition class
        Console.WriteLine("Addition class");
        addition start5 = new addition();
        Console.WriteLine (start5.GetaddString());
        Console.WriteLine (start5.Gettotvalue());

        addition start6 = new addition(5);
        Console.WriteLine (start6.GetaddString());
        Console.WriteLine (start6.Gettotvalue());

        addition start7 = new addition(3,4);
        Console.WriteLine (start7.GetaddString());
        Console.WriteLine (start7.Gettotvalue());

        addition start8 = new addition(1,3);
        Console.WriteLine (start8.GetaddString());
        Console.WriteLine (start8.Gettotvalue());

        //trying out as a subtraction class
        Console.WriteLine("Subtraction class");
        subtraction start9 = new subtraction();
        Console.WriteLine (start9.GetsubString());
        Console.WriteLine (start9.Getlessvalue());

        subtraction start10 = new subtraction(5);
        Console.WriteLine (start10.GetsubString());
        Console.WriteLine (start10.Getlessvalue());

        subtraction start11 = new subtraction(3,4);
        Console.WriteLine (start11.GetsubString());
        Console.WriteLine (start11.Getlessvalue());

        subtraction start12 = new subtraction(1,3);
        Console.WriteLine (start12.GetsubString());
        Console.WriteLine (start12.Getlessvalue());

        //trying out as a multiplication class
        Console.WriteLine("Multiplication class");
        multiplication start13 = new multiplication();
        Console.WriteLine (start13.GetmultString());
        Console.WriteLine (start13.Getmultvalue());

        multiplication start14 = new multiplication(5);
        Console.WriteLine (start14.GetmultString());
        Console.WriteLine (start14.Getmultvalue());

        multiplication start15 = new multiplication(3,4);
        Console.WriteLine (start15.GetmultString());
        Console.WriteLine (start15.Getmultvalue());

        multiplication start16 = new multiplication(1,3);
        Console.WriteLine (start16.GetmultString());
        Console.WriteLine (start16.Getmultvalue());


    }
}
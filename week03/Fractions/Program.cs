using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Fraction f = new Fraction();
        Console.WriteLine(f);

        Fraction d = new Fraction(5);
        Console.WriteLine(d);

        Fraction s =new Fraction(6, 7);
        Console.WriteLine(s);

        f.Top = 10;
        f.Bottom = 12;
        Console.WriteLine(f.Top);
        Console.WriteLine(f.Bottom);
        Console.WriteLine(f.GetFractionString());
        Console.WriteLine(f.GetDecimalValue());
    }
}
using System;

class Program
{
    static void Main()
    {
        int a = 10;
        int b = 20;

        double c = (a + b) / 2.0;
        c = c - 40;

        double[] v = new double[4];

        v[3] = a + b + c;

        Console.WriteLine("A = " + a);
        Console.WriteLine("B = " + b);
        Console.WriteLine("C = " + c);
        Console.WriteLine("V[3] = " + v[3]);
    }
}
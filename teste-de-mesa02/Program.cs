using System;

class Program
{
    static void Main()
    {
        int a = 2;
        int[] v = new int[7];

            while (a < 6)
            {
                v[a] = 10 * a;
                a = a + 1;
            }

        for (int i = 0; i < v.Length; i++)
        {
            Console.WriteLine($"v[{i}] = {v[i]}");
        }
    }
}

using System;
    class Program
    {
        static void Main()
        {
            int a = 7;
            int b = a - 6;

        int[] v = new int[7];

        while (b < a)
        {
            v[b] = b + a;
            b = b + 2;
        }

        for (int i = 0; i < v.Length; i++)
        {
            Console.WriteLine($"v[{i}] = {v[i]}");
        }
    }
}


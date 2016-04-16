using System;

class LiveDemo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int multiplier = 1;

        while (multiplier <= n)
        {
            Console.WriteLine(multiplier);
            multiplier = multiplier * 2 + 1;
        }

    }
}
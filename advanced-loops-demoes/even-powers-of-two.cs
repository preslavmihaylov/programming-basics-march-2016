using System;

class LiveDemo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int multiplier = 1;

        for (int power = 0; power <= n; power += 2)
        {
            Console.WriteLine(multiplier);
            multiplier *= 4;
        }

    }
}
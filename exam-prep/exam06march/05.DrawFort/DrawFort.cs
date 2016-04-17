using System;

class DrawFort
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int cols = 2 * n;
        int baseMetric = n / 2;

        Console.WriteLine("/{0}\\{1}/{0}\\",
            new string('^', baseMetric),
            new string('_', 2 * n - (baseMetric * 2 + 4)));

        for (int cnt = 0; cnt < n - 2; cnt++)
        {
            char middlePart = ' ';
            if (cnt == n - 3)
            {
                middlePart = '_';
            }

            Console.WriteLine("|{0}{1}{0}|",
                new string(' ', baseMetric + 1),
                new string(middlePart, 2 * n - (baseMetric * 2 + 4)));
        }

        Console.WriteLine("\\{0}/{1}\\{0}/",
            new string('_', baseMetric),
            new string(' ', 2 * n - (baseMetric * 2 + 4)));
    }
}
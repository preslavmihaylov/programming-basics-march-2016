using System;

class LiveDemo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int row = 0; row < n + 1; row++)
        {
            Console.Write(new string(' ', n - row));
            Console.Write(new string('*', row));
            Console.Write(" | ");
            Console.Write(new string('*', row));
            Console.Write(new string(' ', n - row));
            Console.WriteLine();
        }
    }
}
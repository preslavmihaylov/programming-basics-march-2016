using System;

class LiveDemo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int row = 1; row <= n; row++)
        {
            Console.Write(new string(' ', n - row));
            for (int col = 0; col < row; col++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

        for (int row = n - 2; row >= 0; row--)
        {
            Console.Write(new string(' ', n - row - 1));
            for (int col = 0; col <= row; col++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}
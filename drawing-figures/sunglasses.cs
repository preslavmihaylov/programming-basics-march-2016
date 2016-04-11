using System;

class LiveDemo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int middle = n / 2;
        if (n % 2 == 0)
        {
            middle--;
        }

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < 5 * n; col++)
            {
                if (col >= 2 * n && col < 3 * n)
                {
                    if (row == middle)
                    {
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                else
                {
                    if ((row == 0 || row == n - 1) ||
                        (col == 0 || col == 2 * n - 1) ||
                        (col == 3 * n || col == ((5 * n) - 1)))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("/");
                    }
                    
                }
            }
            Console.WriteLine();
        }
    }
}
using System;

class TrainingHall
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                int value = row + col + 1;
                if (col > (n - row - 1))
                {
                    value = 2 * n - value;
                }
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }
}
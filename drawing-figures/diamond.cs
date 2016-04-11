using System;

class LiveDemo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int left = n / 2;
        int right = left;
        if (n % 2 == 0)
        {
            left--;
        }

        while (left >= 0)
        {
            for (int col = 0; col < n; col++)
            {
                if (col == left || col == right)
                {
                    Console.Write("*");
                }
                else
                {

                    Console.Write("-");
                }               
            }
            left--;
            right++;

            Console.WriteLine();
        }

        left = 1;
        right = n - 2;

        while (left <= right)
        {
            for (int col = 0; col < n; col++)
            {
                if (col == left || col == right)
                {
                    Console.Write("*");
                }
                else
                {

                    Console.Write("-");
                }
            }
            left++;
            right--;

            Console.WriteLine();
        }
    }
}
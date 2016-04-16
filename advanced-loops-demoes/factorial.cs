using System;

class LiveDemo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());


        int factorial = 1;
        for (int cnt = 1; cnt <= n; cnt++)
        {
            factorial *= cnt;
        }

        Console.WriteLine(factorial);
    }
}
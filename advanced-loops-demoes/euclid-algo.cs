using System;

class LiveDemo
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        while (b != 0)
        {
            int result = a % b;
            a = b;
            b = result;
        }

        Console.WriteLine(a);

    }
}
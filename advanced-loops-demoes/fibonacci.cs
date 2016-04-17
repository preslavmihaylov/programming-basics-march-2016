using System;

class TrainingHall
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int firstFib = 1;
        int secondFib = 1;

        for (int cnt = 2; cnt <= n; cnt++)
        {
            int result = firstFib + secondFib;
            firstFib = secondFib;
            secondFib = result;
        }

        Console.WriteLine(secondFib);
    }
}
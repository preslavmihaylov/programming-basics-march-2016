using System;

class LiveDemo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        bool isPrime = true;

        if (n < 2)
        {
            isPrime = false;
        }

        double sqrt = Math.Sqrt(n);

        for (int cnt = 2; cnt <= sqrt; cnt++)
        {
            if (n % cnt == 0)
            {
                isPrime = false;
                break;
            }
        }


        if (isPrime)
        {
            Console.WriteLine("Prime");
        }
        else
        {
            Console.WriteLine("Not Prime");

        }
    }
}
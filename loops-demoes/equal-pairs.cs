using System;

class LiveDemo
{
    static void Main()
    {
        int numbersCount = int.Parse(Console.ReadLine());

        int lastSum = 0;
        int maxDiff = 0;


        for (int cnt = 0; cnt < numbersCount; cnt++)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            int sum = first + second;

            if (cnt > 0)
            {
                int diff = Math.Abs(sum - lastSum);
                if (diff > maxDiff)
                {
                    maxDiff = diff;
                }
            }

            lastSum = sum;
            
        }

        if (maxDiff == 0)
        {
            Console.WriteLine("Yes, value={0}", lastSum);
        }
        else
        {
            Console.WriteLine("No, maxdiff={0}", maxDiff);
        }
    }
}
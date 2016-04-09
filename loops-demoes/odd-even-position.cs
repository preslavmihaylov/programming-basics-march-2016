using System;

class LiveDemo
{
    static void Main()
    {
        int numbersCount = int.Parse(Console.ReadLine());

        double oddMax = int.MinValue;
        double oddMin = int.MaxValue;
        double oddSum = 0;

        double evenMax = int.MinValue;
        double evenMin = int.MaxValue;
        double evenSum = 0;

        for (int cnt = 1; cnt <= numbersCount; cnt++)
        {
            double number = double.Parse(Console.ReadLine());

            if (cnt % 2 == 0)
            {
                evenSum += number;

                if (number > evenMax)
                {
                    evenMax = number;
                }

                if (number < evenMin)
                {
                    evenMin = number;
                }
            }
            else
            {
                oddSum += number;

                if (number > oddMax)
                {
                    oddMax = number;
                }

                if (number < oddMin)
                {
                    oddMin = number;
                }
            }
        }

        Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}",
            oddSum,
            oddMin,
            oddMax,
            evenSum,
            evenMin,
            evenMax);   
    }
}
 
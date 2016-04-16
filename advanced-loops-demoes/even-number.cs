using System;

class LiveDemo
{
    static void Main()
    {
        int n;
        while (true)
        {
            try
            {                
                n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Odd number");
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number");
            }
        }


        Console.WriteLine("Even number entered: {0}", n);
    }
}
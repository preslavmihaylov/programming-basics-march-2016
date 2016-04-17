using System;

class StupidPasswordGenerator
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int l = int.Parse(Console.ReadLine());

        for (int digit1 = 1; digit1 <= n; digit1++)
        {
            for (int digit2 = 1; digit2 <= n; digit2++)
            {
                for (int letter1 = 0; letter1 < l; letter1++)
                {
                    for (int letter2 = 0; letter2 < l; letter2++)
                    {
                        for (int digit3 = (Math.Max(digit1, digit2) + 1); digit3 <= n; digit3++)
                        {
                            Console.Write("" + 
                                digit1 + 
                                digit2 + 
                                (char)(letter1 + 'a') + 
                                (char)(letter2 + 'a') + 
                                digit3 + " ");
                        }

                    }
                }
            }
        }

        Console.WriteLine();
    }
}
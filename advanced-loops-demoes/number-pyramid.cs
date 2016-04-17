using System;

class TrainingHall
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int cnt = 1;

        for (int row = 0; cnt <= n; row++)
        {
            for (int col = 0; col <= row && cnt <= n; col++)
            {
                Console.Write("{0} ", cnt);
                cnt++;
            }
            Console.WriteLine();
        }
    }
}
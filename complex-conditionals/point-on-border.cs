using System;

class LiveDemo
{
    static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());


        bool isOnLeftSide = (x == x1) && (y >= y1 && y <= y2);
        bool isOnRightSide = (x == x2) && (y >= y1 && y <= y2);
        bool isOnTopSide = (y == y1) && (x >= x1 && x <= x2);
        bool isOnBotSide = (y == y2) && (x >= x1 && x <= x2);

        if (isOnLeftSide || isOnRightSide || isOnTopSide || isOnBotSide)
        {
            Console.WriteLine("Border");
        }
        else
        {
            Console.WriteLine("Inside / Outside");
        }
    }
}
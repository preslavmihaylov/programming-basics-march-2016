using System;

class LiveDemo
{
    static void Main()
    {
        double h = double.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        double firstRectX1 = 0;
        double firstRectY1 = 0;
        double firstRectX2 = 3 * h;
        double firstRectY2 = h;
        double secondRectX1 = h;
        double secondRectY1 = h;
        double secondRectX2 = 2 * h;
        double secondRectY2 = 4 * h;

        bool isOnFirstRectBorder = ((x == firstRectX1) && (y >= firstRectY1 && y <= firstRectY2)) ||
                          ((x == firstRectX2) && (y >= firstRectY1 && y <= firstRectY2)) ||
                          ((y == firstRectY1) && (x >= firstRectX1 && x <= firstRectX2)) ||
                          ((y == firstRectY2) && (x >= firstRectX1 && x <= firstRectX2));

        bool isOnSecondRectBorder = ((x == secondRectX1) && (y >= secondRectY1 && y <= secondRectY2)) ||
                          ((x == secondRectX2) && (y >= secondRectY1 && y <= secondRectY2)) ||
                          ((y == secondRectY1) && (x >= secondRectX1 && x <= secondRectX2)) ||
                          ((y == secondRectY2) && (x >= secondRectX1 && x <= secondRectX2));

        bool isWithinFirstRect = x >= firstRectX1 && x <= firstRectX2 && y >= firstRectY1 && y <= firstRectY2;
        bool isWithinSecondRect = x >= secondRectX1 && x <= secondRectX2 && y >= secondRectY1 && y <= secondRectY2;
        

        if ((isOnFirstRectBorder ^ isOnSecondRectBorder) ||
            (x == h && y == h) || (x == 2 * h && y == h))
        {
            Console.WriteLine("border");
        }
        else if (isWithinFirstRect || isWithinSecondRect)
        {
            Console.WriteLine("inside");
        }
        else
        {
            Console.WriteLine("outside");
        }

    }
}
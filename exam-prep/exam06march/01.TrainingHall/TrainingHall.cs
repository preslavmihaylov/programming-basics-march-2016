using System;

class TrainingHall
{
    static void Main()
    {
        double w = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());

        double widthInCm = h * 100;
        double heightInCm = w * 100;
        widthInCm -= 100;

        int cols = (int)(widthInCm / 70);
        int rows = (int)(heightInCm / 120);
        int totalPlaces = rows * cols - 3;

        Console.WriteLine(totalPlaces);

    }
}
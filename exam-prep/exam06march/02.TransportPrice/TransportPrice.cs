using System;

class TransportPrice
{
    static void Main()
    {
        int km = int.Parse(Console.ReadLine());
        string timeOfDay = Console.ReadLine();

        double startTaxiPrice = 0.7;
        double taxiPrice = 0;
        double busPrice = int.MaxValue;
        double trainPrice = int.MaxValue;

        if (timeOfDay == "day")
        {
            taxiPrice = startTaxiPrice + (km * 0.79);
        }
        else
        {
            taxiPrice = startTaxiPrice + (km * 0.9);
        }

        if (km >= 20)
        {
            busPrice = 0.09 * km;
        }

        if (km >= 100)
        {
            trainPrice = 0.06 * km;
        }
        
        Console.WriteLine(Math.Min(Math.Min(taxiPrice, busPrice), trainPrice));
    }
}
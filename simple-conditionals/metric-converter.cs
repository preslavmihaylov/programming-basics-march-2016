using System;

class LiveDemo
{
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        string sourceMetric = Console.ReadLine();
        string destMetric = Console.ReadLine();

        double baseMetricValue = number;
        double coefficient = GetCoefficient(sourceMetric);
        baseMetricValue = baseMetricValue / coefficient;

        coefficient = GetCoefficient(destMetric);
        baseMetricValue = baseMetricValue * coefficient;

        Console.Write(baseMetricValue);
        Console.WriteLine(" " + destMetric);
    }

    static double GetCoefficient(string metric)
    {
        double result = 0;

        if (metric == "m")
        {
            result = 1;
        }
        else if (metric == "mm")
        {
            result = 1000;
        }
        else if (metric == "cm")
        {
            result = 100;
        }
        else if (metric == "mi")
        {
            result = 0.000621371192;
        }
        else if (metric == "in")
        {
            result = 39.3700787;
        }
        else if (metric == "km")
        {
            result = 0.001;
        }
        else if (metric == "ft")
        {
            result = 3.2808399;
        }
        else if (metric == "yd")
        {
            result = 1.0936133;
        }

        return result;
    }
}
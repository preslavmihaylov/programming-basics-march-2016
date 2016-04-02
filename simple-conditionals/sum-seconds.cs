using System;

class LiveDemo
{
    static void Main()
    {
        uint num1 = uint.Parse(Console.ReadLine());
        uint num2 = uint.Parse(Console.ReadLine());
        uint num3 = uint.Parse(Console.ReadLine());

        uint seconds = num1 + num2 + num3;
        uint mins = seconds / 60;
        seconds = seconds % 60;

        Console.WriteLine("{0}:{1}", mins, seconds.ToString().PadLeft(2, '0'));

    }
}
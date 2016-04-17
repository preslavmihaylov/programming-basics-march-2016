using System;

class OnTimeForTheExam
{
    static void Main()
    {
        int examHour = int.Parse(Console.ReadLine());
        int examMin = int.Parse(Console.ReadLine());
        int studentHour = int.Parse(Console.ReadLine());
        int studentMin = int.Parse(Console.ReadLine());

        int examTotalMins = examHour * 60 + examMin;
        int studentTotalMins = studentHour * 60 + studentMin;

        int diff = studentTotalMins - examTotalMins;
        string stringParam = "before";
        string minsOrHours = "minutes";
        string time;

        if (diff > 0)
        {
            Console.WriteLine("Late");
            stringParam = "after";
        }
        else if (diff >= -30 && diff <= 0)
        {
            Console.WriteLine("On time");
        }
        else
        {
            Console.WriteLine("Early");
        }

        int resultHours = Math.Abs(diff) / 60;
        int resultMins = Math.Abs(diff) % 60;

        if (resultHours > 0)
        {
            minsOrHours = "hours";
            time = string.Format("{0}:{1}", 
                resultHours, 
                resultMins.ToString().PadLeft(2, '0'));
        }
        else
        {
            time = resultMins.ToString();
        }

        Console.WriteLine("{0} {1} {2} the start", time, minsOrHours, stringParam);
        
    }
}
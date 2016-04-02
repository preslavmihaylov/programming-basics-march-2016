using System;

class BonusPoints
{
	static void Main()
	{
		int number = int.Parse(Console.ReadLine());
		double points = 0;
		
		if (number <= 100) 
		{
			points += 5;
		}
		else if (number > 1000)
		{
			points += number * 0.1;
		}
		else if (number > 100) 
		{
			points += number * 0.2;
		}
		
		// Is number even?
		if (number % 2 == 0) 
		{
			points += 5;
		}
		
		// Does the number end with a 5?
		if (number % 10 == 5) 
		{
			points += 2;
		}
		
		Console.WriteLine(points);
		Console.WriteLine(points + number);
		
	}
}
using System;
using System.Collections.Generic;


public class Program
{
	
	
	 private static bool isPrime(int i)
    {	bool flag = false;
	 	double k = i/2;
	 	for(int n=2; n <= Math.Round(k); n++)
		{
			if(i%n == 0)
			{
				return flag = true;
			}
			
		}
        return flag;
    }
	
	
	public static void Main()
	{
		Console.WriteLine(" Enter a number to see the magic of prime");
        int userNumber = int.Parse(Console.ReadLine());
		int prNumber = 2;
		
		List<int> data = new List<int>();
		
		for (int i=prNumber; i <= userNumber; i++)
		{
			if(!isPrime(i))
				data.Add(i);
			
		}
		
		
		Console.WriteLine("-----------------");
		data.ForEach(Console.WriteLine);
	}
}
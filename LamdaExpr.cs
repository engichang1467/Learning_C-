using System;
using System.Text;
using System.Collections.Generic;

namespace myApp
{
    class Animal
    {
        static void Main(string[] args)
        {
        	// Lamda Expression
        	Func<int, int, int> getSum = (x,y) => x + y;

        	Console.WriteLine("5 + 3 = " + getSum.Invoke(5,3));

        	//list
        	List<int> numList = new List<int> {5,10,15,20,25};

        	List<int> oddNums = numList.Where(n => n % 2 == 1).ToList(); // Fix this this doesn't work

        	foreach(int num in oddNums)
        	{
        		Console.WriteLine(num + ","); 
        	}
        }
    }
}
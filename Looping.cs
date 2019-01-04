using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
        	// Looping
        	int i = 0;

        	while(i < 10)
        	{
        		if (i == 7)
        		{
        			i++;
        			continue;
        		}

        		if (i == 9)
        		{
        			break;
        		}

        		if((i % 2) > 0)
        		{
        			Console.WriteLine(i);
        		}
        		i++;
        	}

        	// do while
        	string guess;

        	do 
        	{
        		Console.WriteLine("Guess a Number");
        		guess = Console.ReadLine();

        	} while(!guess.Equals("15"));

        	// for loop
        	for (int j = 0; j < 10; j++)
        	{
        		if ((j % 2) > 0)
        		{
        			Console.WriteLine(j);
        		}
        	}

        	// for each loop - it'll cycle through every element in an array(string)
        	string randStr = "Here are some random character";

        	foreach(char c in randStr)
        	{
        		Console.WriteLine(c);
        	}
        }
    }
}

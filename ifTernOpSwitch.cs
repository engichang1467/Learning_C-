using System;

// Create a project: dotnet new console -o filename
// cd filename
// subl 
// To compile: dotnet run
namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
        	// Relational Operators > < >= <= == !=
        	// Logical Operators: && || ^ !

        	int age = 17;

        	// if statements
        	if ((age >= 5) &&(age <= 7))
        	{
        		Console.WriteLine("Go to elementary school");

        	}
        	else if ((age > 7)&&(age < 13))
        	{
        		Console.WriteLine("Go to middle school");
        	}
        	else
        	{
        		Console.WriteLine("Go to high school");
        	}

        	Console.WriteLine("! true " + (!true));

        	// Ternary operator
        	//bool canDrive = age >= 16 ? true : false;

        	// switch statement
        	switch(age)
        	{
        		case 0:
        			Console.WriteLine("Infant");
        			break;
    			case 1:
    			case 2:
    				Console.WriteLine("Toddler");
    			default:
    				Console.WriteLine("Child");
    				break;
        	}
        }
    }
}

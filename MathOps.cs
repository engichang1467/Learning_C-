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
        	Console.WriteLine("5 + 3 = " + (5 + 3));
        	Console.WriteLine("5 - 3 = " + (5 - 3));
        	Console.WriteLine("5 * 3 = " + (5 * 3));
        	Console.WriteLine("5 / 3 = " + (5 / 3));
        	Console.WriteLine("5.2 % 3 = " + (5.2 % 3));

        	int i = 0;

        	Console.WriteLine("i++ = " + (i++));
        	Console.WriteLine("++i = " + (++i));
        	Console.WriteLine("i-- = " + (i--));
        	Console.WriteLine("--i = " + (--i));

        	Console.WriteLine("i += 3 " + (i += 3));
        	Console.WriteLine("i -= 2 " + (i -= 2));
        	Console.WriteLine("i *= 2 " + (i *= 2));
        	Console.WriteLine("i /= 2 " + (i /= 2));
        	Console.WriteLine("i %= 2 " + (i %= 2));
        }
    }
}

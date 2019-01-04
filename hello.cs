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
        	// Write a input
            Console.WriteLine("What's your name");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
        }
    }
}
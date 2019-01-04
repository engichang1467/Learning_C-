using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
        	// To convert the datatype of a variable
        	//double pi = 3.14;
        	//int intPi = (int)pi;

        	// Math Function
        	// Acos, Asin, Atan, Atan2, Cos, Cosh, Exp, Log, Sin, Sinh, Tan, Tanh
        	double number1 = 10.5;
        	double number2 = 15;

        	Console.WriteLine("Math.Abs(number1) " + (Math.Abs(number1)));
        	Console.WriteLine("Math.Ceiling(number1) " + (Math.Ceiling(number1)));
        	Console.WriteLine("Math.Floor(number1) " + (Math.Floor(number1)));
        	Console.WriteLine("Math.Max(number1) " + (Math.Max(number1, number2)));
        	Console.WriteLine("Math.Min(number1) " + (Math.Min(number1, number2)));
        	Console.WriteLine("Math.Pow(number1, 2) " + (Math.Pow(number1, 2)));
        	Console.WriteLine("Math.Round(number1) " + (Math.Round(number1)));
        	Console.WriteLine("Math.Sqrt(number1) " + (Math.Sqrt(number1)));

        	// Generate random number
        	Random rand = new Random();
        	Console.WriteLine("Random Number between 1 and 10 " + (rand.Next(1,11)));
        }
    }
}
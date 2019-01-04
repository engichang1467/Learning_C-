using System;
using System.Text;
using System.Collections.Generic;

delegate double GetSum(double num1, double num2);

namespace myApp
{

    class Animal
    {
        static void Main(string[] args)
        {
        	// Anonymous Methods
			GetSum sum = delegate(double num1, double num2)
	        {
	        	return num1 + num2;
	        };

	        Console.WriteLine("5 + 10 = " + sum(5, 10));    	
        }
    }
}
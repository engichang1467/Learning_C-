using System;
using System.Text;
using System.Collections.Generic;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
        	// Exception Handling
        	try 
        	{
        		Console.Write("Divide 10 by ");
        		int num = int.Parse(Console.ReadLine());
        		Console.WriteLine("10 / {0} = {1}", num, (10/num));
        	}

        	// to catch an error
        	catch(DivideByZeroException ex)
        	{
        		Console.WriteLine("Can't divide by zero");
        		Console.WriteLine(ex.GetType().Name);
        		Console.WriteLine(ex.Message);
        		//throw new InvalidOperationException("Operation Failed", ex);
        	}
        	catch(Exception ex)
        	{
        		Console.WriteLine(ex.GetType().Name);
        		Console.WriteLine(ex.Message);
        	}
        }
    }
}
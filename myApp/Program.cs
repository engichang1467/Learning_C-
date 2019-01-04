using System;
using System.Text;
using System.Collections.Generic;

// Source: https://dotnet.microsoft.com/learn/dotnet/hello-world-tutorial#install
// Create a project: dotnet new console -o filename
// cd filename
// subl 
// To compile: dotnet run

namespace myApp
{
    class Animal
    {
        static void Main(string[] args)
        {
        	// file I/O
        	string[] custs = new string[] {"Tom", "Paul", "Greg"};

        	using (StreamWriter sw = new StreamWriter("custs.txt"))
        	{
        		foreach(string cust in custs)
        		{
        			sw.WriteLine(cust);
        		}
        	}

        	string custName = "";
        	using (StreamReader sr = new StreamReader("custs.txt"))
        	{
        		while((custName = sr.ReadLine()) != null)
        		{
        			Console.WriteLine(custName);

        		}
        	}


        }
    }
}
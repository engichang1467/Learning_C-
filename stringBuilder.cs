using System;
using System.Text;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
        	// String Builder - need using System.Text;
        	StringBuilder sb = new StringBuilder();

        	sb.Append("This is the first sentence. ");
        	sb.AppendFormat("My name is {0} and I live in {1}", "Michael", "Richmond");

        	sb.Replace("a", "e");

        	sb.Remove(5,7);

        	Console.WriteLine(sb.ToString()); 

        }
    }
}
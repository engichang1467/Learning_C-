using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
        	// String function
        	// \'\" \\ \b \n \t
        	string sampString = "A bunch of random words";

        	Console.WriteLine("Is empty " + String.IsNullOrEmpty(sampString));

        	Console.WriteLine("Is empty " + String.IsNullOrWhiteSpace(sampString));

        	Console.WriteLine("String Length " + sampString.Length);

        	// To search the index of the word 'bunch'
        	Console.WriteLine("Index of bunch " + sampString.IndexOf("bunch"));

        	// To search the word 'bunch'
        	Console.WriteLine("2nd Word " + sampString.Substring(2, 6));

        	string sampString2 = "More random words";

        	Console.WriteLine("Strings Equal " + sampString.Equals(sampString2));

        	Console.WriteLine("Start with \"A bunch\" " + sampString.StartsWith("A bunch"));

        	Console.WriteLine("Ends with words " + sampString.EndsWith("words"));

        	sampString = sampString.Replace("words", "characters");

        	sampString = sampString.Remove(0,2);

        	string[] names = new string[3] {"Matt", "Joe", "Paul"};

        	// To print out all the element in the array
        	Console.WriteLine("Name List " + String.Join(", ", names));


        	// format a string
        	string fmtStr = String.Format("{0:c} {1:00.00} {2:#.00} {3:0,0}", 1.56, 15.567, .56, 1000);

        	Console.WriteLine(fmtStr);
        }

    }
}
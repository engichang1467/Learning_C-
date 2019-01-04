using System;
using System.Text;
using System.Collections.Generic;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
        	// List
        	List<int> numList = new List<int>(); // Need to use System.Collections.Generic;

        	numList.Add(5);
        	numList.Add(15);
        	numList.Add(25);

        	int[] randArray = {1, 2, 3, 4, 5};
        	numList.AddRange(randArray);

        	// To clear the list
        	//numList.Clear();

        	// copy 
        	List<int> numList2 = new List<int>(randArray);

        	List<int> numList3 = new List<int>(new int[] {1, 2, 3, 4});

        	numList.Insert(1, 10);// .Insert(index, number)

        	numList.Remove(5);

        	numList.RemoveAt(2);

        	for (int i = 0; i < numList.Count; i++)
        	{
        		Console.WriteLine(numList[i]);
        	} 

        	// return the index for a specific value
        	Console.WriteLine("4 is in index " + numList3.IndexOf(4));

        	Console.WriteLine("5 in List " + numList.Contains(5));

        	List<string> strList = new List<string>(new string[] {"Tom", "Paul"});

        	Console.WriteLine("Tom in list " + strList.Contains("Tom")); // Not working "tom", StringComparison.OrdinalIgnoreCase 

        	// To sort the list
        	strList.Sort();
        }
    }
}
using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool canVote = true;

            char grade = 'A';

            // Integer with a max nuber of 2,147,483,647
            int maxInt = int.MaxValue;

            // Long with a max number of 9,223,372,036,854,775,807
            long maxLong = long.MaxValue;

            // Decimal has a maximum value of 79,228,162,514,264,337,593,543,950
            // If you need sth bigger look up BigInteger
            decimal maxDec = decimal.MaxValue;

            // A float is a 32 bit number with a maxValue of 3.402823E+38 with 7 decimals of precision
            float maxFloat = float.MaxValue;

            // A float is a 32 bit number with a maxValue of 1.797693134E+308 with 15 decimals of precision
            double maxDouble = double.MaxValue;

            Console.WriteLine("Max int: " + maxInt);

            var anotherName = "Tom";
            // Cannot do this anotherName = 2;

            Console.WriteLine("anotherName is a {0}",anotherName.GetTypeCode());
        }
    }
}
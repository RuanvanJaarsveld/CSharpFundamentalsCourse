using System;

namespace CSharp_Fundamentals_Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type two integer values");
            int val1 = int.Parse(Console.ReadLine());
            int val2 = int.Parse(Console.ReadLine());

            Console.WriteLine("The highest value is: " + Math.Max(val1, val2));
        }
    }
}

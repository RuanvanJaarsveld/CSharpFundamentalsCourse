using System;

namespace CSharp_Fundamentals_Exercise_Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 1 and 10");
            string inputLine = Console.ReadLine();
            int inputVal = int.Parse(inputLine);
            if((inputVal <= 10) && (inputVal >= 1))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}

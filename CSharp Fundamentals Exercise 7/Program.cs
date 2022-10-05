using System;

namespace CSharp_Fundamentals_Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int userNumber = int.Parse(Console.ReadLine());
            int total = 1;
            int index = userNumber;

            do 
            {
                total = total * index;

                index--;
            }
            while (index>0);

            Console.WriteLine("Total of " + userNumber + "! = " + total);
        }
    }
}

using System;

namespace CSharp_Fundamentals_Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int divisibleNumbers = 0;
            for (int i = 0; i<=1000; i++)
            {


                int remainder = 0;
                Math.DivRem(i,3,out remainder);
                if (remainder == 0)
                {
                    divisibleNumbers++;
                }
            }

            Console.WriteLine("divisible values of 3 = " + divisibleNumbers);
        }
    }
}

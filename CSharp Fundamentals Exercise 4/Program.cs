using System;

namespace CSharp_Fundamentals_Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Speed Limit");
            int speedLimit = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Vehicle Speed");
            int vehicleSpeed = int.Parse(Console.ReadLine());

            int demerits = 0;

            if(vehicleSpeed < speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else if(vehicleSpeed >= speedLimit)
            {
                int overSpeed = vehicleSpeed - speedLimit;
                demerits = Math.Abs(overSpeed/5);

                if (overSpeed > 60)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine("Demerits incurred: " + demerits);
                }
            }

        }
    }
}

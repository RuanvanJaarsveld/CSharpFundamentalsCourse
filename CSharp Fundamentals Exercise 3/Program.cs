using System;

namespace CSharp_Fundamentals_Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter width and height");
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            if(width>height)
            {
                Console.WriteLine("Image is Landscape");
            }
            else if(height>width)
            {
                Console.WriteLine("Image is Portrait");
            }
            else
            {
                Console.WriteLine("Image is exactly square");
            }
        }
    }
}

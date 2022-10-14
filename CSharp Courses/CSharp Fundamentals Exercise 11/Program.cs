using System;

namespace CSharp_Fundamentals_Exercise_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a name.");
            var userInput = Console.ReadLine();
            char[] nameStart = new char[userInput.Length];
            String nameEnd = "";
            var counter = 0;

            foreach (char letter in userInput)
            {                
                nameStart[userInput.Length - counter - 1] = letter;
                counter++;
                //Debug
                //Console.WriteLine(letter);
            }

            foreach (char letter in nameStart)
            {
                nameEnd = nameEnd + letter;
            }
            

            Console.WriteLine(nameEnd);
        }
    }
}

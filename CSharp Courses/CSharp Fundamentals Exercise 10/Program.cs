using System;
using System.Collections.Generic;

namespace CSharp_Fundamentals_Exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Init
            var userInput = "Begin";
            var names = new List<String>();

            //Input
            do
            {
                Console.WriteLine("Please enter a name!");
                userInput = Console.ReadLine();
                if(userInput != "")
                {
                    names.Add(userInput);
                }
            } while (userInput != "");

            //Processing
            //Output
            if (names.Count == 0)
            {
                Console.WriteLine("");
            }
            else if (names.Count == 1)
            {
                Console.WriteLine(names[0] + " likes your post.");
            }
            else if (names.Count == 2)
            {
                Console.WriteLine(names[0] + " and " + names[1] + " like your post.");
            }
            else if (names.Count >= 3)
            {
                Console.WriteLine(names[0] + ", " + names[1] + " and " + (names.Count - 2) + " others like your post.");
            }        

            //Debug
            /*for(var i = 0; i<names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }*/
        }
    }
}

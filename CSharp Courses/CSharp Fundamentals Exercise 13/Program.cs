using System;
using System.Collections.Generic;

namespace CSharp_Fundamentals_Exercise_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //init
            var numArr = new List<int>();
            do
            {
                //input
                Console.WriteLine("Please enter an integer value or type 'Quit' to exit");
                var userInput = Console.ReadLine();
                //processing
                if(userInput == "Quit")
                {
                    break;
                }
                else if(!int.TryParse(userInput, out int n))
                {
                    Console.WriteLine("Not a valid integer");
                    continue;
                }
                else if(int.TryParse(userInput, out int m))
                {  
                    numArr.Add(int.Parse(userInput));
                    Console.WriteLine("Value Addded to list");                                          
                    continue;
                }   
                else
                {
                    Console.WriteLine("Could not add value");
                    continue;
                }
            } while (true);

            //Start of Output
            Console.WriteLine("Resulting integers = ");

            //Calculate Output
            var numTrack = numArr.Count;
            for(var i = 0; i < numTrack; i++)
            {
                //find number of occurrences
                int numCount = 0;
                foreach(int compnum in numArr)
                {
                    if(compnum == numArr[i])
                    {
                        numCount++;
                    }
                }
                //decide on process from there
                if(numCount > 1)
                {
                    numArr.RemoveAt(i);
                    i--;
                    numTrack--;
                }
            }
            
            foreach(int num in numArr)
            {
                Console.Write(num + ", ");
            }
        }
    }
}

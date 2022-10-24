using System;
using System.Collections.Generic;

namespace CSharp_Fundamentals_Exercise_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            List<int> numArray = new List<int>();

            bool validInput = false;

            while(!validInput)
            {
                Console.WriteLine("Please enter a list of 5 numbers");
                string userInput = Console.ReadLine();

                //Data Processing
                userInput.Trim();

                string[] inputArray = userInput.Split(',');

                validInput = true;

                //Validation and parsing
                if (inputArray.Length < 5)
                {
                    Console.WriteLine("Length of input too short");
                    validInput = false;
                }

                
                var counter = 0;

                foreach (string word in inputArray)
                {
                    word.Trim();
                    int result;
                    bool success = int.TryParse(inputArray[counter], out result);
                    if (success)
                    {
                        numArray.Add(result);
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine("value could not be parsed");
                        validInput = false;
                        break;
                    }
                }

                if(validInput)
                {
                    Console.WriteLine("Invalid List");
                }
            }
            Console.WriteLine("Data Received. Sorting...");

            //Sorting Algorithm
            numArray.Sort();

            //Selecting lowest 3
            while(numArray.Count>3)
            {
                numArray.RemoveAt(numArray.Count-1);
            }

            //Output
            foreach(int num in numArray)
            {
                Console.WriteLine(num);
            }
        }
    }
}

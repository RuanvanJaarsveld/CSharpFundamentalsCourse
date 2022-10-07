using System;

namespace CSharp_Fundamentals_Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            Console.WriteLine("Please enter a series of numbers seperated by comma");
            string userInput = Console.ReadLine();
            //Setup
            int bigNum = 0;

            //Clean Data
            userInput.Trim();
            for (int i = 0; i < userInput.Length; i++)
            {
                if ((userInput[i] == ' '))
                {
                    userInput = userInput.Substring(0, i) + userInput.Substring(i + 1, (userInput.Length - i) - 1);
                    i--;
                }
            }

            //Loop over given string
            do
            {
                //remove leading commas
                if (userInput[0] == ',' && userInput.Length > 1)
                {
                    userInput = userInput.Substring(1, userInput.Length - 1);
                    continue;
                }
                else if (userInput[0] == ',' && userInput.Length == 1)
                {
                    break;
                }

                //Set start of a number
                int startPoint = 0;

                //Identify end of a number
                int numLength = 1;
                if ((userInput.Length > 1)&&(userInput[0] != ',')&&(userInput[1] != ','))
                {
                    numLength = userInput.IndexOf(',');
                }
                if (numLength < 0)
                {
                    numLength = 1;
                }

                int currentNum = 0;
                currentNum = int.Parse(userInput.Substring(startPoint, numLength));
                
                //Determine Max Number
                if (currentNum > bigNum)
                {
                    bigNum = currentNum;
                }

                //Remove numbers we've already worked with
                if (userInput.Length > 1)
                {
                    userInput = userInput.Substring(numLength, userInput.Length - numLength);
                }
                else if(userInput.Length == 1)
                {
                    userInput = "";
                    break;
                }

            } while (userInput.Length>0);

            Console.WriteLine("Largest Number = " + bigNum);
        }
    }
}

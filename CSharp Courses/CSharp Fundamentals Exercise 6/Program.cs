using System;

namespace CSharp_Fundamentals_Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to add start or enter ok to quit");
            string userInput = Console.ReadLine();
            int total = 0;
            if(!((String.IsNullOrEmpty(userInput)) || ((userInput.ToUpper()) == "OK")))
            {
                int userNumber = int.Parse(userInput);
                total += userNumber;
                Console.WriteLine("Current Total = " + (total));
            }
            while ((userInput.ToUpper()) != "OK")
            {                              
                Console.WriteLine("Please enter a number to add it to the total or enter ok to quit");
                userInput = Console.ReadLine();
                
                if((String.IsNullOrEmpty(userInput)) || ((userInput.ToUpper()) == "OK"))
                {
                    break;
                }             
                else
                {
                    int userNumber = int.Parse(userInput);
                    total += userNumber;
                    Console.WriteLine("Current Total = " + (total));
                    continue;
                }
            }
        }
    }
}

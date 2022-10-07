using System;

namespace CSharp_Fundamentals_Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Configure
            var random = new Random();
            int chances = 4;
            int randomNumber = random.Next(1,10);

            while(chances>0)
            { 
                Console.WriteLine("Guess the number!");
                int userGuess = int.Parse(Console.ReadLine());
                if(userGuess == randomNumber)
                {
                    Console.WriteLine("You won!");
                    break;
                }
                else 
                {
                    Console.WriteLine("Not quite, try again!");
                    chances--;
                }                
            }

            if (chances == 0)
            {
                Console.WriteLine("You lost!");
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace CSharp_Fundamentals_Exercise_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 5 numbers");
            var numbers = new List<int>();

            for (var i = 0; i < 5; i++)
            {
                bool isUnique = false;
                while (!isUnique)
                {
                    Console.WriteLine("Enter a new number");
                    var newNum = int.Parse(Console.ReadLine());
                    if(i == 0)
                    {
                        numbers.Add(newNum);
                        Console.WriteLine("First value added");
                        break;
                    }
                    else
                    { 
                        foreach (int num in numbers)
                        {
                            if (newNum != num)
                            {
                                isUnique = true;
                                Console.WriteLine("No match");
                                                    
                            }
                            else if(newNum == num)
                            {
                                isUnique = false;
                                Console.WriteLine("Number not unique");
                                break;
                            }
                        }
                        if(isUnique)
                        {
                            numbers.Add(newNum);
                            break;
                        }
                    }
                }  
            }

            Console.WriteLine("Numbers entered");

            
            int[] sortedArr = new int[numbers.Count];

            for (var i = 0; i < 5; i++)
            {
                var currentMin = numbers[0];
                var bookmark = 0;
                
                    if(numbers.Count > 1)
                    {
                        for (var j = 1; j < numbers.Count; j++)
                        {
                            if (numbers[j] < currentMin)
                            {
                                currentMin = numbers[j];
                                bookmark = j;
                            }
                        }
                    }
                    else 
                    {
                        currentMin = numbers[0];
                    }                    
                
                sortedArr[i] = currentMin;
                numbers.RemoveAt(bookmark);
            }

            Console.WriteLine("Your numbers are: ");
            for(var i = 0; i < sortedArr.Length; i++)
            {
                Console.Write(sortedArr[i] + ", ");
            }
        }
    }
}

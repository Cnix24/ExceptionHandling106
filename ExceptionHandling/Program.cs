using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // List of integers, user number input, divide list by user input
                List<int> divideList = new List<int>() { 4, 8, 12, 16 };

                Console.WriteLine("Pick a number.");
                int numberPickOne = Convert.ToInt32(Console.ReadLine());

                foreach (int num in divideList)
                {
                    int x = num / numberPickOne;
                    Console.WriteLine(num + " divided by " + numberPickOne + " equals " + x + ".");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please choose a whole number.");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            Console.WriteLine("Time to move on from this division problem...");
            Console.ReadLine();
        }
    }
}

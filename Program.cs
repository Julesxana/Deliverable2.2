/* 
Author: Juliana Dunlap
Date: 1/30/2020
Project: Week 3 Deliverable 2.2 Iteration Statements
*/
using System;

namespace Deliverable2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                // Ask user for an iteration value
                Console.WriteLine("Please enter an integer between 1 and 100");

                //the variable value is the integer the user enterd that will determine the number of iterations
                int value = int.Parse(Console.ReadLine());

                //the vairable count is how many iterations the loop has completed, incrementing by 1

                if ((value <= 100) && (value >= 1))
                {
                    for (int count = 1; count <= value; count++)
                    {
                        //the loop tells the user the number entered and what iteration the loop is on every cycle
                        Console.WriteLine("You have entered " + value + " This is the current integer value in the loop " + count);
                    } 
                }
                else
                    Console.WriteLine("please enter an integer between 1 and 100");
            }
            catch
            {
                Console.WriteLine("please enter an integer between 1 and 100");


            }
        }
    }
}

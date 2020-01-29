using System;

namespace Deliverable2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter an integer between 1 and 100");
            //string input = Console.ReadLine();
            int value = int.Parse(Console.ReadLine());

            for(int count = 1; count <= value; count++)
            {
                Console.WriteLine("You have entered " + value + " This is the current integer value in the loop " + count);
            }
        }
    }
}

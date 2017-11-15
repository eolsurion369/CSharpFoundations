using System;

/*
****************************************************************************************
    Author:     Robert Fike
    Date:       11/15/17
    Project:    C# Sharp Foundations
****************************************************************************************
 */

namespace CSharpFoundations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 5 and 20");
            int myNumber = int.Parse(Console.ReadLine());
            
            int i = 1;
            
            while (i <= myNumber) {
                if (i % 2 == 0) {
                    Console.WriteLine(i + " is even");
                }
                else
                {
                    Console.WriteLine(i + " is odd");
                }
                i++;
            }
        }
    }
}

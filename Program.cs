using System;
using System.Text;

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
            MyMath mathInstance = new MyMath();
            int firstSet = mathInstance.MultiplyTwoNumbers(2,4);
            int secondSet = MultiplyTwoNumbers(16,12);
            int finalResult = (firstSet * secondSet);
            Console.WriteLine(finalResult.ToString());
        }

        static int MultiplyTwoNumbers(int number1, int number2) {
            int myresult = (number1 * number2);
            return myresult;
        }
    }

    class MyMath {
        public int MultiplyTwoNumbers(int number1, int number2) {
            int myresult = (number1 * number2);
            return myresult;       
        } 
    }
}

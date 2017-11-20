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
            int? retValue = Parser.ParsInt("GOT");
            if (retValue != null) {
                Console.WriteLine(retValue);
            }
            else {                
                Console.WriteLine("Null returned");
            }
        }
    }

    class Parser {
        public static int? ParsInt(string enterValue) {
            int parsedInt;
            if (int.TryParse(enterValue, out parsedInt)) {
                return parsedInt;
            }
            else {
                return null;
            }
        }
    }
}

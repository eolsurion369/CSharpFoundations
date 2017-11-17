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
            String[] Names = new String[] {"Sansa", "Bran", "Eddard", "Arya"};
            foreach (String item in Names) {
                Console.WriteLine(item);
            }
        }
    }
}

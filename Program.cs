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
            String gameOfThronesPremier = "April 17, 2011";
            DateTime gameOfThronesPremierDate = Convert.ToDateTime(gameOfThronesPremier);
            Console.WriteLine(gameOfThronesPremierDate.ToString());
        }
    }
}

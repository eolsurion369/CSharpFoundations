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
            int? bonus = null;
            bool hasBonus = false;

            hasBonus = (bonus.HasValue) ? true : false;
        }
    }
}

using System;
using System.Text;
using System.Collections.Generic;

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
            string[] Starks = new string[6];
            Starks[0] = "Eddard Stark";
            Starks[1] = "Jamie Lannister";
            Starks[2] = "Sansa Stark";
            Starks[3] = "Tyrion Lannister";
            Starks[4] = "Rob Stark";
            Starks[5] = "Robert Baratheon";

            StarkJumper sj = new StarkJumper();
            sj.removeStarks(Starks);

            string[] retArray = sj.removeStarks(Starks);

            foreach(string stark in retArray) {
                Console.WriteLine(stark);
            }
        }
    }

    class StarkJumper {
        internal string[] removeStarks(string[] GOTChars) {
            List<string> tmpList = new List<string>();

            foreach (string ch in GOTChars) {
                string lstName = ch.Substring(ch.Length -5,5);
    
                if (lstName != "Stark") {
                    tmpList.Add(ch);
                }
            }

            string[] newArray = tmpList.ToArray();

            return newArray;
        }
    }
}

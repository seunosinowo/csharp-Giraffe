using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    internal class ForLoop
    {
        public static void If_Statement()
        {

            //For loop
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42};

            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }
        }
    }
}

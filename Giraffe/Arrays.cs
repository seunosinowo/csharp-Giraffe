using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    internal class Arrays
    {
        public static void InputPut()
        {
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            luckyNumbers[2] = 800;

            string[] friends = new string[2];
            friends[0] = "Seun";

            Console.WriteLine(luckyNumbers[2]);

            Console.WriteLine();
            SayHi("Mike", 23);
            SayHi("Joy", 25);
            SayHi("Jude", 67);

            Console.WriteLine();

            int CubeNumber = Cube(5);
            Console.WriteLine(CubeNumber);


            Console.ReadLine();
        }

        //Creating Methods
        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you're " + age + " years old");
        }

        //Method to cube a number
        static int Cube(int num)
        {
            int result = num * num * num;
            return result;
        }
    }
}

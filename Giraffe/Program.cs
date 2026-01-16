using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    internal class Program
    {
        
        public static void First()
        {
            Console.WriteLine("Hello world");
            Console.WriteLine();

            string characterName = "Seun";
            int characterAge;
            characterAge = 25;

            Console.WriteLine("There was once a man name " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");

            characterName = "Tom";
            Console.WriteLine("He really like the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);

            
            //Data Types;
            string phrase = "Seun Academy";
            char grade = 'A';
            int age = 9;
            double gpa = 3.3;
            bool isMale = true;

            Console.WriteLine(false);


            //Working with Strings
            Console.WriteLine("Seun\nAcademy");
            Console.WriteLine("Seun\"Academy");

            Console.WriteLine();

            string phrase1 = "Seun Academy" + " is cool";
            Console.WriteLine(phrase1);
            Console.WriteLine(phrase1.Length);
            Console.WriteLine(phrase1.ToUpper());
            Console.WriteLine(phrase1.ToLower());
            Console.WriteLine(phrase1.Contains("Academies"));
            Console.WriteLine(phrase1[4]);
            Console.WriteLine(phrase1.IndexOf("zuf"));
            Console.WriteLine(phrase1.Substring(4));

            Console.WriteLine();
            Console.WriteLine();

            //Working with Numbers
            Console.WriteLine(-7.6);
            Console.WriteLine(5 + 6);
            Console.WriteLine(5 % 2);
            Console.WriteLine("5 x 6 = " + 5 * 6);

            Console.WriteLine();

            int numb = 7;
            numb--;

            Console.WriteLine(numb / 2);
            Console.WriteLine(numb);
            Console.WriteLine(Math.Abs(-40));
            Console.WriteLine(Math.Pow(2, 4));
            Console.WriteLine(Math.Sqrt(36));
            Console.WriteLine(Math.Max(4, 90));
            Console.WriteLine(Math.Round(5.4));

            //Getting User Inputs



            Console.ReadLine();

        }
    }
}

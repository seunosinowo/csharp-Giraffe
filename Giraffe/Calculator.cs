using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    internal class Calculator
    {
        
        public static void Calculator1()
        {
            //Building a Calculator
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);
            //Console.ReadLine();


            //Mad libs Game
            string color, pluralNoun, celebrity;

            Console.Write("Enter a Color: ");
            color = Console.ReadLine();

            Console.Write("Enter a PluralNoun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a Celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I love " + celebrity);

            Console.ReadLine();

        }
    }
}

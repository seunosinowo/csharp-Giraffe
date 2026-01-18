using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    internal class If_Statements
    {
        
        public static void If_Statement()
        {
            bool isMale = false;
            bool isTall = true;

            if (isMale && isTall)
             //if (isMale || isTall)

            {
               Console.WriteLine("You're a tall male");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You're a short male");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You're not a male but you're tall");
            }
            else
            {
                Console.WriteLine("You're not male and not tall");
            }
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    internal class Exception
    {
        
        public static void Exception2()
        {
            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
                
            } catch (System.DivideByZeroException e)
            {
                Console.WriteLine(e.Message);  
            }
            catch (System.FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();


        }
    }
}

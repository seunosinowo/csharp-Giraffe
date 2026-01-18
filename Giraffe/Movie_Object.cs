using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    internal class Movie_Object
    {
        
        public static void Movie_Object1()
        {
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam", "PG");

            Console.WriteLine(avengers.Rating);
            Console.ReadLine();
        }
    }
}

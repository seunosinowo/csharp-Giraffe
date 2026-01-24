using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class StaticClass
    {
        public static void First()
        {
            SongClass holiday = new SongClass("Holiday", "Green song", 200);
            Console.WriteLine(SongClass.songCount);

            SongClass jim = new SongClass("Kas", "Red song", 700);
            Console.WriteLine(jim.getSongCount());



            Console.ReadLine();
        }
    }
}

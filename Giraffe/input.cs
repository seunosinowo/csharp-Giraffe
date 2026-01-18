using System;

namespace Giraffe
{
    internal class Input
    {
        public static void InputPut()
        {
            Console.Write("Enter your Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            string age = Console.ReadLine();

            Console.WriteLine("Hello " + name + " you are " + age + " years old");
            Console.ReadLine();

        }
    }
}
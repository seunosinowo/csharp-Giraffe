using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    internal class While_Loop
    {
        public static void WhileLoop()
        {
            int index = 61;
            while (index <= 5)
            {
                Console.WriteLine(index);
                //index++;
            }
            Console.WriteLine();

            //Guessing game
            string secretWord = "seun";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }else
                {
                    outOfGuesses = true;
                }   
            }
            if (outOfGuesses)
            {
                Console.Write("You Lose");
            }else
            {
                Console.Write("You win");
            }
                
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowNumber = 0; // Sets the initial low part of the range
            int highNumber = 1000; // Sets the initial high part of the range

            Random r = new Random(); // Instatiates the Random class to r
            int randGuess = r.Next(lowNumber, highNumber); // Sets  up the variable with the guess amount

            bool correctGuess = false; // This is used to exit the while loop if the answer guessed was correct
            

            Console.WriteLine("Guess a number between 1 and 1000 then hit enter");
            Console.WriteLine("Is your number lower or higher than " + r.Next(lowNumber, highNumber));
            Console.WriteLine("If the number is higher type higher. If lower type lower. If its your number type correct.");
            string answer = Console.ReadLine();

            while (correctGuess == false) // Start the loop for guessing higher / lower
            {
                if (answer.ToLower() == "higher")
                {

                }
                else if (answer.ToLower() == "lower")
                {

                }
                else if (answer.ToLower() == "correct")
                {
                    correctGuess = true;
                }
                else
                {
                    Console.WriteLine("Please type higher, lower, or correct");
                }
            }

            Console.WriteLine("Hooray I guessed the right number!");

            Console.ReadLine();
        }
    }
}

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

            Random r = new Random(); // Sets up the function to generate a random number


            bool correctGuess = false; // This is used to exit the while loop if the answer guessed was correct
            int guess; // This is used for the guess itself after randGuess is ran

            Console.WriteLine("Guess a number between 1 and 1000 then hit enter");

            

            while (correctGuess == false) // Start the loop for guessing higher / lower
            {
                int randGuess = r.Next(lowNumber, highNumber); // Sets  up the variable with the guess
                guess = randGuess; // Sets up the next number it guesses
                Console.WriteLine("Is your number lower or higher than " + guess);
                Console.WriteLine("If the number is higher type higher. If lower type lower. If its your number type correct.");

                //Console.WriteLine("-----Debug-----"); // This section was for debugging purposes. 
                //Console.WriteLine("High: " + highNumber); // Allows me to see the current values for the to variables
                //Console.WriteLine("Low: " + lowNumber);
                //Console.WriteLine("----------");

                string answer = Console.ReadLine();
                
                if (answer.ToLower() == "higher")
                {
                    lowNumber = guess + 1; // This sets the low end of the range + 1 because it can be assumed the number display was NOT their number
                }
                else if (answer.ToLower() == "lower")
                {
                    highNumber = guess -1; // This sets the high end of the range - 1 because it can be assumed the number display was NOT their number
                }
                else if (answer.ToLower() == "correct")
                {
                    correctGuess = true;
                }
                else
                {
                    Console.WriteLine("Please type higher, lower, or correct"); // Psuedo error checking
                }
            }

            Console.WriteLine("Hooray I guessed the right number!");

            Console.ReadLine(); // this is used to keep the console open so you can see the win phrase
        }
    }
}

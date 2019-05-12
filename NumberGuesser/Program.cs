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
            Console.WriteLine("Guess a number between 1 and 1000 then hit enter");
            Console.ReadLine();

            while (correctGuess == false) // Start the loop for guessing higher / lower
            {
                try
                {
                    int guess; // This is used for the guess itself after randGuess is ran
                    int randGuess = r.Next(lowNumber, highNumber); // Sets  up the variable with the guess
                    guess = randGuess; // Sets up the next number it guesses
                    Console.WriteLine("Is your number lower or higher than " + guess);
                    Console.WriteLine("If the number is higher type higher. If lower type lower. If its your number type correct.");
                    string answer = Console.ReadLine();

                    if (answer.ToLower() == "higher")
                    {
                        lowNumber = guess + 1; // This sets the low end of the range + 1 because it can be assumed the number display was NOT their number
                    }

                    else if (answer.ToLower() == "lower")
                    {
                        highNumber = guess - 1; // This sets the high end of the range - 1 because it can be assumed the number display was NOT their number
                    }
                    else if (answer.ToLower() == "correct")
                    {
                        correctGuess = true;
                        Console.WriteLine("Hooray I guessed the right number!");
                    }
                    else if (answer.ToLower() == "quit")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please type higher, lower, or correct"); // Psuedo error checking
                    }
                }
                catch (ArgumentOutOfRangeException)
                { 
                    Console.WriteLine("Please type \"higher\" to continue");
                    continue;
                }
        }
            Console.ReadLine(); // this is used to keep the console open so you can see the win phrase
        }

    }
}

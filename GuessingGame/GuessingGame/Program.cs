using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                //Instantiate an object (an instance of a class) using the new operator
                Random random = new Random();
                int computerNumber = random.Next(1, 101);
                int numberOfGuesses = 8;

                Console.WriteLine($"Try and Guess a number between 1 to 100. You'll have to get it within {numberOfGuesses-1} guesses");
                string userInput = Console.ReadLine();

                //Parse the number entered by the user as an integer. For now, presume perfect input (no typos)
                int numberEntered = int.Parse(userInput);

                

                while (numberEntered != computerNumber && numberOfGuesses > 0)
                {
                    if (numberEntered > computerNumber + 30)
                    {
                        Console.WriteLine("Wow, Why would you guess such a high number? do you not know how this game is played??");
                        userInput = Console.ReadLine();
                        numberEntered = int.Parse(userInput);
                    }
                    else if (numberEntered > 20 + computerNumber && numberEntered < computerNumber + 30)
                    {
                        Console.WriteLine("I am sorry, but you are way off the mark. You Guessed a really High number, Guess again. ");
                        userInput = Console.ReadLine();
                        numberEntered = int.Parse(userInput);
                    }
                    else if (numberEntered > 10 + computerNumber && numberEntered < 20 + computerNumber)
                    {
                        Console.WriteLine("Great!, You are so close to the mark. However, it's still a bit high, I am sure you'll get it next time.");
                        userInput = Console.ReadLine();
                        numberEntered = int.Parse(userInput);
                    }
                    else if (numberEntered < 10 + computerNumber && numberEntered > computerNumber)
                    {
                        Console.WriteLine("You are so close, I might as well tell you the number. But that would be cheating!, guess a lower number");
                        userInput = Console.ReadLine();
                        numberEntered = int.Parse(userInput);
                    }
                    else if (numberEntered > computerNumber - 10 && numberEntered < computerNumber)
                    {
                        Console.WriteLine("Oh man! so close, guess a bit higher");
                        userInput = Console.ReadLine();
                        numberEntered = int.Parse(userInput);
                    }
                    else if (numberEntered > computerNumber - 20 && numberEntered < computerNumber - 10)
                    {
                        Console.WriteLine("Ok, I don't know what to tell you except that your are getting warmer ?. The number you guessed is too low, try again.");
                        userInput = Console.ReadLine();
                        numberEntered = int.Parse(userInput);
                    }
                    else if (numberEntered < computerNumber - 20 && numberEntered > computerNumber - 30)
                    {
                        Console.WriteLine("OMG!, you guessed a pretty low number... tsk tsk.");
                        userInput = Console.ReadLine();
                        numberEntered = int.Parse(userInput);
                    }
                    else if (numberEntered < computerNumber - 30)
                    {
                        Console.WriteLine($"Wow, serously? you guessed {numberEntered}? no one who knows how this game is played would ever pick a number so low... ");
                        userInput = Console.ReadLine();
                        numberEntered = int.Parse(userInput);
                    }

                   
                    if (numberOfGuesses > 2)
                    {
                        numberOfGuesses--;
                        Console.WriteLine($"You have {numberOfGuesses-1} left.");
                    }
                    else if (numberOfGuesses == 2)
                    {
                        Console.WriteLine($"If you can't guess the number in the final {numberOfGuesses-1} guesses. I am sorry to inform you but, you just might be a loser... of this game of course.");
                        numberOfGuesses--;
                    }
                    else if (numberOfGuesses == 1)
                    {
                        Console.WriteLine($"Well, it's come down to {numberOfGuesses-1}. Good Luck.");
                        numberOfGuesses--;
                    }

                }
                if (numberEntered == computerNumber)
                {
                    Console.WriteLine("I knew you were not a loser. Great Job");
                }
                else
                {
                    Console.WriteLine($"I am sorry, but I have you all the time in the world to get this right... the number was {computerNumber}.");
                }
                Console.WriteLine("Would you like to try this again? 1 for yes , 2 for no");
                string tryAgainSelector = Console.ReadLine();
                int tryAgainNumber = int.Parse(tryAgainSelector);
                
                if(tryAgainNumber == 2)
                {
                    break;
                }
            }
        }
    }
}

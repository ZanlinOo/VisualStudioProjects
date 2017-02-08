using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int minRange = 0;
                int maxRange = 100;
                int maxNumberOfAttempts = 7;
                bool isCorrectValue = false;

                while (!isCorrectValue)
                {
                    try
                    {
                        Console.WriteLine("Choose a lower bound Value:");
                        minRange = int.Parse(Console.ReadLine());
                        isCorrectValue = true;

                    }
                    catch(Exception exception)
                    {
                        Console.WriteLine("Please choose an actual number");
                    }
                }

                isCorrectValue = false;
                while (!isCorrectValue)
                {
                    try
                    {
                        Console.WriteLine("Choose a upper bound Value:");
                        maxRange = int.Parse(Console.ReadLine());
                        isCorrectValue = true;
                    }
                    catch(Exception exception)
                    {
                        Console.WriteLine("why? do you do this? Choose a number!");
                    }
                }

                isCorrectValue = false;
                while (!isCorrectValue)
                {
                    try
                    {
                        Console.WriteLine("Choose a number of attempts:");
                        maxNumberOfAttempts = int.Parse(Console.ReadLine());
                        isCorrectValue = true;
                    }
                    catch(Exception exception)
                    {
                        Console.WriteLine("OKay... you are just messing with me now. Please just pick a number");
                    }
                }
                

                int responseValue = 0;
                int repeatValue = 0;
                int guessedNumber = 0;

                Console.WriteLine($"Pick a number from {minRange} to {maxRange} for the computer to guess. \n I promise I won't peek.");
                string inputtedGuessValue = Console.ReadLine();

                int numberToGuess = int.Parse(inputtedGuessValue);

                Console.WriteLine($"Thank you for allowing me {maxNumberOfAttempts} tries to guess your number. \n Let me know if the Value is too high or too low.");

                int numberOfAttempts = 0;
                while (numberOfAttempts <= maxNumberOfAttempts)
                {
                    Random random = new Random();
                    guessedNumber = random.Next(minRange, maxRange);

                    Console.WriteLine($"Is your number {guessedNumber}? 1 for Yes!, 2 for No...");
                    string yesNoResponse = Console.ReadLine();
                    responseValue = int.Parse(yesNoResponse);

                    if (responseValue == 1)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("I guess I got it wrong. \n If the number is higher press 1, if the number is lower press 2");
                        string highOrLowResponse = Console.ReadLine();

                        int highOrLowResponseValue = int.Parse(highOrLowResponse);

                        if (highOrLowResponseValue == 1)
                        {
                            minRange = guessedNumber;
                        }
                        else
                        {
                            maxRange = guessedNumber;
                        }
                    }
                    if (numberOfAttempts == maxNumberOfAttempts - 2)
                    {
                        Console.WriteLine($"Oh no!, I only have {(maxNumberOfAttempts - 1) - numberOfAttempts} attempt left...");
                    }
                    numberOfAttempts++;
                }
                if (responseValue == 1)
                {
                    Console.WriteLine($"Awesome!, I knew it was {guessedNumber} all along.");
                    break;
                }
                else
                {
                    Console.WriteLine("I am sorry, I've Falied you... \n Would you like me to try again? 1 for Yes, 2 for No.");
                    string repeatAnswer = Console.ReadLine();

                    repeatValue = int.Parse(repeatAnswer);
                }

                if (repeatValue == 2)
                {
                    break;
                }
            }

        }
    }
}

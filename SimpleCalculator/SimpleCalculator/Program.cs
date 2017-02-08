using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int lastKnownCharPosition = 0;
            int addedPosition = 0;

            int firstValue = 0;
            int secondValue = 0;
            string inputtedOperator; 

            Console.WriteLine("Type in a number followed by 1 space, followed by an operator, followed by a space, followed by a number, and I will calculate it for you!");

            string input = Console.ReadLine();
            

            for (int i = 0; input[i] != ' '; i++)
            {
                string inputtedValue = input.Substring(lastKnownCharPosition,i+1);
                firstValue = int.Parse(inputtedValue);

                addedPosition = i + 1;
            }
            lastKnownCharPosition += addedPosition + 1;

            inputtedOperator = input[lastKnownCharPosition].ToString();

            lastKnownCharPosition++;

            string secondString = input.Substring(lastKnownCharPosition, input.Length - lastKnownCharPosition);
            secondValue = int.Parse(secondString);

        }
    }
}

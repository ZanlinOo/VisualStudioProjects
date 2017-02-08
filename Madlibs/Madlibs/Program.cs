using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madlibs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a message to the screen
            Console.WriteLine("Hello, what is your name?");

            //Reading data from the keyboard
            string playerName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            string playerAge = Console.ReadLine();


            //Writing data to the screen
            //Console.WriteLine("Nice to meet you. I have a cousin named {0}, and he is also {1} years old.", playerName, playerAge);
            Console.WriteLine($"Nice to meet you. I have a cousin named {playerName}, and he is also {playerAge} years old.");

            Console.WriteLine("Press ESC key to exit");
            ConsoleKey exitKey = ConsoleKey.Escape;

            waitForKey(ConsoleKey.Escape);
        }

        #region Helper Functions

        /// <summary>
        /// Waits for a keypress.
        /// </summary>
        /// <param name="exitKey">A key to wait for.</param>
        private static void waitForKey(ConsoleKey exitKey)
        {
            while (Console.ReadKey(true).Key != exitKey)
            {
                // Wait for escape key to exit
            }
        }

        #endregion Helper Functions
    }
}

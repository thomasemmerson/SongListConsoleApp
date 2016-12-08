using System;

namespace SongListConsoleApp
{
    class CLI
    {
        internal static void DisplayWelcome()
        {
            Console.WriteLine("----------Song List-----------");
            Console.WriteLine("A List of your Favourite Songs");
            Console.WriteLine("------------------------------");
        }

        internal static string Prompt(string message)
        {
            Console.Write(message);
            string userInput = Console.ReadLine();

            return userInput;
        }
    }
}

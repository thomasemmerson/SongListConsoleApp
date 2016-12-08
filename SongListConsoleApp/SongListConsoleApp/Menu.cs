using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongListConsoleApp
{
    internal class Menu
    {
        private static string[] _options = new string[]
        {
            "Add song",
            "View list",
            "Quit"
        };

        static void Display()
        {
            for (int i = 0; i < _options.Length; i++)
            {
                Console.WriteLine($"{i+1}) {_options[i]}");
            }
        }

        internal static int Prompt(string message)
        {
            Console.Write(message);
            string userInput = Console.ReadLine();

            return Convert.ToInt32(userInput);
        }
    }
}

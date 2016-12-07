using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongListConsoleApp
{
    public class Program
    {
        static List<Song> _songs = new List<Song>();

        /// <summary>
        /// Application entry point
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            CLI.DisplayWelcome();

            int option = 0;
            while ((option = CLI.Prompt()) != 3)
            {
                switch (option)
                {
                    case 1:
                        AddSong();
                        break;
                    case 2:
                        DisplaySongList();
                        break;
                }
            }
        }

        static void DisplaySongList()
        {
            Console.WriteLine("Songs");
            Console.WriteLine("-----------");
            _songs.ForEach((song) => Console.WriteLine(song));
            Console.WriteLine();
        }

        static void AddSong()
        {
            bool done = false;
            do
            {
                string songName = CLI.Prompt("What's the name of the song? ");
                string artist = CLI.Prompt("Who's the artist? ");

                _songs.Add(new Song { Name = songName, Artist = artist });
                done = CLI.Prompt("Add another song? (Y/N) ").ToLower() != "y";

            } while (!done);
        }
    }
}

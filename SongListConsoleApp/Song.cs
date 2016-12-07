using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongListConsoleApp
{
    class Song
    {
        public string Name { get; set; }

        public string Artist { get; set; }

        public override string ToString()
        {
            return Name + " by " + Artist;
        }
    }
}

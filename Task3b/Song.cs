using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3b
{
    abstract class Song
    {
        protected string Title { private set; get; }
        protected string Artist { private set; get; }

        public Song(string newTitle, string newArtist)
        {
            this.Title = newTitle;
            this.Artist = newArtist;
        }

        public void Play()
        {
            Console.WriteLine(this.Title);
            Console.WriteLine(this.Artist);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3b
{
    class Player
    {
        private List<string> queue = new List<string>();

        public void Add(string song){ queue.Add(song);}

        public void Remove(string song){ queue.Remove(song);}

        public void Play(string song){ queue[songname].Play(); }

        public void menu()
        {
            Console.WriteLine("What do you want to do");

            #comment

        }
        
    }
}

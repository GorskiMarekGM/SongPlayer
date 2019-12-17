using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3b
{
    class HipHop : Song
    {
        private string HipHopSound = "Jol Jol Jol Elo Elo";

        public HipHop (string newTitle, string newArtist): base (newTitle, newArtist)
        {
            
        }
        public void Play()
        {
            base.Play();
            Console.WriteLine(this.HipHopSound);
        }

    }
}

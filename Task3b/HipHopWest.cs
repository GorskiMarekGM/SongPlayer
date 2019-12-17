using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3b
{
    class HipHopWest : HipHop
    {
        private string HipHopWestSound = "Yo Yo Yo it's West Hip Hop";

        public HipHopWest(string newTitle, string newArtist) : base(newTitle, newArtist)
        {

        }
        public void Play()
        {
            base.Play();
            Console.WriteLine(this.HipHopWestSound);
        }
    }
}

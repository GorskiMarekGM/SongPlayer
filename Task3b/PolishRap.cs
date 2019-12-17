using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3b
{
    class PolishRap : Rap
    {
        private string PolishRapSound = "Ona by tak chciala";

        public PolishRap(string newTitle, string newArtist) : base(newTitle, newArtist)
        {

        }
        public void Play()
        {
            base.Play();
            Console.WriteLine(this.PolishRapSound);
        }
    }
}

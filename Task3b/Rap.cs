using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3b
{
    class Rap : HipHop
    {
        private string RapSound = "Trrrrrrrrrrrr";

        public Rap(string newTitle, string newArtist) : base(newTitle, newArtist)
        {

        }
        public void Play()
        {
            base.Play();
            Console.WriteLine(this.RapSound);
        }
    }
}

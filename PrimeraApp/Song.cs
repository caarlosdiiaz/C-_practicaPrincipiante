using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraApp
{
    public class Song : Media
    {
        public long Seconds { get; set; }

        public ShelvePosition Position { get; set; }

        public string Category { get; set; }
        public List<Artist> Artists { get; set; }

        public int Visits {  get; set; }
        public override void play()
        {
            Console.WriteLine("Increase volume");
            base.play();
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return  $"Title: {Title} Duración: {Seconds}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraApp
{
    public class Media
    {
        public string Title { get; set; }
        public string Category { get; internal set; }

        public virtual void play() {
            Console.WriteLine($"Playing {Title}");
        }

        public override bool Equals(object obj)
        {
            var mediaObj = (Media)obj;
            if (mediaObj.Title == this.Title) return true;
            else return false;
        }
    }
}

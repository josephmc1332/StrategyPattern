using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStrategyPattern
{
    public class SuperHero
    {
        public string whichsuper { get; set; }
        public ISuperHero superi;

        public SuperHero(ISuperHero mycall)
        {
            superi = mycall;
        }


        public string Moves()
        {
            return superi.Moves();
        }
    }
}

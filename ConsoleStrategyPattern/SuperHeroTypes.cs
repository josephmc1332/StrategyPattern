using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStrategyPattern
{
    class Batman : ISuperHero
    {
        public string Moves()
        {
            string move = "drive";
            return move;
        }
    }
    class Superman : ISuperHero
    {
        public string Moves()
        {
            string move = "fly";
            return move;
        }
    }
    class SpiderMan : ISuperHero
    {
        public string Moves()
        {
            string move = "Spins web";
            return move;
        }
    }
}

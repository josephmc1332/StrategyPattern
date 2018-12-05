using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStrategyPattern
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("What super hero should we call");
            string super = Console.ReadLine();
            SuperHero sp = new SuperHero(null);

            switch (super)
            {
                case "batman":
                    sp.superi = new Batman();
                    break;
                case "superman":
                    sp.superi = new Superman();
                    break;
                case "spiderman":
                    sp.superi = new SpiderMan();
                    break;
                    
                    
            }
            Console.WriteLine($"{super} {sp.superi.Moves()}");


        }
        
    }
}

using _25_Pattern_Straregy_Interface.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Pattern_Straregy_Interface {
    class Program {
        static void Main(string[] args) {

            //Hero newHero = new("Cat");
            Hero newHero = new Hero("Cat");
            newHero.EatProduct();

            newHero.setProduct(new Pizza());
            newHero.EatProduct();

            newHero.setProduct(new Egg());
            newHero.EatProduct();

            Console.ReadKey();
        }
    }
}

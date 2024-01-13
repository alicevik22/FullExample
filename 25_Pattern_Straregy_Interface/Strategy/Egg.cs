using System;

namespace _25_Pattern_Straregy_Interface.Strategy {
    class Egg : IProduct {
        void IProduct.Eats() {
            Console.WriteLine("eats egg");
        }
    }
}

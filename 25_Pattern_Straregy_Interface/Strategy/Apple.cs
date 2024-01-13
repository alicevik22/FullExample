using System;

namespace _25_Pattern_Straregy_Interface.Strategy {
    class Apple : IProduct {
        void IProduct.Eats() {
            Console.WriteLine("eats apple");
        }
    }
}

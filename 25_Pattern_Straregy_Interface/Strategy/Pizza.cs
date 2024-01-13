using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Pattern_Straregy_Interface.Strategy {
    class Pizza : IProduct {
        void IProduct.Eats() {
            Console.WriteLine("eats pizza");
        }
    }
}

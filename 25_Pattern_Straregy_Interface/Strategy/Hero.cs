using System;

namespace _25_Pattern_Straregy_Interface.Strategy {
    class Hero {
        private readonly string _name;
        //private IProduct? _product;
        private IProduct _product = null;

        public Hero(string name){
            _name = name;
        }

        public void setProduct(IProduct p) {
            _product = p;
        }

        public void EatProduct() {
            Console.WriteLine(">>>");
            //if(_product is null) {
            if(_product == null) {
                Console.WriteLine(_name + "not takes product");
                return;
            }
            Console.WriteLine(_name + " takes product");
            _product.Eats();
            Console.WriteLine(_name + " puts product");
            Console.WriteLine(" -----");
            Console.Write("r\n");
            Console.Write("r");
        }
    }
}

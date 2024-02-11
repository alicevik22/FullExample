using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Pattern_Inc_Nasl_Polimorf {
    class Program {
        static void Main(string[] args) {
        }
    }

    // Принципы ООП
    // инкапсуляция (private, если изменение то идет проверка валидации)
    class ClassIncapsulation {
        private int money;
        public int getValue() {
            return money;
        }
        public void SpendMoney(int amount) { // отдаем
            if (amount < 0) {
                throw new ArgumentOutOfRangeException();
            }
            if (money < amount) {
                return;
            }
            money -= amount;
        }
        public void ResiveMoney(int amount) { // забираем
            if (amount < 0) {
                throw new ArgumentOutOfRangeException();
            }
            money += amount;
        }
    }
    // наследование
    class ClassNasl : Human {
        public void setHumanVar(int var) {
            varPublic = var;
            varProtected = var;
        }
    }
    class Human {
        public int varPublic;
        protected int varProtected;
        private int varPrivate;
    }
    // полиморфизм (virtual oweride)
    class ClassPolimorfizm {
        void foo() {
            Person bob = new Person("Bob");
            bob.Print(); // вызов метода Print из класса Person

            Employee tom = new Employee("Tom", "Microsoft");
            tom.Print(); // вызов метода Print из класса Employee
        }
    }
    class Person {
        public string Name { get; set; }
        public Person(string name) {
            Name = name;
        }
        public virtual void Print() {
            Console.WriteLine(Name);
        }
    }
    class Employee : Person {
        public string Company { get; set; }
        public Employee(string name, string company)
            : base(name) {
            Company = company;
        }
        public override void Print() {
            Console.WriteLine(Name + " работает в " + Company);
        }
    }

}

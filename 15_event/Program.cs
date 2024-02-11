using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_event {
    class Program {
        static void Main(string[] args) {

            Class1 cls = new Class1();
            cls.eventEnd += cls_eventEnd;
            cls.Process();
            Console.ReadKey();
        }

        static void cls_eventEnd(int t) {
            Console.WriteLine("End " + t);
        }
    }
}

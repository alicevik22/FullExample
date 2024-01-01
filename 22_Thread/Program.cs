using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _22_Thread {
    class Program {
        static void Main(string[] args) {
            Thread Thead1 = new Thread(new ThreadStart(TheadWork));
            Thead1.Start();
            Console.WriteLine("state: " + Thead1.ThreadState);
            Thread.Sleep(2000);
            Thead1.Abort();
            Console.WriteLine("state: " + Thead1.ThreadState);
            Thead1.Interrupt(); // нужно проверить на другой винде где видны потоки
            Console.WriteLine("state: " + Thead1.ThreadState);
            Console.ReadKey();
        }
        public static void TheadWork() {
            while (true) {
                try {
                    Console.WriteLine("run: " + Thread.CurrentThread);
                    Thread.Sleep(500);
                } catch (ThreadAbortException) {
                    Console.WriteLine("exeption: " + Thread.CurrentThread);
                }
            }
        }
        private void TheadInfinite() {
            // бесконечная задача
            Thread.Sleep(Timeout.Infinite);
        }
    }
}

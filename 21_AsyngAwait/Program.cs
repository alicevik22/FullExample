using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_AsyngAwait {
    class Program {
        static void Main(string[] args) {
            StartAsyng();
            Console.WriteLine("---------");
            StartBackgroundWorker();
            //Console.WriteLine("---------");
            Console.ReadKey();
        }
        //---------
        private static async void StartAsyng() {
            Console.WriteLine("start async");
            await Task.Run(() => TaskRun());
            await Task.Delay(1000);
            Console.WriteLine("end async");
        }
        private static void TaskRun() {
            for (int i = 5; i >= 0; i--) {
                Task.Delay(300);
                Console.WriteLine("T1 " + i);
            }
        }
        //---------
        private static void StartBackgroundWorker() {
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += (o, e) => TaskRun2(1);
            bw.RunWorkerAsync();
        }
        private static void TaskRun2(int times) {
            for (int i = 5; i >= 0; i--) {
                Task.Delay(300);
                Console.WriteLine("T2 " + i);
            }
        }
        //---------


        //=============    параллельное выполнение !!!
        void parallel() {
            List<string> list = new List<string> {
                "1.txt","2.txt","3.txt"
        };
            list.AsParallel().ForAll(x => {
                File.Delete(x); ///удаляем все из листа
            });

        }


    }
}

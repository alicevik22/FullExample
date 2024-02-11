using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _21_AsyngAwait {
    class Program {
        static void Main(string[] args) {
            StartAsyng();
            Console.WriteLine("---------");
            StartBackgroundWorker();
            Console.WriteLine("---------");

            TestToken();
            Console.ReadKey();
        }

        // ---------
        // запуск асинхронной задачи
        private static async void StartAsyng() {
            Console.WriteLine("start async");
            await Task.Run(() => TaskRun());
            await Task.Delay(1000);
            Console.WriteLine("end async");
        }
        private static void TaskRun() {
            for (int i = 5; i >= 0; i--) {
                Task.Delay(300).Wait();
                Console.WriteLine("T1 " + i);
            }
        }
        // ---------
        // еще вариант запуска задачи
        private static void StartBackgroundWorker() {
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += (o, e) => TaskRun2(1);
            bw.RunWorkerAsync();
        }
        private static void TaskRun2(int times) {
            for (int i = 5; i >= 0; i--) {
                Task.Delay(300).Wait();
                Console.WriteLine("T2 " + i);
            }
        }
        //---------
        // Выходим из асинхронной задачи по токину
        static CancellationTokenSource cts = new CancellationTokenSource();//отмена потока
        static int cnt = 0;

        private static void TestToken() {
            CancellationToken ct = cts.Token;// сигнал на отмену
            Task task = new Task(() => { ProcessRunLine(); }, cts.Token);
            task.Start();
        }
        private static void ProcessRunLine() {
            while (true) {
                if (cts.IsCancellationRequested) { // проверяем наличие сигнала отмены задачи
                    return;
                }
                Task.Delay(1000).Wait();
                Console.WriteLine(cnt++);
                if (cnt > 5)// отключаем в любом месте
                    cts.Cancel();
            }
        }
        //---------
        // так же можно жостко выйти из задачи используя исключение и др
        //https://metanit.com/sharp/tutorial/12.5.php

        //=============    параллельное выполнение !!!
        void parallel() {
            List<string> list = new List<string> {
                "1.txt","2.txt","3.txt"
            };
            list.AsParallel().ForAll(x => {
                File.Delete(x); ///удаляем все файлы из List
            });

        }


    }
}

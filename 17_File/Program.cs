using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_File {
    class Program {
        static void Main(string[] args) {

            string path = @"C:\1.txt";
            //========= проверка на существование
            if (File.Exists(path)) {}
            
            //========= Запись
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate)) {
                //fs.Seek(0, SeekOrigin.End);//обращаемся в конец всего текста
                using (StreamWriter sw = new StreamWriter(path, true)) {// дозаписываем(true)
                    sw.WriteAsync("sdfa");//добавляет надпись в строку
                    sw.WriteLineAsync("sdfa");//добавляет надпись с новой строки
                }
            }
            //========= Чтение



            // не испоьзовать
            //========= Чтение всего текста
            string linee = File.ReadAllText(@"C:\1.txt");

            //========= Чтение нескольких строк
            string[] lines = File.ReadAllLines(@"C:\2.txt");
            foreach (string line in lines) {
                if(line.Contains("find")){;}
            }
            //========= Delete exepption не вызывает
            File.Delete(path);
            File.Copy(path, path.Replace(path, "new.txt"), true);
            File.Move(path, path.Replace(path, "new.txt"));

            
            //=========
            //=========
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_types {
    class Program {
        static void Main(string[] args) {
            string _str = "10";
            int _int = 20;
            double _double = 5.4;
            //=========  to String
            _str = _int.ToString();
            _str = _double.ToString("0.00");
            //=========  to int
            _int = Int32.Parse(_str);
            _int = (int)_double;
            //=========  to double
            _double = double.Parse(_str);
            _double = (double)_int;

            //=========  String
            _str = _str.Replace("Е", "А");// Е меняет на А
            if (_str.Contains("A")) { } // если есть в слове
            _str = _str.Remove(1, 2);// от 1й удили 2 буквы
            _str = _str.Trim(); // удалить пробелы и др
            _str = _str.ToLower(); // в нижний регистр
            _str = _str.ToUpper(); // в верхний регистр

            if (!String.IsNullOrEmpty(textBox1.Text)){}// проверка на null


            //=========  парсинг с разделителем в doble
            string str = "5.9";
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo() {
                NumberDecimalSeparator = "."
            };
            double a = double.Parse(str, numberFormatInfo);

            //========= HEX
            _int = int.Parse(_str, System.Globalization.NumberStyles.HexNumber);
            byte[] data = new byte[] { 90, 00, 254, 100, 48, 75 };
            string hexString = BitConverter.ToString(data);
            //decimal to hex
            string hexValue = _int.ToString("X");
            //hex to decimal
            int decValue = int.Parse(hexValue, System.Globalization.NumberStyles.HexNumber);
            //string hex to byte[]
            data = StringToByteArray("FFFA");

            //=========  Array
            int[] MyArray = new int[10];
            Array.Sort(MyArray);// сортировка
            _int = MyArray.Max();// поиск максимального
            //_int = MyArray[^1]; //1й с конца

            var newArray = MyArray.Reverse();
            _str = string.Join(Environment.NewLine, newArray);//Join разберется с любым типом

            //First you'll need to get it into a byte[], so do this:
            byte[] ba = Encoding.Default.GetBytes("sample");
            //and then you can get the string:
            hexString = BitConverter.ToString(ba);

            //=========  list
            var list = new List<string> {
                "1","2","3",
            };
            var newlist = list.Union(list);//обединение
            newlist = list.Skip(1);//пропускаем элемент 2 3
            newlist = list.Distinct();//убрать дублиаты
            list.All(x => x.Contains("R"));//true если все с R
            list.Any(x => x.Contains("R"));//true если хоть одна с R

            //каждый x проходит проверку на F
            newlist = list.Where(x => x.Contains("F"));//выборка всех с символом "F"

            //создание списка булевых значний
            var newbool = list.Select(x => x.Contains("F"));//выборка всех с символом "F"

            //добавитм нумирацию
            int i = 1;
            //newlist = list.Select(x => $"{i++} {x}");//11,22,33

            //сортировка
            newlist = list.OrderBy(x => x);//сортировка

            //показать дубликат
            newlist = list.GroupBy(x => x).Where(x => x.Count() > 1).Select(x => x.Key);



            _str = string.Join(Environment.NewLine, newlist);//Join разберется с любым типом
            Console.WriteLine(_str);


            //=========  BindingList
            /*public BindingList<findOnIdModels> idDataList = new BindingList<findOnIdModels>() { 
                new findOnIdModels(){id = "103C940", numStart = 15},
                new findOnIdModels(){id = "904201F", numStart = 15},
            };
            idDataList[i].id = words[0];
            */


            //=========
            //=========
            Console.ReadKey();
        }
        //=========  ссылки
        //ref ввод данных по ссылке
        void F(ref int width) { }
        //out вывод данных по ссылке
        void FF(out int width) { width = 0; }
        //in параметр передается по ссылке но не может быть изменен
        //void FFF(in int width){}

        public static byte[] StringToByteArray(string hex) {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }
    }
}

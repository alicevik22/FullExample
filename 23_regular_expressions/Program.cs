using System;
using System.Text.RegularExpressions;

namespace _23_regular_expressions {
    class Program {
        static void Main(string[] args) {
            /* Регулярные выражения
             * онлайн среда:    https://regex101.com/r/fx5t1t/1
             * оф сайт:         https://learn.microsoft.com/en-us/dotnet/standard/base-types/regular-expression-language-quick-reference
             * шпаргалка:       https://website-lab.ru/article/regexp/shpargalka_po_regulyarnyim_vyirajeniyam/
            */
            string line = "\"00:08:46.623\";\"103C940\";\"Ext\";\"2\";\"F0 F1 2A\"";
            //------------------------------------
            //Regex regex = new Regex(@"(\w+)", RegexOptions.Compiled);                             // все цифры и буквы по порядку
            //Regex regex = new Regex("(?<=\";\")[0-F]{2}\\s", RegexOptions.Compiled);              // data (12)
            //Regex regex = new Regex("\"\\w+\"(?=\\;\"(E|S))", RegexOptions.Compiled);             // "id"
            //Regex regex = new Regex("\\w+(?=\";\"(E|S))", RegexOptions.Compiled);                 // id
            Regex regex = new Regex("(?<=\";\")[0-F]{2}(?=\\s)|(?<=\\s)[0-F]{2}", RegexOptions.Compiled); // data по порядку
            MatchCollection matches = regex.Matches(line);
            if (matches.Count > 0) {
                foreach (Match match in matches)
                    Console.WriteLine(match.Value);
            } else {
                Console.WriteLine("Совпадений не найдено");
            }
            Console.WriteLine("---------");
            //------------------------------------
            // меняем местами найденные элементы
            string text = Regex.Replace(line,   // исходная строка
                @"\S*(?<byte0>[0-F]{2})\s(?<byte1>[0-F]{2})\s.+", // шаблон
                "${byte1}-${byte0}");  // ф-я изменения
            Console.WriteLine(text);
            Console.WriteLine("---------");
            //------------------------------------
            // инкрементируем 623, 103, 940
            text = Regex.Replace(line,
                "(?<=.)[0-9]{3}",
                m => (int.Parse(m.Value) + 1).ToString());
            Console.WriteLine(text);
            Console.WriteLine("---------");
            //------------------------------------
            // заменяем все <> на []
            string testString = "<b>Hello, <i>world</i></b>";
            Regex regex2 = new Regex("<(?<tagName>[^>]+)>");
            string cleanString = regex2.Replace(testString, "[${tagName}]");
            Console.WriteLine(cleanString);
            Console.WriteLine("---------");
            //------------------------------------
            // прочее:
            //заменяем "-" на " "
            text = Regex.Replace(text, "([-]+)", " ");
            //------------------------------------
            Console.ReadKey();
        }
    }
}

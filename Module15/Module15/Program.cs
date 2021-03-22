using System;
using System.Collections.Generic;
using System.Linq;

namespace Module15
{
    class Program
    {
        //   статическая переменная для хранения данных в памяти
        public static List<int> Numbers = new List<int>();
        static void Main(string[] args)
        {
            //  объявляем две коллекции
            var letters = new string[] { "A", "B", "C", "D", "E" };
            var numbers = new int[] { 1, 2, 3 };

            // проводим "упаковку" элементов, сопоставляя попарно
            var q = letters.Zip(numbers, (l, n) => l + n.ToString());

            // вывод
            foreach (var s in q)
                Console.WriteLine(s);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Module15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");

            // читаем ввод
            var text = Console.ReadLine();

            // сохраняем список знаков препинания и символ пробела в коллекцию
            var punctuation = new List<char>() { ' ', ',', '.', ';', ':', '!', '?' };

            // валидация ввода
            if (string.IsNullOrEmpty(text))
            {
                Console.WriteLine("Вы ввели пустой текст");
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Текст без знаков препинания: ");

            // так как строка - это массив char, мы можем вызвать метод  except  и удалить знаки препинания
            var noPunctuation = text.Except(punctuation).ToArray();

            // вывод
            Console.WriteLine(noPunctuation);
        }

        static int CountCommon(string word1, string word2)
        {
            var amount = word1.Intersect(word2)//   ищем пересечение
     .Count(); // считаем количество
            return amount;
        }
    }
}

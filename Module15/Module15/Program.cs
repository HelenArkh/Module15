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
            var cars = new List<Car>()
{
   new Car("Suzuki", "JP"),
   new Car("Toyota", "JP"),
   new Car("Opel", "DE"),
   new Car("Kamaz", "RUS"),
   new Car("Lada", "RUS"),
   new Car("Honda", "JP"),
};

            var carsByCountry2 = cars
    .GroupBy(car => car.CountryCode)
    .Select(g => new
    {
        Name = g.Key,
        Count = g.Count(),
        Cars = g.Select(c => c)
    });

            // Выведем результат
            foreach (var group in carsByCountry2)
            {
                // Название группы и количество элементов
                Console.WriteLine($"{group.Name} : {group.Count} авто");

                foreach (Car car in group.Cars)
                    Console.WriteLine(car.Manufacturer);

                Console.WriteLine();
            }
        }

        static int CountCommon(string word1, string word2)
        {
            var amount = word1.Intersect(word2)//   ищем пересечение
     .Count(); // считаем количество
            return amount;
        }
    }
}

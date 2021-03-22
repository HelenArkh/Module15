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
            var students = new List<Student>
{
   new Student {Name="Андрей", Age=23 },
   new Student {Name="Сергей", Age=27 },
   new Student {Name="Дмитрий", Age=29 }
};

            var youngStudents = students
   .Where(s => s.Age < 25) // на этом этапе происходит генерация LINQ-выражения
  .ToArray(); // А вот тут уже будет выполнение

            // Добавим нового студента уже после инициализанции LINQ-запроса
            students.Add(new Student { Name = "Анна", Age = 21 });

            foreach (var stud in youngStudents)
                Console.WriteLine(stud.Name);
        }
    }
}

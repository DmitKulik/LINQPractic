using System.Reflection;
using static LINQPractic.Program;

namespace LINQPractic
{



    // Задание 14.1.1
    //А теперь попробуйте выбрать все города, название у которых не длиннее 10 букв, и отсортируйте их по длине названия.
    internal class Program
    {
        static void Main(string[] args)
        {
            // Добавим Россию с её городами
            var russianCities = new List<City>();
            russianCities.Add(new City("Москва", 11900000));
            russianCities.Add(new City("Санкт-Петербург", 4991000));
            russianCities.Add(new City("Волгоград", 1099000));
            russianCities.Add(new City("Казань", 1169000));
            russianCities.Add(new City("Севастополь", 449138));
 
            foreach (var city1 in russianCities.Where(f => f.Name.Length <= 10).OrderBy(f => f.Name.Length))
                     Console.WriteLine(@$"Город " + city1.Name);

        }

        
        // Создадим модель класс для города
        public class City
        {
            public City(string name, long population)
            {
                Name = name;
                Population = population;
            }

            public string Name { get; set; }
            public long Population { get; set; }

            
        }



    }
}


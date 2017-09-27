using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Films
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Это программа для подбора фильмов.");
            Console.WriteLine("Как вас зовут?");
            String name = Console.ReadLine();
            Console.WriteLine("Добрый вечер, " + name + "!");
            Console.WriteLine("Фильм какого жанра Вам бы хотелось посмотреть: комедия, драма, эротика, боевик, триллер или фантастика?");

            while (true)
            {
                String ask_genre = Console.ReadLine();

                if (ask_genre == "комедия")
                {
                    Console.WriteLine("В таком случае могу Вам предложить посмотреть следующие фильмы:");
                    Console.WriteLine("* Американский пирог");
                    Console.WriteLine("* Мальчишник в Вегасе");
                    Console.WriteLine("* Муви 43");
                    break;
                }
                else if (ask_genre == "драма")
                {
                    Console.WriteLine("В таком случае могу Вам предложить посмотреть следующие фильмы:");
                    Console.WriteLine("* Побег из Шоушенка");
                    Console.WriteLine("* Форест Гамп");
                    Console.WriteLine("* Лион");
                    break;
                }
                else if (ask_genre == "эротика")
                {
                    Console.WriteLine("Сколько Вам лет?");
                    String ageString = Console.ReadLine();
                    int age = Int32.Parse(ageString);

                    if (age < 18)
                    {
                        Console.WriteLine("К сожаления, этот жанр доступ только для пользователей 18+.");
                        Console.WriteLine("Введите другой жанр.");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("В таком случае могу Вам предложить посмотреть следующие фильмы:");
                        Console.WriteLine("* Нимфоманка");
                        Console.WriteLine("* Нимфоманка 2");
                        break;
                    }
                }
                else if (ask_genre == "боевик")
                {
                    Console.WriteLine("В таком случае могу Вам предложить посмотреть следующие фильмы:");
                    Console.WriteLine("* Большой куш");
                    Console.WriteLine("* Терминатор");
                    Console.WriteLine("* Гладиатор");
                    break;
                }
                else if (ask_genre == "триллер")
                {
                    Console.WriteLine("В таком случае могу Вам предложить посмотреть следующие фильмы:");
                    Console.WriteLine("* Большой куш");
                    Console.WriteLine("* Терминатор");
                    Console.WriteLine("* Гладиатор");
                    break;
                }
                else if (ask_genre == "фантастика")
                {
                    Console.WriteLine("В таком случае могу Вам предложить посмотреть следующие фильмы:");
                    Console.WriteLine("* Черепашки ниндзя");
                    Console.WriteLine("* Люди Х");
                    break;
                }
                else
                {
                    Console.WriteLine("Такой жанр не найден! Повторите попытку.");
                }
            }
            Console.WriteLine("До новых встреч!");
            Console.ReadLine();
        }
    }
}

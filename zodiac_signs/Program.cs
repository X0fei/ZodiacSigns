using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zodiac_signs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ВЫЧИСЛИТЕЛЬ ЗНАКА ЗОДИАКА ПО ДАТЕ РОЖДЕНИЯ");
            Console.WriteLine("\nВведите день, затем нажмите Enter");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nВведите месяц (числом), затем нажмите Enter");
            int month = Convert.ToInt32(Console.ReadLine());
            if (((day < 1) || (day > 31)) || ((month < 1) || (month > 12)))
                Console.WriteLine("\nТАКОЙ ДАТЫ НЕ СУЩЕСТВУЕТ");
            else
            {
                Console.Write("\nЗнак зодиака: ");
                if (((day >= 21) & (month == 3)) || ((day <= 20) & (month == 4)))
                    Console.WriteLine("Овен");
                else
                {
                    if (((day >= 21) & (month == 4)) || ((day <= 20) & (month == 5)))
                        Console.WriteLine("Телец");
                    else
                    {
                        if (((day >= 21) & (month == 5)) || ((day <= 21) & (month == 6)))
                            Console.WriteLine("Близнецы");
                        else
                        {
                            if (((day >= 22) & (month == 6)) || ((day <= 22) & (month == 7)))
                                Console.WriteLine("Рак");
                            else
                            {
                                if (((day >= 23) & (month == 7)) || ((day <= 22) & (month == 8)))
                                    Console.WriteLine("Лев");
                                else
                                {
                                    if (((day >= 23) & (month == 8)) || ((day <= 23) & (month == 9)))
                                        Console.WriteLine("Дева");
                                    else
                                    {
                                        if (((day >= 24) & (month == 9)) || ((day <= 23) & (month == 10)))
                                            Console.WriteLine("Весы");
                                        else
                                        {
                                            if (((day >= 24) & (month == 10)) || ((day <= 22) & (month == 11)))
                                                Console.WriteLine("Скорпион");
                                            else
                                            {
                                                if (((day >= 23) & (month == 11)) || ((day <= 21) & (month == 12)))
                                                    Console.WriteLine("Стрелец");
                                                else
                                                {
                                                    if (((day >= 22) & (month == 12)) || ((day <= 20) & (month == 1)))
                                                        Console.WriteLine("Козерог");
                                                    else
                                                    {
                                                        if (((day >= 21) & (month == 1)) || ((day <= 18) & (month == 2)))
                                                            Console.WriteLine("Водолей");
                                                        else
                                                        {
                                                            if (((day >= 19) & (month == 2)) || ((day <= 20) & (month == 3)))
                                                                Console.WriteLine("Рыбы");
                                                        };
                                                    };
                                                };
                                            };
                                        };
                                    };
                                };
                            };
                        };
                    };
                };
            };
        }
    }
}

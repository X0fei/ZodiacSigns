using System;

namespace ZodiacSigns
{
    internal class Program
    {
        static void Main()
        {
            Console.Title = "Вычислитель знака зодиака по дате рождения";
            Console.Write("Введите день рождения: ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите месяц рождения: ");
            int month = Convert.ToInt32(Console.ReadLine());
            if (day > 0 && day <= 31 && month > 0 && month <= 12)
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
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
                Console.WriteLine("\nОШИБКА!!! Такой даты не существует\nПопробуйте ещё раз");
        }
    }
}

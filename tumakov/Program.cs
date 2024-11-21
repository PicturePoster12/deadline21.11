using System;
class Laba
{
    static int[] daysInMonth = [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];
    static string[] months = [" января", " февраля", " марта", " апреля", " мая", " июня", " июля", " августа", " сентября", " октября", " ноября", " декабря"];
    static void Main()
    {
        Task1();
        Task2();
        Task3();
    }
    static void Task1()
    {
        try
        {
            Console.WriteLine("4.1");
            Console.WriteLine("Введите число от 1 до 365:");
            int monthDays1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 12; ++i)
            {
                if (monthDays1 > daysInMonth[i])
                {
                    monthDays1 -= daysInMonth[i];
                }
                else
                {
                    Console.WriteLine(monthDays1 + months[i]);
                    break;
                }
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Неверный ввод");
        }
    }
    static void Task2()
    {
        Console.WriteLine("4.2");
        try
        {
            Console.WriteLine("Введите число от 1 до 365:");
            int monthDays2 = Convert.ToInt32(Console.ReadLine());
            if (monthDays2 > 0 & monthDays2 < 366)
            {
                for (int i = 0; i < 12; ++i)
                {
                    if (monthDays2 > daysInMonth[i])
                    {
                        monthDays2 -= daysInMonth[i];
                    }
                    else
                    {
                        Console.WriteLine(monthDays2 + months[i]);
                        break;
                    }
                }
            }
            else
            {
                throw new Exception();
            }
        }
        catch
        {
            Console.WriteLine("Неверный ввод");
        }
    }
    static void Task3()
    {
        Console.WriteLine("dz4.1");
        try
        {
            Console.WriteLine("Введите год:");
            int god = Convert.ToInt32(Console.ReadLine());
            if (god % 4 == 0 & (god % 100 != 0 | god % 400 == 0))
            {
                int[] daysInMonthVis = [31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];
                Console.WriteLine("Введите число от 1 до 366:");
                int monthDays3 = Convert.ToInt32(Console.ReadLine());
                if (monthDays3 > 0 & monthDays3 < 367)
                {
                    for (int i = 0; i < 12; ++i)
                    {
                        if (monthDays3 > daysInMonthVis[i])
                        {
                            monthDays3 -= daysInMonthVis[i];
                        }
                        else
                        {
                            Console.WriteLine(monthDays3 + months[i]);
                            break;
                        }
                    }
                }
                else
                {
                    throw new Exception();
                }
            }
            else
            {
                Console.WriteLine("Введите число от 1 до 365:");
                int monthDays3 = Convert.ToInt32(Console.ReadLine());
                if (monthDays3 > 0 & monthDays3 < 365)
                {
                    for (int i = 0; i < 12; ++i)
                    {
                        if (monthDays3 > daysInMonth[i])
                        {
                            monthDays3 -= daysInMonth[i];
                        }
                        else
                        {
                            Console.WriteLine(monthDays3 + months[i]);
                            break;
                        }
                    }
                }
                else
                {
                    throw new Exception();
                }
            }
        }
        catch
        {
            Console.WriteLine("Неверный ввод");
        }
    }
}
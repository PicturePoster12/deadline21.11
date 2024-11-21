using System;
class Program
{
    public enum NameOfDay
    {
        Понедельник = 1,
        Вторник = 2,
        Среда = 3,
        Четверг = 4,
        Пятница = 5,
        Суббота = 6,
        Воскресенье = 7,
    }
    static void Main()
    {
        Console.WriteLine("1.");
        try
        {
            Console.WriteLine("Введите 10 чисел в столбик:");
            double[] posled = new double[10];
            int k = 0;
            int nomer = 0;
            for (int i = 0; i < 10; ++i)
            {
                posled[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < 9; i++)
            {
                if (posled[i] < posled[i + 1])
                {
                    k++;
                }
                else
                {
                    nomer = i + 2;
                    break;
                }
            }
            if (k == 9)
            {
                Console.WriteLine("Упорядочена по возрастанию");
            }
            else
            {
                Console.WriteLine("Не упорядочена");
                Console.WriteLine("Номер первого числа, нарушающего последовательность = " + nomer);
            }
        }
        catch
        {
            Console.WriteLine("Неверный ввод");
        }

        Console.WriteLine("2.");
        try
        {
            Console.WriteLine("Введите номер карты(6 - 14):");
            int k = Convert.ToInt32(Console.ReadLine());
            if (k < 6 | k > 14)
            {
                throw new Exception();
            }
            else
            {
                switch (k)
                {
                    case 6: Console.WriteLine("Шестёрка");
                        break;
                    case 7: Console.WriteLine("Семёрка");
                        break;
                    case 8: Console.WriteLine("Восьмёрка");
                        break;
                    case 9: Console.WriteLine("Девятка");
                        break;
                    case 10: Console.WriteLine("Десятка");
                        break;
                    case 11: Console.WriteLine("Валет");
                        break;
                    case 12: Console.WriteLine("Дама");
                        break;
                    case 13: Console.WriteLine("Король");
                        break;
                    case 14: Console.WriteLine("Туз");
                        break;
                }
            }
        }
        catch
        {
            Console.WriteLine("Неверный ввод");
        }

        Console.WriteLine("3.");
        string input = Console.ReadLine();
        input = input[0].ToString().ToUpper() + input.Substring(1).ToLower();
        switch (input)
        {
            case "Jabroni": Console.WriteLine("Parton Tequila");
                break;
            case "School Counselor": Console.WriteLine("Anything with Alchogol");
                break;
            case "Programmer": Console.WriteLine("Hipster Craft Beer");
                break;
            case "Bike Gang Member": Console.WriteLine("Moonshine");
                break;
            case "Politician": Console.WriteLine("Your tax dollars");
                break;
            case "Rapper": Console.WriteLine("Cristal");
                break;
            default: Console.WriteLine("Beer");
                break;
        }
        
        Console.WriteLine("4.");
        try
        {
            Console.WriteLine("Введите число от 1 до 7:");
            int day = Convert.ToInt32(Console.ReadLine());
            
            if (day < 1 | day > 7)
            {
                throw new FormatException();
            }
            else
            {
                Console.WriteLine((NameOfDay)day);
            }
        }
        catch(FormatException)
        {
            Console.WriteLine("Неверный ввод");
        }
        
        Console.WriteLine("5.");
        string[] toys = ["Hello Kitty", "Transformer", "My Little Pony", "Hello Kitty", "Barbie doll", "Lego", "Duplo", "Hot Wheels", "Barbie doll"];
        int result = 0;
        foreach (string toy in toys)
        {
            if (toy == "Barbie doll" | toy == "Hello Kitty")
            {
                result++;
            }
        }
        Console.WriteLine(result);
    }
}
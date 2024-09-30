//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Введите коэффициенты квадратного уравнения (a, b, c):");
//        double a = Convert.ToDouble(Console.ReadLine());
//        double b = Convert.ToDouble(Console.ReadLine());
//        double c = Convert.ToDouble(Console.ReadLine());

//        double discriminant = b * b - 4 * a * c;

//        if (discriminant > 0)
//        {
//            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
//            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
//            Console.WriteLine($"Корни уравнения: x1 = {x1}, x2 = {x2}");
//        }
//        else if (discriminant == 0)
//        {
//            double x = -b / (2 * a);
//            Console.WriteLine($"Уравнение имеет один корень: x = {x}");
//        }
//        else
//        {
//            Console.WriteLine("Уравнение не имеет действительных корней.");
//        }
//    }
//}


//using System;

//class Program
//{
//    static void Main()
//    {
//        // Ввод числа для вычисления факториала
//        Console.WriteLine("Введите число для вычисления факториала:");
//        int n = Convert.ToInt32(Console.ReadLine());

//        // Вычисление факториала
//        long factorial = 1;
//        for (int i = 1; i <= n; i++)
//        {
//            factorial *= i;
//        }

//        // Вывод результата
//        Console.WriteLine($"Факториал числа {n} = {factorial}");
//    }
//}


//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Введите количество строк в массиве:");
//        int n = Convert.ToInt32(Console.ReadLine());

//        string[] array = new string[n];
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine($"Введите строку {i + 1}:");
//            array[i] = Console.ReadLine();
//        }

//        Console.WriteLine("Введите строковый фрагмент для поиска:");
//        string searchFragment = Console.ReadLine();

//        Console.WriteLine("Результаты поиска:");
//        bool found = false;
//        foreach (string str in array)
//        {
//            if (str.IndexOf(searchFragment) != -1)
//            {
//                Console.WriteLine(str);
//                found = true;
//            }
//        }

//        if (!found)
//        {
//            Console.WriteLine("Строк с данным фрагментом не найдено.");
//        }
//    }
//}

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        double[] profits = new double[7];

        Console.WriteLine("Введите прибыль за каждый из 7 дней:");
        for (int i = 0; i < profits.Length; i++)
        {
            Console.Write($"День {i + 1}: ");
            profits[i] = Convert.ToDouble(Console.ReadLine());
        }

        int maxProfitDay = Array.IndexOf(profits, profits.Max()) + 1;
        int minProfitDay = Array.IndexOf(profits, profits.Min()) + 1;
        Console.WriteLine($"День с максимальной прибылью: {maxProfitDay}");
        Console.WriteLine($"День с минимальной прибылью: {minProfitDay}");

        double maxProfit = profits.Max();
        int consecutiveDays = 0, maxConsecutiveDays = 0;
        foreach (var profit in profits)
        {
            if (profit == maxProfit)
            {
                consecutiveDays++;
                maxConsecutiveDays = Math.Max(maxConsecutiveDays, consecutiveDays);
            }
            else
            {
                consecutiveDays = 0;
            }
        }
        Console.WriteLine($"Максимальная прибыль держалась {maxConsecutiveDays} день(-я) подряд.");

        double oddDayProfitSum = 0;
        int oddDayCount = 0;
        for (int i = 0; i < profits.Length; i++)
        {
            if ((i + 1) % 2 != 0) 
            {
                oddDayProfitSum += profits[i];
                oddDayCount++;
            }
        }
        double oddDayProfitAverage = oddDayProfitSum / oddDayCount;
        Console.WriteLine($"Средняя прибыль для дней с нечетным порядковым номером: {oddDayProfitAverage}");

        Console.WriteLine("Введите число a:");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите число b:");
        double b = Convert.ToDouble(Console.ReadLine());

        for (int i = 0; i < profits.Length; i++)
        {
            if (profits[i] < a)
            {
                profits[i] = b;
            }
        }

        Console.WriteLine("Измененный массив прибыли:");
        for (int i = 0; i < profits.Length; i++)
        {
            Console.WriteLine($"День {i + 1}: {profits[i]}");
        }
    }
}



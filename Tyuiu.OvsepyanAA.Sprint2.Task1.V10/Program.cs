using Tyuiu.OvsepyanAA.Sprint2.Task1.V10.Lib;

namespace Tyuiu.OvsepyanAA.Sprint2.Task1.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Овсепян А.А | Смартб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Овсепян Арам Андраникович | Смартб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
            Console.WriteLine("* последовательность можно чередовать, но использовать один раз в выражени*");
            Console.WriteLine("* и логических операций (|, &, ||, &&, !, ^, последовательность операций  *");
            Console.WriteLine("* не должна нарушаться), а также арифметических выражений, которая вернет *");
            Console.WriteLine("* нлогическую последовательность(массив): (True, False, False, False, True*");
            Console.WriteLine("* False), при a = 455, b = 335, c = 14, d = 17                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int a, b, c, d;
            a = 455;
            b = 335;
            c = 14;
            d = 17;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }



            Console.ReadKey();
        }
    }
}

using Tyuiu.OvsepyanAA.Sprint2.Task3.V21.Lib;

namespace Tyuiu.OvsepyanAA.Sprint2.Task3.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Овсепян Арам Андраникович | СМАРТб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: <Опрации сравнения>                                               *");
            Console.WriteLine("*                              Задание #3                                 *");
            Console.WriteLine("*                              Вариант #21                                *");
            Console.WriteLine("* Выполнил: Овсепян Арам Андраникович   | СМАРТб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                  УСЛОВИЕ:                               *");
            Console.WriteLine("*      Написать программу, которая отвечает всем требованиям задания.     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                               ИСХОДНЫЕ ДАННЫЕ:                          *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите значение X: ");
            double x = double.Parse(Console.ReadLine());



            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("***************************************************************************");

            double y = ds.Calculate(x);
            Console.WriteLine($"Значение Y: {y}");

            Console.ReadKey();
        }
    }
}

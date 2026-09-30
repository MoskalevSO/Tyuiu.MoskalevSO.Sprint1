using System;
using Tyuiu.MoskalevSO.Sprint1.Task4.V12.Lib;

// ЗАДАНИЕ
// Написать программу, которая запрашивает у пользователя исходные данные,
// вычисляет результат по формуле и печатает его на экране.
// Ответ округлить до 3 знаков после запятой.

namespace Tyuiu.MoskalevSO.Sprint1.Task4.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            double res = ds.Calculate(x, y);
            Console.WriteLine("Результат = " + res);

            Console.ReadKey();
        }
    }
}
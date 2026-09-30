using System;
using Tyuiu.MoskalevSO.Sprint1.Task5.V3.Lib;

namespace Tyuiu.MoskalevSO.Sprint1.Task5.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.Write("Введите положительное целое число k: ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            int res = ds.Calculate(k);

            Console.WriteLine("Третья цифра с конца = " + res);

            Console.ReadKey();
        }
    }
}
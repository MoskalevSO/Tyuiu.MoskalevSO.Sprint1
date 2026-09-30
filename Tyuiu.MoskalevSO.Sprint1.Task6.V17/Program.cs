using System;
using Tyuiu.MoskalevSO.Sprint1.Task6.V17.Lib;

namespace Tyuiu.MoskalevSO.Sprint1.Task6.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

 
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.Write("Введите текст: ");
            string text = Console.ReadLine();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            bool res = ds.CheckPalindrome(text);
            Console.WriteLine("Строка является палиндромом = " + res);

            Console.ReadKey();
        }
    }
}
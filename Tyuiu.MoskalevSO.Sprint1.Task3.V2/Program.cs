using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MoskalevSO.Sprint1.Task3.V2.Lib;

namespace Tyuiu.MoskalevSO.Sprint1.Task3.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.Write("Цена тетради: ");
            double notebookPrice = Convert.ToDouble(Console.ReadLine());

            Console.Write("Количество тетрадей: ");
            int notebookCount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Цена карандаша: ");
            double pencilPrice = Convert.ToDouble(Console.ReadLine());

            Console.Write("Количество карандашей: ");
            int pencilCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            double res = ds.PurchaseAmount(notebookPrice, notebookCount, pencilPrice, pencilCount);
            Console.WriteLine("Стоимость покупки = " + res);

            Console.ReadKey();
        }
    }
}
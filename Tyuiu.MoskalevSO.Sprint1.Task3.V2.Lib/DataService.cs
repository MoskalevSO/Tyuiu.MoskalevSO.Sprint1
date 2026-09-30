using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MoskalevSO.Sprint1.Task3.V2.Lib
{
    public class DataService : ISprint1Task3V2
    {
        public double PurchaseAmount(double notebookPrice, int notebookCount, double pencilPrice, int pencilCount)
        {
            double res = notebookPrice * notebookCount + pencilPrice * pencilCount;
            return Math.Round(res, 3);
        }
    }
} 
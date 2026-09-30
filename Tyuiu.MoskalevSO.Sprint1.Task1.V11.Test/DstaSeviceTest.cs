
using Tyuiu.MoskalevSO.Sprint1.Task1.V11.Lib;

namespace Tyuiu.MoskalevSO.Sprint1.Task1.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            double res = ds.Calculate(x, y);
            double wait = 0.417;
            Assert.AreEqual(wait, Math.Round(res, 3));
        }
    }
}
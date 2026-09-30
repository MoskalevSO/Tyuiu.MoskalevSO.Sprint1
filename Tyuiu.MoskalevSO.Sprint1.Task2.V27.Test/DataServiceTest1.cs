using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MoskalevSO.Sprint1.Task1.V27.Lib;

namespace Tyuiu.MoskalevSO.Sprint1.Task1.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int a = 5;
            int res = ds.CalculateSquarePerimetr(a);
            int wait = 20;
            Assert.AreEqual(wait, res);
        }
    }
}
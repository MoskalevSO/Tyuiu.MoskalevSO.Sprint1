using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MoskalevSO.Sprint1.Task3.V2.Lib;

namespace Tyuiu.MoskalevSO.Sprint1.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double res = ds.PurchaseAmount(10.5, 2, 3.25, 4);
            double wait = 34;
            Assert.AreEqual(wait, res);
        }
    }
}
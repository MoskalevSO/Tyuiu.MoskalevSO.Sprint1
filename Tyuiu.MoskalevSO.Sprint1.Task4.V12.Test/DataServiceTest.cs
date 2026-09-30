using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MoskalevSO.Sprint1.Task4.V12.Lib;

namespace Tyuiu.MoskalevSO.Sprint1.Task4.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(1, 4);
            double wait = 0;
            Assert.AreEqual(wait, res);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MoskalevSO.Sprint1.Task7.V29.Lib;

namespace Tyuiu.MoskalevSO.Sprint1.Task7.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            double res = ds.Calculate(2, 2);
            double wait = 2.141;

            Assert.AreEqual(wait, res);
        }
    }
}
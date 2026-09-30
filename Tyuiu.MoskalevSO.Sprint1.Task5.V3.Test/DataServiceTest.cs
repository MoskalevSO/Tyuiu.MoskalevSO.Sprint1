using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MoskalevSO.Sprint1.Task5.V3.Lib;

namespace Tyuiu.MoskalevSO.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int res = ds.Calculate(130985);
            int wait = 9;
            Assert.AreEqual(wait, res);
        }
    }
}
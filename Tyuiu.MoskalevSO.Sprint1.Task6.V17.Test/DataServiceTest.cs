using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MoskalevSO.Sprint1.Task6.V17.Lib;

namespace Tyuiu.MoskalevSO.Sprint1.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckPalindrome()
        {
            DataService ds = new DataService();

            bool res = ds.CheckPalindrome("шалаш");

            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
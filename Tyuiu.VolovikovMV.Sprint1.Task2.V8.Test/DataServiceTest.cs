using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VolovikovMV.Sprint1.Task2.V8.Lib;

namespace Tyuiu.VolovikovMV.Sprint1.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int a = 2, b = 2;
            var res = ds.CalculatePerimetr(a, b);
            Assert.AreEqual(8, res);
        }
    }
}

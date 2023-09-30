using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VolovikovMV.Sprint1.Task7.V10.Lib;

namespace Tyuiu.VolovikovMV.Sprint1.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double wait = -13.142;
            Assert.AreEqual(wait, ds.Calculate(x));
        }
    }
}

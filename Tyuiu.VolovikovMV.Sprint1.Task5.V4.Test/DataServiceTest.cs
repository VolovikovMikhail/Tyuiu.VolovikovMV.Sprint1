using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VolovikovMV.Sprint1.Task5.V4.Lib;

namespace Tyuiu.VolovikovMV.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int time = 38542;
            var res = ds.SecondsToHours(time);
            Assert.AreEqual(10, res);
        }
    }
}

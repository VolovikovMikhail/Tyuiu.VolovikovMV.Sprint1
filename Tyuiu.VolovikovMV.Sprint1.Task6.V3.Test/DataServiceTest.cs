using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VolovikovMV.Sprint1.Task6.V3.Lib;

namespace Tyuiu.VolovikovMV.Sprint1.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Парипури парирам тумба юмба альашт бапешь";
            DataService ds = new DataService();
            string res = ds.LastLetterWord(strTest);
            string wait = "имаать";
            Assert.AreEqual(wait, res);
        }
    }
}

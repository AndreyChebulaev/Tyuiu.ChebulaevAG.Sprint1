using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChebulaevAG.Sprint1.Task2.V0.Lib;

namespace Tyuiu.ChebulaevAG.Sprint1.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int r = 2;
            var res = ds.CalculateVolumeCircle(r);
            Assert.AreEqual(33.510, res);
        }
    }
}

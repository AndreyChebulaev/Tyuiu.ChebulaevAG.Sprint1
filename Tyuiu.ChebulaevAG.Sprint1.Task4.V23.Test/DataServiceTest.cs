using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChebulaevAG.Sprint1.Task4.V23.Lib;

namespace Tyuiu.ChebulaevAG.Sprint1.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 3.0;
            double wait = 2.236;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res, 0.001);
        }
    }
}

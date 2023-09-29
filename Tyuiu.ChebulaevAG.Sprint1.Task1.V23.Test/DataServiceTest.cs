using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChebulaevAG.Sprint1.Task1.V23.Lib;

namespace Tyuiu.ChebulaevAG.Sprint1.Task1.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 1.0;
            double x = 2.0;
            var res = ds.Calculate(x, a);
            Assert.AreEqual(0.785, res);
        }
    }
}

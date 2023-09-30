using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChebulaevAG.Sprint1.Task7.V20.Lib;

namespace Tyuiu.ChebulaevAG.Sprint1.Task7.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            double wait = 4.129; 

            double result = ds.Calculate(x, y);

            Assert.AreEqual(wait, result, 0.001);
        }
    }
}

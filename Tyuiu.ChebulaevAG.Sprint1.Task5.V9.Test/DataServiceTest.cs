using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChebulaevAG.Sprint1.Task5.V9.Lib;

namespace Tyuiu.ChebulaevAG.Sprint1.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double f = 90; 
            double wait = 3;
            double h = ds.AngleToHoursMinutes(f);

            Assert.AreEqual(wait, h);
        }
    }
}

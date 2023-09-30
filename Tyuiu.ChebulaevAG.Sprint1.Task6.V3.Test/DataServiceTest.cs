using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChebulaevAG.Sprint1.Task6.V3.Lib;

namespace Tyuiu.ChebulaevAG.Sprint1.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string value = "Это тестовая строка";
            string wait = "ояа";
            string res = ds.LastLetterWord(value);

            Assert.AreEqual(wait, res);
        }
    }
}

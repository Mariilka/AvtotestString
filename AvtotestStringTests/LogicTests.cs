using Microsoft.VisualStudio.TestTools.UnitTesting;
using Three;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void CalculateLetterPercentageTest()
        {
            Logic logic = new Logic();
            string text = "Привет, мир!";
            double expected = 75.0; // 9 букв из 12 символов

            double result = logic.CalculateLetterPercentage(text);

            Assert.AreEqual(expected, result, 0.001);
        }
    }
}
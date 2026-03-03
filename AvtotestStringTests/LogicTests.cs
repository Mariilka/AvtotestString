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
        public void CalculateLetterPercentageTest1()
        {
            Logic logic = new Logic();
            string text = "0123";
            double expected = 0; 

            double result = logic.CalculateLetterPercentage(text);

            Assert.AreEqual(expected, result, 0.001);
        }
        public void CalculateLetterPercentageTest2()
        {
            Logic logic = new Logic();
            string text = "Даниил";
            double expected = 100.0;

            double result = logic.CalculateLetterPercentage(text);

            Assert.AreEqual(expected, result, 0.001);
        }
    }
}
using NUnit.Framework;
using Lab3_BondarevaKS;
using Lab3_BondarevaKS.Models;
using Lab3_BondarevaKS.Solution;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("", "", "")]
        [TestCase("", "1", "1")]
        [TestCase("1", "", "1")]
        [TestCase("1", "1", "")]
        public void ClearInput(string f, string s, string t)
        {
            InfTriangle actual = Controller.GoControl(f, s, t);
            string expect = "Нечисловые данные";
            Assert.That(actual.TypeTriangle, Is.EqualTo(expect));
        }

        [TestCase("a", "a", "a")]
        [TestCase("a", "1", "1")]
        [TestCase("1", "a", "1")]
        [TestCase("1", "1", "a")]
        public void SymbolInput(string f, string s, string t)
        {
            InfTriangle actual = Controller.GoControl(f, s, t);
            string expect = "Нечисловые данные";
            Assert.That(actual.TypeTriangle, Is.EqualTo(expect));
        }

        [TestCase("#", "#", "#")]
        [TestCase("#", "1", "1")]
        [TestCase("1", "#", "1")]
        [TestCase("1", "1", "#")]
        public void NotDigitInput(string f, string s, string t)
        {
            InfTriangle actual = Controller.GoControl(f, s, t);
            string expect = "Нечисловые данные";
            Assert.That(actual.TypeTriangle, Is.EqualTo(expect));
        }

        [TestCase("-1", "-1", "-1")]
        [TestCase("-1", "1", "1")]
        [TestCase("1", "-1", "1")]
        [TestCase("1", "1", "-1")]
        public void InvalydDigit(string f, string s, string t)
        {
            InfTriangle actual = Controller.GoControl(f, s, t);
            string expect = "Невалидные значения";
            Assert.That(actual.TypeTriangle, Is.EqualTo(expect));
        }

        [TestCase("0", "0", "0")]
        [TestCase("0", "1", "1")]
        [TestCase("1", "0", "1")]
        [TestCase("1", "1", "0")]
        public void NullInput(string f, string s, string t)
        {
            InfTriangle actual = Controller.GoControl(f, s, t);
            string expect = "Невалидные значения";
            Assert.That(actual.TypeTriangle, Is.EqualTo(expect));
        }

        [TestCase("1", "1", "5")]
        public void NotTriangle(string f, string s, string t)
        {
            InfTriangle actual = Controller.GoControl(f, s, t);
            string expect = "Не треугольник";
            Assert.That(actual.TypeTriangle, Is.EqualTo(expect));
        }
    }
}
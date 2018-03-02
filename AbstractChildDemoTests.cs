using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace log4jnetDemostration.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void AdditionTest()
        {
            AbstractChildDemo acd = new AbstractChildDemo();
            double res = acd.Addition(10, 10);
            Assert.AreEqual(res, 20);
        }

        [TestMethod()]
        public void SubtractionTest()
        {
            AbstractChildDemo acd = new AbstractChildDemo();
            double res = acd.Subtraction(10, 2);
            Assert.AreEqual(res, 8);
        }

        [TestMethod()]
        public void MultiplicationTest()
        {
            AbstractChildDemo acd = new AbstractChildDemo();

            double res = acd.Multiplication(10, 2);
            Assert.AreEqual(res, 20);
        }

        [TestMethod()]
        public void DivisionTest()
        {
            AbstractChildDemo acd = new AbstractChildDemo();

            double res = acd.Division(10, 2);
            Assert.AreEqual(res, 5);
        }

    }
}
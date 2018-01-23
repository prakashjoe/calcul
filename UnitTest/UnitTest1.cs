using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using claci;
namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Addition()
        {
            calcOperations obj = new calcOperations();
            int x = 10;
            int y = 20;
            int expected = 30;

            int actual = obj.Addition(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Subtraction()
        {
            calcOperations obj = new calcOperations();
            int x = 30;
            int y = 10;
            int expected = 20;

            int actual = obj.Subtraction(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Multiplication()
        {
            calcOperations obj = new calcOperations();
            int x = 30;
            int y = 10;
            int expected = 300;

            int actual = obj.Multiplication(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Division()
        {
            calcOperations obj = new calcOperations();
            int x = 30;
            int y = 10;
            int expected = 3;

            int actual = obj.Division(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod()
        {
            Teacher obj = new Teacher();
            bool result = obj.teach();
            Assert.AreEqual(true, result);
        }

       [TestMethod]
       public void TestMethod1()
        {
            Manager obj1 = new Manager();
            bool result = obj1.assigntask();
            Assert.AreEqual(true, result);
        }
    }
}

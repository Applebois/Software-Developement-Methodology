using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDM_Assignment;

namespace SDMTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Boolean expected = false;


            Boolean actual = UnitTest.checkIC("12345");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Boolean expected = false;


            Boolean actual = UnitTest.checkRoles("others");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Boolean expected = false;


            Boolean actual = UnitTest.checkPassword("1");

            Assert.AreEqual(expected, actual);
        }

    }
}

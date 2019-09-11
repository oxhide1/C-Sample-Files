using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp.Models;

namespace UnitTestA
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            SampleClass sampleClass = new SampleClass();
            //Act
            string result = sampleClass.AnotherMessage();
            //Assert
            //Expected
            //Actual
            Assert.AreEqual("Hello!", result);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorTest;

namespace CalculatorTest
{
    //Simple use of MS Test for Unit Testing
    //Create a test class ..consider naming the Test class specific to the class  under test

    [TestClass]
    public class Calculator
    {
        //Try naming the method for the purpose it is intended

        [TestMethod]
        public void VerifyAddMethodReturnsCorrectSumOfTwoNumbers()
        {
            //Arrange..set up the test
            CalculatorClass obj = new CalculatorClass();
            //Act...actionable event
            obj.Add(4, 5);
            //Assert..expected result
            Assert.AreEqual(9, obj.sum);
        }

        //continue to set up additional tests in the same manner
        [TestMethod]
        public void VerifySubtractMethodReturnsCorrectDifferenceOfTwoNumbers()
        {
            CalculatorClass obj2 = new CalculatorClass();
            obj2.Subtract(4, 5);
            Assert.AreEqual(-1, obj2.diff);
        }

        [TestMethod]
        public void VerifyMultiplyMethodReturnsCorrectProductOfTwoNumbers()
        {
            CalculatorClass obj3 = new CalculatorClass();
            obj3.Multiply(4, 5);
            Assert.AreEqual(20, obj3.product);
        }

        [TestMethod]
        public void VerifyDivideMethodReturnsCorrectDividendOfTwoNumbers()
        {
            CalculatorClass obj4 = new CalculatorClass();
            obj4.Add(4, 5);
            Assert.AreEqual(0, obj4.quotient);
        }
    }
}

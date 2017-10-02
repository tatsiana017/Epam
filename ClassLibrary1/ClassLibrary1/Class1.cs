using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [TestFixture]
    public class Class1
    {
        //Addition
        [Test]
        public void AddTest()
        {
            double result = Calculator.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void AddTest1()
        {
            double result = Calculator.Add(2.53, 3);
            Assert.IsNotNull(result);
        }
        [Test]
        public void AddTest2()
        {
            double result = Calculator.Add(2.53, 3);
            double result1 = Calculator.Add(2.53, 3);
            Assert.AreEqual(result, result1);
        }
        [Test]
        public void AddTest3()
        {
            Assert.IsNaN(Calculator.Add(Double.NaN, 445));
        }

        //Substraction
        [Test]
        public void SubsTest()
        {
            double result = Calculator.Substraction(53, 4);
            Assert.AreEqual(49, result);
            
        }
        [Test]
        public void SubsTest1()
        {
            double result = Calculator.Substraction(53, 4);
            Assert.IsNotNull(result);
        }
        [Test]
        public void SubsTest2()
        {
            Assert.IsNaN(Calculator.Substraction(Double.NaN, 445));
        }

        //Divivsion
        [Test]
        public void DivTest()
        {
            double result = Calculator.Division(10, 2);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void DivTest1()
        {
            Assert.Throws(typeof(DivideByZeroException), delegate { Calculator.Division(10, 0); });
        }
        [Test]
        public void DivTest2()
        {
            double result = Calculator.Division(45, 12);
            Assert.IsNotNull(result);
        }
        [Test]
        public void DivTest3()
        {
            double result = Calculator.Division(2.53, 3);
            double result1 = Calculator.Division(2.53, 3);
            Assert.AreEqual(result, result1);
        }
        [Test]
        public void DivTest4()
        {
            Assert.IsNaN(Calculator.Division(Double.NaN, 445));
        }

        //Multiplication
        [Test]
        public void MultiTest()
        {
            double result = Calculator.Muliplication(2, 3);
            Assert.AreEqual(6, result);
        }
        [Test]
        public void MultiTest1()
        {
            double result = Calculator.Muliplication(2, 3);
            Assert.IsNotNull(result);
        }
        [Test]
        public void MultiTest2()
        {
            Assert.IsNaN(Calculator.Muliplication(Double.NaN, 445));
        }
    }
}

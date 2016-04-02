using System;
using System.Collections.Generic;
using System.Linq;

using NUnit.Framework;
using AppveyorTest;

namespace AppveyorTest.Tests
{
    public class AdditionTest : MathTest<Addition>
    {
        //public override void OperationTest(int a, int b)
        //{
        //}
    }

    public class AdditionTest2 : MathTest<Addition>
    {

    }

    [TestFixture]
    public abstract class MathTest<T>
    {
        [Test]
        [TestCase(0, 5)]
        [TestCase(4, 9)]
        public void OperationTest(int a, int b)
        {
            Assert.AreEqual(a + b, new Addition().Add(a, b));
        }
    }
}

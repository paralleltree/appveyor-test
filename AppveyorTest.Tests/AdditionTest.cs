using System;
using System.Collections.Generic;
using System.Linq;

using Xunit;
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

    public abstract class MathTest<T>
    {
        [Theory]
        [InlineData(4, 0)]
        [InlineData(5, 4)]
        public void OperationTest(int a, int b)
        {
            Assert.Equal(a + b, new Addition().Add(a, b));
        }
    }
}

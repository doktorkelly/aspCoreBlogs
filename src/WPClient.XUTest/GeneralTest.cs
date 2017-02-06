using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace WPClient.XUTest
{
    public class GeneralTest
    {
        //[Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        //[Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Add(2, 2));
        }

        private int Add(int v1, int v2)
        {
            return v1 + v2;
        }

        //[Theory]
        //[InlineData(3)]
        //[InlineData(5)]
        //[InlineData(6)]
        public void MyFirstTheory(int value)
        {
            Assert.True(IsOdd(value));
        }

        bool IsOdd(int value)
        {
            return value % 2 == 1;
        }
    }
}

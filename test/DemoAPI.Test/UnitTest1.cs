using System;
using Xunit;
using DemoAPI.Controllers;

namespace DemoAPI.Test
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();
        [Fact]
        public void GetReturnMyName()
        {
            var returnValue  = controller.Get(1);
            Assert.Equal("Puneet Singh", returnValue.Value);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}

using System;
using Xunit;

namespace MyName.Tests
{
    public class TestName
    {
        [Fact]
        public void TestGetNameShoudReturnMyName()
        {
            Name myNmae = new Name();
            string result = myNmae.Get();
            Assert.Equal("Yossatron", result);
        }
    }
}

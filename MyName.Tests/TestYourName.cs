using System;
using Xunit;

namespace Yossatron.MyName.Tests
{
    public class TestYourName
    {
        [Fact]
        public void TestGetYourNameShoudReturnMyName()
        {
            YourName myYourNmae = new YourName();
            string result = myYourNmae.Get();
            Assert.Equal("Add", result);
        }
    }
}

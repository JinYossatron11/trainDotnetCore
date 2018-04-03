using System;
using Xunit;

namespace Yossatron.MyName.Tests
{
    public class TestName
    {
        private Name myName;
        public TestName(){
            myName = new Name();
        }

         [Fact]
        public void TestGetNameShoudReturnMyName()
        {
            string result = myName.Get();
            Assert.Equal("Yossatron", result);
        }

        [Fact]
        public void TestGetNameWithoutLanguageShoudReturnMyNameInEnglish()
        {
            string result = myName.Get("e");
            Assert.Equal("Yossatron", result);
        }
         [Fact]
        public void TestGetNameWithoutLanguageShoudReturnMyNameInThailand()
        {
            string result = myName.Get("t");
            Assert.Equal("ยศธร", result);
        }
        [Theory] /// รันตามลำดับ line เรียงจากบนไปล่าง 
        [InlineData("e","Yossatron")]
        [InlineData("t","ยศธร")]
        public void TestGetNameWithoutThaiLanguageShoudReturnMyNameInThai(string inputLanguage,string expectedResult){
            string result = myName.Get(inputLanguage);
            Assert.Equal(expectedResult,result);

        }
    }
}

using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void GivenSumText_Whendecoding_returnReverseText()
        {
            const string SumText = "abc";
            var result = Encode(SumText);
            const string ReverseText = "cba";
            Assert.Equal(ReverseText, result);

        }

        private static string Encode(string SumText)
        {
            return StringHelper.ReverseString(SumText);
        }
    }

    static class StringHelper
    {
        public static string ReverseString(string myStr)
        {
            char[] myArr = myStr.ToCharArray();
            Array.Reverse(myArr);
            return new string(myArr);
        }
    }
}

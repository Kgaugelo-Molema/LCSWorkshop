using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        const string sumText = "ABC";
        [Fact]
        public void GivenSumTest_WhenDecoding_ReturnReverseText()
        {

            Assert.Equal(ReverseText("CBA"), sumText);

        }


        public string ReverseText(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }


    }       
 }

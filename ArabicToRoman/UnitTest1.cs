using System;
using Xunit;

namespace ArabicToRoman
{
    public class UnitTest1
    {
        private readonly Converter _unitTest;

        public UnitTest1()
        {
            _unitTest = new Converter();
        }
        
        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(12, "XII")]
        [InlineData(20, "XX")]
        [InlineData(40, "XL")]
        [InlineData(41, "XLI")]
        [InlineData(83, "LXXXIII")]
        [InlineData(90, "XC")]
        [InlineData(800, "DCCC")]
        [InlineData(900, "CM")]
        [InlineData(1000, "M")]
        [InlineData(27, "XXVII")]   
        [InlineData(89, "LXXXIX")]              
        [InlineData(400, "CD")]
        [InlineData(1998, "MCMXCVIII")]
        [InlineData(8, "VIII")]
        public void ArabicToRoman(int arabic, string roman)
        {
            var result = _unitTest.ConvertFromArabicToRoman(arabic);
            Assert.Equal(roman,result); 
        }
        
        
        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(12, "XII")]
        [InlineData(20, "XX")]
        [InlineData(40, "XL")]
        [InlineData(41, "XLI")]
        [InlineData(83, "LXXXIII")]
        [InlineData(90, "XC")]
        [InlineData(800, "DCCC")]
        [InlineData(900, "CM")]
        [InlineData(1000, "M")]
        [InlineData(27, "XXVII")]   
        [InlineData(89, "LXXXIX")]              
        [InlineData(400, "CD")]
        [InlineData(1998, "MCMXCVIII")]
        [InlineData(8, "VIII")]
        public void RomanToArabicTest(int arabic, string roman)
        {
            var result = _unitTest.ConvertFromRomanToArabic(roman);
            Assert.True(arabic == result); 
        }
    }
}
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MoonlyBird.Common.Extensions.Number;

namespace MoonlyBird.Common.Test.Extensions
{
    public class ParseNumberExtensionTest
    {

        [Theory]
        [InlineData("-100")]
        [InlineData("100")]
        [InlineData("999")]
        [InlineData("0")]
        [InlineData("000")]
        [InlineData("2147483647")]
        [InlineData("-2147483648")]
        void IntergerParse_AllDefaultParams_OK(string literalNumeber)
        {
            
            var extensionParseResult = literalNumeber.Parse<int>();
            Assert.True(extensionParseResult.Parsed);

            var tryParseResult = int.TryParse(literalNumeber, out var parsedNumber);
            Assert.True(tryParseResult);

            Assert.Equal(parsedNumber, extensionParseResult.Value);
        }

        [Theory]
        [InlineData("00,00")]
        [InlineData("0.0")]
        [InlineData(" ")]
        [InlineData("")]
        [InlineData("foo")]
        [InlineData("-100")]
        [InlineData("100")]
        [InlineData("999")]
        [InlineData("0")]
        [InlineData("000")]
        [InlineData("2147483647")]
        [InlineData("-2147483648")]
        void IntergerParseOrDefault_AllDefaultParams_OK(string literalNumeber)
        {
            var defualtInt = default(int);

            var extensionParseResult = literalNumeber.ParseOrDefault<int>();
            
            var tryParseResult = int.TryParse(literalNumeber, out var parsedNumber);
            
            if (tryParseResult)
            {
                Assert.Equal(parsedNumber, extensionParseResult);
            } else
            {
                Assert.Equal(defualtInt, extensionParseResult);
            }
            
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoonlyBird.Common.Extensions.String;

namespace MoonlyBird.Common.Test.Extensions
{
    public class StringExtensionTest
    {

        [Theory]
        [InlineData(',', new string[]{"foo", "bar", "baz"})]
        [InlineData('-', new string[]{"foo", "bar", "baz"})]
        [InlineData(' ', new string[]{"foo", "bar", "baz"})]
        [InlineData('/', new string[]{"foo", "bar", "baz"})]
        [InlineData('\'', new string[]{"foo", "bar", "baz"})]
        public void JoinChar_OK(char separator, IEnumerable<string> strings)
        {
            var extensionJoined = strings.Join(separator);

            var originalJoind = string.Join(separator, strings);

            Assert.Equal(originalJoind, extensionJoined);
        }


        [Theory]
        [InlineData("foo", new string[] { "foo", "bar", "baz" })]
        [InlineData("-", new string[] { "foo", "bar", "baz" })]
        [InlineData(",", new string[] { "foo", "bar", "baz" })]
        [InlineData("--", new string[] { "foo", "bar", "baz" })]
        [InlineData("''", new string[] { "foo", "bar", "baz" })]
        [InlineData("//", new string[] { "foo", "bar", "baz" })]
        [InlineData("  ", new string[] { "foo", "bar", "baz" })]
        public void JoinString_OK(string separator, IEnumerable<string> strings)
        {
            var extensionJoined = strings.Join(separator);

            var originalJoind = string.Join(separator, strings);

            Assert.Equal(originalJoind, extensionJoined);
        }
    }
}

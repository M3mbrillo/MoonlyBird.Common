using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonlyBird.Common.Extensions.String
{
    public static class StringExtension
    {

        static public string Join(this IEnumerable<string> strings, char separator)
            => string.Join(separator, strings);

        static public string Join(this IEnumerable<string> strings, string separator)
            => string.Join(separator, strings);

        static public bool IsNullOrEmpty(this string value)
            => string.IsNullOrEmpty(value);

        static public bool IsNullOrWhiteSpace(this string value)
            => string.IsNullOrWhiteSpace(value);

    }
}

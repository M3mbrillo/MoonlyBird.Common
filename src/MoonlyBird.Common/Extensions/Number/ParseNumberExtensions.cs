using System.Globalization;
using System.Numerics;

namespace MoonlyBird.Common.Extensions.Number
{
    public static class ParseNumberExtensions
    {
        public static ParseExtensionResult<T> Parse<T>(this string stringNumber, NumberStyles numberStyle = NumberStyles.Any, CultureInfo? cultureInfo = null)
            where T : INumber<T>
        {
            
            var success = T.TryParse(stringNumber, numberStyle, cultureInfo ?? CultureInfo.CurrentCulture, out var result);

            return new ParseExtensionResult<T>
            {
                Value = result,
                Parsed = success
            };
        }

        public static T? ParseOrDefault<T>(this string stringNumber, NumberStyles numberStyle = NumberStyles.Any, CultureInfo? cultureInfo = null)
            where T : INumber<T>
        {
            var result = stringNumber.Parse<T>(numberStyle, cultureInfo);

            return result.Parsed ? result.Value : default(T);
        }

    }

    public record ParseExtensionResult<T>
        where T : INumber<T>
    {
        public T? Value { get; init; }
        public bool Parsed { get; init; }
    }
}

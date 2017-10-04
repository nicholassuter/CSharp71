using System;

namespace CSharp71Demo
{
    public static class TryParseExtensions
    {
        public static (bool IsSuccess, T Value) TryParse<T>(this string input)
        {
            T output = default;
            switch (output)
            {
                case int i:
                    return (int.TryParse(input, out i), (T)Convert.ChangeType(i, typeof(T)));
                case bool b:
                    return (bool.TryParse(input, out b), (T)Convert.ChangeType(b, typeof(T)));
                case decimal dec:
                    return (decimal.TryParse(input, out dec), (T)Convert.ChangeType(dec, typeof(T)));
                case double dbl:
                    return (double.TryParse(input, out dbl), (T)Convert.ChangeType(dbl, typeof(T)));
                case DateTime date:
                    return (DateTime.TryParse(input, out date), (T)Convert.ChangeType(date, typeof(T)));
                case byte bt:
                    return (byte.TryParse(input, out bt), (T)Convert.ChangeType(bt, typeof(T)));
                default:
                    return (false, default);
            }
        }
    }
}

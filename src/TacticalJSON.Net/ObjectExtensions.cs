using System;

namespace TacticalJSON.Net
{
    /// <summary>
    ///     Provides extensions for instances.
    /// </summary>
    internal static class ObjectExtensions
    {
        /// <summary>
        ///     Converts the specified value to <typeparamref name="T" /> or returns it's default.
        /// </summary>
        /// <typeparam name="T">The type to convert to.</typeparam>
        /// <param name="value">The value.</param>
        /// <returns>The converted value or default.</returns>
        public static T ConvertToOrDefault<T>(this object value)
        {
            try
            {
                return (T)Convert.ChangeType(value, typeof(T));
            }
            catch
            {
                return default;
            }
        }
    }
}
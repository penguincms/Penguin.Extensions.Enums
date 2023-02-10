using System;
using System.Collections.Generic;

namespace Penguin.Extensions.Enums
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

    public static class EnumExtensions
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {
        #region Methods

        /// <summary>
        /// Attempts to retrive all flag combinations from an enum
        /// </summary>
        /// <typeparam name="T">The enum to search</typeparam>
        /// <returns> all flag combinations</returns>
        public static List<T> GetFlags<T>() where T : Enum
        {
            List<T> flags = new();

            foreach (T val in Enum.GetValues(typeof(T)))
            {
                ulong keyVal = System.Convert.ToUInt64(val);

                if ((keyVal & (keyVal - 1)) == 0)
                {
                    flags.Add(val);
                }
            }

            return flags;
        }

        #endregion Methods
    }
}
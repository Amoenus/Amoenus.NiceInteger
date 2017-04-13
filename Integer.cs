using System;

namespace Amoenus.NiceInteger
{
    /// <summary>
    /// Nice helpers for Integers
    /// </summary>
    public static class Integer
    {
        /// <summary>
        /// Determines whether dividend is divisible by the specified divisor.
        /// </summary>
        /// <param name="dividend">The dividend.</param>
        /// <param name="divisor">The divisor.</param>
        /// <returns>
        ///   <c>true</c> if is divisible by the specified divisor; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsDivisibleBy(this int dividend, int divisor)
        {
            if(divisor==0) {
                throw new ArgumentException();
            }
            return (divisor&(~divisor+1))==divisor ? dividend.IsEven() : (dividend%divisor)==0;
        }

        /// <summary>
        /// Determines whether dividend is odd number.
        /// </summary>
        /// <param name="dividend">The dividend.</param>
        /// <returns>
        ///   <c>true</c> if is divisible by the specified divisor; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsOdd(this int dividend)
        {
            return (dividend&0x01)!=0;
        }

        /// <summary>
        /// Determines whether dividend is even number.
        /// </summary>
        /// <param name="dividend">The dividend.</param>
        /// <returns>
        ///   <c>true</c> if is divisible by the specified divisor; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsEven(this int dividend)
        {
            return (dividend&0x01)==0;
        }
    }
}

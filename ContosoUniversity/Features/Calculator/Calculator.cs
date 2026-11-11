namespace ContosoUniversity.Features.Calculator
{
    /// <summary>
    /// The arithmetic behind the calculator page: the sum and the difference of two numbers.
    /// </summary>
    public static class Calculator
    {
        /// <summary>Adds two numbers.</summary>
        /// <param name="left">The first number.</param>
        /// <param name="right">The number added to it.</param>
        /// <returns>The sum of <paramref name="left"/> and <paramref name="right"/>.</returns>
        public static decimal Add(decimal left, decimal right) => left + right;

        /// <summary>Subtracts one number from another.</summary>
        /// <param name="left">The number subtracted from.</param>
        /// <param name="right">The number subtracted.</param>
        /// <returns><paramref name="left"/> minus <paramref name="right"/>.</returns>
        public static decimal Subtract(decimal left, decimal right) => left - right;
    }
}

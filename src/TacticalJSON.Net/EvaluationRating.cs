namespace TacticalJSON.Net
{
    /// <summary>
    ///     Represents a text amplifier for units, equipment and installations that consists of a one-letter
    ///     reliability rating and a one-number credibility rating.
    /// </summary>
    public struct EvaluationRating
    {
        /// <summary>
        ///     Gets or sets the reliability rating.
        /// </summary>
        public char Reliability { get; }

        /// <summary>
        ///     Gets or sets the credibility rating.
        /// </summary>
        public double Credibility { get; }

        /// <summary>
        ///     Creates a new <see cref="EvaluationRating" />.
        /// </summary>
        /// <param name="reliability">The reliability rating.</param>
        /// <param name="credibility">The credibility rating.</param>
        public EvaluationRating(char reliability, double credibility)
        {
            Reliability = reliability;
            Credibility = credibility;
        }

        /// <inheritdoc />
        public override string ToString() => $"{Reliability}{Credibility}";

        /// <summary>
        ///     Attempts to parse a string value to a <see cref="EvaluationRating" />.
        /// </summary>
        /// <param name="value">The value to parse.</param>
        /// <param name="rating">The resulting <see cref="EvaluationRating" />.</param>
        /// <returns>True if the value could be parsed, otherwise false.</returns>
        public static bool TryParse(string value, out EvaluationRating rating)
        {
            rating = default;
            if (string.IsNullOrEmpty(value) || value.Length < 2)
                return false;

            if (!char.TryParse(value.Substring(0, 1), out var reliability))
                return false;

            if (!double.TryParse(value.Substring(1, value.Length - 1), out var credibility))
                return false;

            rating = new EvaluationRating(reliability, credibility);
            return true;
        }
    }
}
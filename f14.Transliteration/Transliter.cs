using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace f14.Transliteration
{
    /// <summary>
    /// The transliter implementation.
    /// </summary>
    public class Transliter : ITransliter
    {
        private readonly IRelation _relation;

        internal Transliter(IRelation relation)
        {
            _relation = relation ?? throw new InvalidOperationException("No relation for given key found.");
        }
        /// <summary>
        /// Performs transliteration of the string.
        /// </summary>
        /// <param name="input">The input string to translite.</param>
        /// <returns>The translited string.</returns>
        public string ConvertString(string input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var c in input)
            {
                var charStr = Convert.ToString(c);
                var result = ConvertChar(charStr);
                sb.Append(result);
            }
            return sb.ToString();
        }

        private string ConvertChar(string input)
        {
            // If input is whitespace
            if (input.All(x => char.IsWhiteSpace(x)))
            {
                return input;
            }

            // Find chars in realtion
            string match;
            if (_relation.Table.TryGetValue(input, out match))
            {
                return match;
            }
            // If the character is from the same language as the destination language
            if (_relation.Table.Values.Contains(input))
            {
                return input;
            }
            return string.Empty;
        }
    }
}

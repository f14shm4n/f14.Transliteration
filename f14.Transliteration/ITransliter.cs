using System;
using System.Collections.Generic;
using System.Text;

namespace f14.Transliteration
{
    /// <summary>
    /// Represents the transliter object.
    /// </summary>
    public interface ITransliter
    {
        /// <summary>
        /// Performs transliteration of the string.
        /// </summary>
        /// <param name="input">The input string to translite.</param>
        /// <returns>The translited string.</returns>
        string ConvertString(string input);
    }
}

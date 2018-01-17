using System;
using System.Collections.Generic;
using System.Text;

namespace f14.Transliteration
{
    /// <summary>
    /// Represents the char relation.
    /// </summary>
    public interface IRelation
    {
        /// <summary>
        /// The relation table.
        /// </summary>
        IDictionary<string, string> Table { get; }
    }
}

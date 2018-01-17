using System;
using System.Collections.Generic;
using System.Text;

namespace f14.Transliteration
{
    /// <summary>
    /// Provides the static methods for transliteration.
    /// </summary>
    public class TransilterService
    {
        /// <summary>
        /// Performs transliteration using specified relation with given key.
        /// </summary>
        /// <typeparam name="TRelation">Specified <see cref="IRelation"/> type.</typeparam>
        /// <param name="input">String to transliterate.</param>
        /// <returns>Transliterated string.</returns>
        public static string Transliterate<TRelation>(string input) where TRelation : IRelation, new()
        {
            return CreateTransliter<TRelation>().ConvertString(input);
        }
        /// <summary>
        /// Create default transliter for given relation.
        /// </summary>
        /// <typeparam name="TRelation">Specified <see cref="IRelation"/> type.</typeparam>
        /// <returns><see cref="ITransliter"/>.</returns>
        public static ITransliter CreateTransliter<TRelation>() where TRelation : IRelation, new()
        {
            return new Transliter(new TRelation());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace f14.Transliteration.Relations
{
    /// <summary>
    /// The translite relation object for permalinks.
    /// </summary>
    public class PermalinkRelation : IRelation
    {
        /// <summary>
        /// The relation map.
        /// </summary>
        protected Dictionary<string, string> _relation = new Dictionary<string, string>
        {
            // Special
            { "0", "0" },
            { "1", "1" },
            { "2", "2" },
            { "3", "3" },
            { "4", "4" },
            { "5", "5" },
            { "6", "6" },
            { "7", "7" },
            { "8", "8" },
            { "9", "9" },
            { "-", "-" },            
            { "$", "s" },
            { "@", "a" },
            // Alphabet
            { "а", "a"},
            { "А", "A"},
            { "б", "b"},
            { "Б", "B"},
            { "в", "v"},
            { "В", "V"},
            { "г", "g"},
            { "Г", "G"},
            { "д", "d"},
            { "Д", "D"},
            { "е", "e"},
            { "Е", "E"},
            { "ё", "e"},
            { "Ё", "E"},
            { "ж", "zh"},
            { "Ж", "ZH"},
            { "з", "z"},
            { "З", "Z"},
            { "и", "i"},
            { "И", "I"},
            { "й", "y"},
            { "Й", "Y"},
            { "к", "k"},
            { "К", "K"},
            { "л", "l"},
            { "Л", "L"},
            { "м", "m"},
            { "М", "M"},
            { "н", "n"},
            { "Н", "N"},
            { "о", "o"},
            { "О", "O"},
            { "п", "p"},
            { "П", "P"},
            { "р", "r"},
            { "Р", "R"},
            { "с", "s"},
            { "С", "S"},
            { "т", "t"},
            { "Т", "T"},
            { "у", "u"},
            { "У", "U"},
            { "ф", "f"},
            { "Ф", "F"},
            { "х", "kh"},
            { "Х", "KH"},
            { "ц", "c"},
            { "Ц", "C"},
            { "ч", "c"},
            { "Ч", "C"},
            { "ш", "sh"},
            { "Ш", "SH"},
            { "щ", "shch"},
            { "Щ", "SHCH"},
            { "ы", "y" },
            { "Ы", "Y" },
            { "э", "e" },
            { "Э", "E" },
            { "ю", "yu" },
            { "Ю", "YU" },
            { "я", "ya" },
            { "Я", "YA" },
        };
        /// <summary>
        /// The relation table.
        /// </summary>
        public IDictionary<string, string> Table => _relation;
    }
}

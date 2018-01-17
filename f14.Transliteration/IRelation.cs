using System;
using System.Collections.Generic;
using System.Text;

namespace f14.Transliteration
{
    public interface IRelation
    {     
        IDictionary<string, string> Table { get; }
    }
}

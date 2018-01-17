using System;
using System.Collections.Generic;
using System.Text;

namespace f14.Transliteration
{
    public interface ITransliter
    {
        string ConvertString(string input);
    }
}

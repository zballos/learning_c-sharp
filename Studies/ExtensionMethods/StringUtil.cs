using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    static class StringUtil
    {
        public static string Pluralize(this string text)
        {
            if (text.EndsWith("s"))
            {
                return text;
            }
            else
            {
                return text + "s";
            }
        }
    }
}

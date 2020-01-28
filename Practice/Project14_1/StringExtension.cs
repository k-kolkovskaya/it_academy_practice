using System;
using System.Collections.Generic;
using System.Text;

namespace Project14_1
{
    static class StringExtension
    {
        public static string CutString (this String @string)
        {
            return @string.Substring(0, 5) + "..."; 
        }
    }
}

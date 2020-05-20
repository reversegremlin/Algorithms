using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{

    public static class Base62Converter {

        public static readonly string alphaNumerics = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public static readonly int baseLength = alphaNumerics.Length;

        public static string Encode(int seed)
        {
            if (seed < baseLength)
            {
                return alphaNumerics[seed].ToString();
            }

            string result = "";
            
            while (seed > 0)
            {
                result += alphaNumerics[seed % baseLength];
                seed = seed / baseLength;
            }
            return String.Join(String.Empty, result.Reverse());
        }

        public static int Decode(string encodedString)
        {
            var  i = 0;

            foreach (char c in encodedString)
            {
                i = (i * baseLength) + alphaNumerics.IndexOf(c);
            }
            return i;
        }
    }
}
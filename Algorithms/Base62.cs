using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{

    public static class Base62Converter {

        public static readonly string corpus = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public static readonly int myBase = corpus.Length;

        public static string Encode(int seed)
        {
            if (seed == 0)
            {
                return corpus[0].ToString();
            }

            string result = String.Empty;
            
            while (seed > 0)
            {
                result += corpus[seed % myBase];
                seed = seed / myBase;
            }
            return String.Join(String.Empty, result.Reverse());
        }

        public static int Decode(string encodedString)
        {
            var  i = 0;

            foreach (char c in encodedString)
            {
                i = (i * myBase) + corpus.IndexOf(c);
            }
            return i;
        }
    }
}
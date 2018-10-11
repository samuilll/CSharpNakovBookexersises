using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter_22_LambdaExpressionsandLINQ.Problem7
{
    static class StringExtensions
    {
        public static string ToMakeFirstCharUpper(this string sentence)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(char.ToUpper(sentence[0]));
            sb.Append(sentence.Substring(1));

            string sentenceWithFirstCharUppered = sb.ToString();

            return sentenceWithFirstCharUppered;
        }
    }
}

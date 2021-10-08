using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashToAngularBracket
{
    static class Formatter
    {
        public static string[] Format(string[] text)
        {
            var hashIndices = new List<(int, int)>();
            for (int i = 0; i < text.Length; ++i)
                for (int j = 0; j < text[i].Length; ++j)
                {
                    if (text[i][j] == '#') hashIndices.Add((i, j));
                }

            //add one bracket to the very end if odd
            if (hashIndices.Count % 2 == 1)
                hashIndices.Add((text.Length - 1, text[^1].Length - 1));

            int middleLine = hashIndices[hashIndices.Count / 2].Item1;

            StringBuilder[] builders = new StringBuilder[text.Length];
            for (int i = 0; i < text.Length; ++i) builders[i] = new StringBuilder(text[i]);
            for (int i = 0; i < hashIndices.Count / 2; ++i)
            {
                builders[hashIndices[i].Item1][hashIndices[i].Item2] = '<';
            }
            for (int i = hashIndices.Count / 2; i < hashIndices.Count; ++i)
            {
                builders[hashIndices[i].Item1][hashIndices[i].Item2] = '>';
            }

            string[] result = new string[text.Length];
            for (int i = 0; i < text.Length; ++i)
                result[i] = builders[i].ToString();

            return result;
        }
    }
}

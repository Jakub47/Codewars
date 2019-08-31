using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLib
{
    public class StringMethod
    {
        /// <summary>
        /// Repeat string s given times (n)
        /// </summary>
        /// <param name="n">How many times string will be concat</param>
        /// <param name="s">string to concat</param>
        /// <returns></returns>
        public string repeatStr(int n, string s)
        {
            return string.Concat(Enumerable.Repeat(s, n));

            //StringBuilder resultRepeated = new StringBuilder();
            //for (int i = 0; i < n; i++)
            //{
            //    resultRepeated.Append(s);
            //}
            //return resultRepeated.ToString();
        }

        /// <summary>
        /// Find shortest string. Words in string must be seperetaed using white space
        /// </summary>
        /// <param name="s">string in which shortsets string will be found</param>
        /// <returns></returns>
        public static int FindShort(string s)
        {
            return s.Split(' ').Min(a => a.Length);
        }
    }
}

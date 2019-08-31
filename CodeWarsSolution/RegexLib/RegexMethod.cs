using System.Text.RegularExpressions;

namespace RegexLib
{
    public class RegexMethod
    {
        /// <summary>
        /// Replace all vowels in string
        /// </summary>
        /// <param name="str">String in which all vowels will be deleted</param>
        /// <returns></returns>
        public string Disemvowel(string str)
        {
            return Regex.Replace(str, "[euioa]", "", RegexOptions.IgnoreCase);
            //return string.Concat(str.Where(ch => !"aeiouAEIOU".Contains(ch)));
        }
    }
}

using System.Linq;
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

        /// <summary>
        /// "1 beer"  =>  "1 glass of water" "1 shot, 5 beers and 1 glass of wine"  =>  "7 glasses of water"
        /// </summary>
        /// <param name="drinkString"></param>
        /// <returns></returns>
        public string hydrate(string drinkString)
        {
            //var s = drinkString.Where(char.IsDigit).Sum(char.GetNumericValue);
            //return $"{s} glass{(s > 1 ? "es" : "")} of water";

            //var s = Regex.Matches(drinkString, "\\d").Sum(m => int.Parse(m.Value));
            //return $"{s} glass{(s > 1 ? "es" : "")} of water";

            string delimeter;

            if (drinkString.Contains("and"))
                delimeter = "and";
            else
                delimeter = ",";

            var amount = drinkString.Split(new string[] { delimeter }, System.StringSplitOptions.None).ToList().Select(a => Regex.Replace(a, @"[^\d]", "")).Select(b => int.Parse(b)).Sum();
            return amount == 1 ? $"{amount} glass of water" : $"{amount} glasses of water";

            string firstReg = Regex.Replace(drinkString, @"[^\d]", " ");
            string withoutSpaces = Regex.Replace(firstReg, @"\s+", ",");
            return withoutSpaces;
        }
    }
}

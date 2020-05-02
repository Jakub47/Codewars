using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringLib
{
    public class StringReplace
    {
        public string ToCamelCase(string str)
        {
            return str != string.Empty ? str.Split(new[] { "_","-" }, StringSplitOptions.None).
                Select((a,b) => b == 0 ? a.First() + a.Substring(1)
                                       : char.ToUpper(a.First()) + a.Substring(1))
                .Aggregate((current,next) => current + next) : string.Empty;

            //return Regex.Replace(str, @"[_-](\w)", m => m.Groups[1].Value.ToUpper());
            //return string.Concat(str.Split('-','_').Select((s, i) => i > 0 ? char.ToUpper(s[0]) + s.Substring(1) : s));

            //var words = str.Split('-', '_');
            //return words[0] + String.Join("", words.Skip(1).Select(x => Char.ToUpper(x[0]) + x.Substring(1)));

            // TextInfo txt = CultureInfo.CurrentCulture.TextInfo;

            //StringBuilder sB = new StringBuilder(str);

            //Regex r = new Regex(@"_.");
            //Match m = r.Match(str);
            //do
            //{
            //    Console.WriteLine("Match: " + m.Value);
            //    sB[m.Index + 1] = char.ToUpper(m.Value.Last());
            //    sB.Remove(m.Index, 1);
            //} while ((m = m.NextMatch()).Success);

            //return sB.ToString(); ;
            ////return str.Where(a => a == '_' || a == '_').;
        }

    }
}

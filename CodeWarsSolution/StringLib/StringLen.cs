using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLib
{
    public class StringLen
    {
        public  bool XO(string input) => input.Count(a => char.ToLower(a) == 'o').CompareTo(input.Count(b => char.ToLower(b) == 'x')) == 0 ? true : false;

        public string Likes(string[] name)
        {
            // return string.Format("{0}, {1} and {2} like this", name[0], name[1], name[2]);
            // case 1: return $"{name[0]} likes this";


            string result = string.Empty;
            switch(name.Length)
            {
                case 0:
                    result = "no one likes this"; break;
                case 1:
                    result = name[0] + " likes this"; break;
                case 2:
                    result = name[0] + " and " + name[1] + " like this"; break;
                case 3:
                    result = name[0] + ", " + name[1] + " and " + name[2] + " like this"; break;
                default:
                    result = name[0] + ", " + name[1] + " and " + (name.Length - 2) + " others like this";
                    break;
            }
            return result;
        }
    }
}

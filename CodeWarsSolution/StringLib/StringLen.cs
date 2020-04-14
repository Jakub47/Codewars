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
        
    }
}

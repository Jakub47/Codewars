using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    public class PrimaryMath
    {

        public bool IsSquare(int n) =>
                n < 0 ? false : Enumerable.Range(0, n + 1).Any(a => a * a == n);
    }
}

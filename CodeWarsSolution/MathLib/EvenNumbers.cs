using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    public class EvenNumbers
    {
        /// <summary>
        /// Return the even number of given n
        /// </summary>
        /// <param name="n">index of even number</param>
        /// <returns></returns>
        public  int NthEven(int n)
        {
            return 2 * (n - 1);
        }
    }
}

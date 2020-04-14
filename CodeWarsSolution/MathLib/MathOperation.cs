using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    public class MathOperation
    {
        public long rowSumOddNumbers(long n)
        {
            if (n <= 1) return n;
            long begin = n * (n - 1) +1;
            long next,sum = begin;
            n--;
            do
            {
                next = begin + 2;
                begin = next;
                sum += next;
                n--;
            } while (n > 0);
            return sum;
        }
    }
}

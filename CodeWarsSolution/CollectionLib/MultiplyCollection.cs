using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionLib
{
    public class MultiplyCollection
    {
        /// <summary>
        /// Multiply every element in array
        /// </summary>
        /// <param name="x">array which contains elements</param>
        /// <returns>multiplied values</returns>
        public  int Grow(List<int> x)
        {
            //return x.Aggregate((a,b) => a*b);
            int value = 1;
            x.ToList().ForEach(a => value *= a);
            return value;
        }
    }
}

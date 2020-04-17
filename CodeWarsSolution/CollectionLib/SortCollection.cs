using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionLib
{
    public class SortCollection
    {
        public IEnumerable<string> MyLanguages(Dictionary<string, int> results)
        {
            return results.Where(a => a.Value >= 60).OrderByDescending(a => a.Value).Select(a => a.Key);
        }

        public static int ArrayPlusArray(int[] arr1, int[] arr2)
        {
            return arr1.Sum() + arr2.Sum();
        }
    }
}

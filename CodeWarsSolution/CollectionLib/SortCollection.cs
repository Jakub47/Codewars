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

        /// <summary>
        /// In this Kata, your function receives an array of integers as input. 
        /// Your task is to determine whether the numbers are in ascending order. 
        /// An array is said to be in ascending order if there are no two adjacent integers 
        /// where the left integer exceeds the right integer in value.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public  bool IsAscOrder(int[] arr)
        {
            return arr.OrderByDescending(a => a).ToArray().SequenceEqual(arr);

            //return Enumerable.Range(1, arr.Length - 1).All(i => arr[i - 1] <= arr[i]);
            //arr.Zip(arr.Skip(1), (p,n) => p <= n).All(x => x);
        }

        public static int Solution(int value)
                        => Enumerable.Range(0, value).Where(a => a % 3 == 0 || a % 5 == 0).Sum();

        //Create a function named divisors/Divisors that takes an integer n > 1 and returns an array with all of the integer's divisors(except for 1 and the number itself), from smallest to largest. If the number is prime return the string '(integer) is prime' (null in C#) (use Either String a in Haskell and Result<Vec<u32>, String> in Rust).
        //public  int[] Divisors(int n)
        //{
        //    List<int> k = new List<int>();

        //    for (int i = 2; i < n; i++)
        //    {
        //        if (( == 0)
        //            k.Add(i);
        //    }
        //    return k.ToArray().Count() > 0 ? k.ToArray() : null;
            
        //   return  Enumerable.Range(1, n).Where(a => n % a == 0).ToArray();
        //}
    }
}

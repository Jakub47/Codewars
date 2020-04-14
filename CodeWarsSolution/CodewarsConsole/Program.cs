using CollectionLib;
using MathLib;
using StringLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsConsole
{
    class Program
    {
        /// <summary>
        /// Main Entry point
        /// </summary>
        /// <param name="args">argumnents</param>
        static void Main(string[] args)
        {
            MathOperation pM = new MathOperation();
            Console.WriteLine(p(new int[] { 4, 5, 6 }, new int[] { 1, 2, 3 }));
        }

        static bool p(int[] a, int[] b)
        {
            int sum1 = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum1 += a[i]
            }

            return a.Sum(c => Math.Pow(c,2)) > b.Sum(c => Math.Pow(c, 3));
        }
    }
}

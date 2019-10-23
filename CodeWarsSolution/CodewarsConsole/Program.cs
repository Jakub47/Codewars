using CollectionLib;
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
            SumCollection s = new SumCollection();
            Console.WriteLine(s.MaxGap(new int[] { 13, 10, 2, 9, 5 }));
            Console.ReadKey();
        }
    }
}

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
            SumCollection sumCol = new SumCollection();
            Console.WriteLine(sumCol.MaxGap(new int[] { 13, 10, 5, 2, 9 }));
            Console.ReadKey();
        }
    }
}

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
            Console.WriteLine(pM.rowSumOddNumbers(2));
        }
    }
}

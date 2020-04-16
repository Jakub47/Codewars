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
            StringMethod pM = new StringMethod();
            Console.WriteLine(pM.PigIt("Pig latin is cool"));
        }
    }
}

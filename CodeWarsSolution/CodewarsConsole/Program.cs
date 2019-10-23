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
            StringMethod s = new StringMethod();
            Console.WriteLine(s.FirstNonRepeatingLetter("G„weqwSG"));
            Console.ReadKey();
        }
    }
}

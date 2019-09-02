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
        static void Main(string[] args)
        {
            StringMethod stringMethod = new StringMethod();
            Console.WriteLine(stringMethod.repeatStr(5, "Hello"));
            Console.ReadKey();
        }
    }
}

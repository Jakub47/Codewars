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
        static void Main(string[] args)
        {
            EvenNumbers stringMethod = new EvenNumbers();
            Console.WriteLine(stringMethod.NthEven(5));
            Console.ReadKey();
        }
    }
}

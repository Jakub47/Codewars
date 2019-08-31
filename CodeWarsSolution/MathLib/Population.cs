using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    public class Population
    {
        /// <summary>
        /// In a small town the population is p0 = 1000 at the beginning of a year. 
        /// The population regularly increases by 2 percent per year and moreover 50 new inhabitants per year come to live in the town. 
        /// How many years does the town need to see its population greater or equal to p = 1200 inhabitants?
        /// </summary>
        /// <param name="p0">population </param>
        /// <param name="percent">population regularly increase</param>
        /// <param name="aug">inhabitants coming or leaving each year</param>
        /// <param name="p">population to surpass</param>
        /// <returns></returns>
        public static int NbYear(int p0, double percent, int aug, int p)
        {
            int result = 0;
            int counter = 0;
            do
            {
                result = p0 + (int)(p0 * (percent * 0.01) + aug);
                p0 = result;
                counter++;
            } while (result < p);

            return counter;
        }
    }
}

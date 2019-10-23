using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionLib
{
    public class SumCollection
    {
        /// <summary>
        /// Sum two smallest numbers in a array
        /// </summary>
        /// <param name="numbers">Original array</param>
        /// <returns>Sum</returns>
        public int sumTwoSmallestNumbers(int[] numbers)
        {
            //z 2012 wynika że first wykonywany O(nlog(n)) podczas gdy min/max w O(n)
            //pozatym w 2012 osoba wykonała pomiar z którego wynika że w podanym czasie zostaną wykonane funkcje
            //max_min => 70ms
            //OrderBy(): 2066ms
            //Niemniej od 2017 roku w kodzie https://github.com/dotnet/corefx/blob/ed0ee133ac49cee86f10ca4692b1d72e337bc012/src/System.Linq/src/System/Linq/OrderedEnumerable.cs
            //Można zobaczyć że zostało to poprawione i wywołując metode first() nie wykonywane jest sortowanie
            var numberList = numbers.ToList();
            //Take smallest number and delete do that for second one without deleting (cause it is not neccessary opertion
            int firstNumber = numberList.Min(); numberList.Remove(firstNumber);
            int secondNumber = numberList.Min();
            return firstNumber + secondNumber;
        }

        public Double SumArray(Double[] array)
        {
            return array.Sum();

            //Double sum = 0;
            //for (Int32 i = 0; i < array.Length; i++)
            //{
            //    sum += array[i];
            //}

            //var ss = from s in array
            //         select sum += s;

           // return sum;
        }

        public  int MaxGap(int[] numbers)
        {
            var sorted = numbers.OrderBy(i => i);
            return sorted.Zip(sorted.Skip(1), (a, b) => b - a).Max();

            //numbers = numbers.OrderByDescending(a => a).ToArray();
            //var substractions = new List<int>();

            //for (int i = 0; i < numbers.Length - 1; i++)
            //{
            //    substractions.Add(numbers[i] - numbers[i + 1]);
            //}

            //return substractions.Max();
        }
    }
}

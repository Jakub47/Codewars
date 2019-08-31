using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionLib
{
    public class SumCollection
    {
        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            var numberList = numbers.ToList();
            //Take smallest number and delete do that for second one without deleting (cause it is not neccessary opertion
            int firstNumber = numberList.Min(); numberList.Remove(firstNumber);
            int secondNumber = numberList.Min();
            return firstNumber + secondNumber;
        }
    }
}

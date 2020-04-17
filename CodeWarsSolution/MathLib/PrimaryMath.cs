using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    public class PrimaryMath
    {

        public bool IsSquare(int n) =>
                n < 0 ? false : Enumerable.Range(0, n + 1).Any(a => a * a == n);

        public static double Execute(double num1, char op, double num2)
        {
            double result = 0;
            switch (op)
            {
                case '+': result = num1 + num2; break;
                case '-': result = num1 - num2; break;
                case '*': result = num1 * num2; break;
                case '/': result = num2 == 0 ? throw new ArgumentException() : num1 / num2; break;
                default: throw new ArgumentException();
            }

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    public class PrimaryMath
    {
        //For example, if she turns 32, that's exactly 20 - in base 16... Already 39? That's just 21, in base 19!
        public string WomensAge(int n)
        {            
            for (int i = 1; i < 200; i++)
            {
                if(i * 2 == n)
                    return $"{n}? That's just {20}, in base {i}!";
                else if ((i * 2) + 1 == n )
                    return $"{n}? That's just {21}, in base {i}!";
            }
            return string.Empty;
        }

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


using NUnit.Framework;

namespace CalculatorApp
{
    public class CalculatorClass
    {
        public int Add(int v1, int v2)
        {
            return v1 + v2;
        }

        public int Subtract(int v1, int v2)
        {
            return v1 - v2;
        }

        public int Multiply(int v1, int v2)
        {
            return v1 * v2;
        }

        public double? Divide(int v1, int v2)
        {
            if (v2 == 0)
            {
                return null;
                throw new Exception("Division by zero is not allowed");
            }
            return (double)v1 / v2;
        }
    }
}
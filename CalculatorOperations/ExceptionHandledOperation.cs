using System;

namespace CalculatorOperations
{
    /// <summary>
    /// Defines set of mathematical operations
    /// </summary>
    public class ExceptionHandledOperation : IMathematicalOperation
    {
        public int Add(int num1, int num2)
        {
            throw new NotImplementedException();
        }

        public double Divide(int num1, int num2)
        {
            throw new NotImplementedException();
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}

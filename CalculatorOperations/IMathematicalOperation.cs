﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorOperations
{
    public interface IMathematicalOperation
    {
        int Add(int num1, int num2);

        int Subtract(int num1, int num2);

        int Multiply(int num1, int num2);

        double Divide(int num1, int num2);
    }
}

using System;

namespace SpecflowDemo
{
    public class Calculator
    {
        public decimal Add(decimal num1, decimal num2)
        {            
            if(num1 < 0 || num2 < 0)
            {
                throw new InvalidOperationException("Negative numbers not allowed");
            }
            return num1 + num2;
        }

        public decimal Subtract(decimal num1, decimal num2)
        {
            return num1 - num2;
        }
    }
}

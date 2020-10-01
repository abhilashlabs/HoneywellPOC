using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HoneywellPOC.Interfaces;

namespace HoneywellPOC.Models
{
    public class Maths: IMaths
    {
        public virtual double Multiply(double a, double b)
        {
            return a * b;
        }

        public virtual double Add(double a, double b)
        {
            return a + b;
        }

        public virtual double Subtract(double a, double b)
        {
            return a - b;
        }

        public virtual double Divide(double a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                return a / b;
            }

        }
    }
}
